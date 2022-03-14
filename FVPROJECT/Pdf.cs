using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MyFont = iTextSharp.text.Font;
using System.Windows.Forms;
//יצירת קובץ PDF
namespace FVPROJECT
{
    class Pdf
    {
        private MyFont myfont;
        private MyFont myfont1;
        private Document doc;

        public Pdf()
        {
          doc = new Document();
          myfont = new MyFont(MyFont.FontFamily.COURIER, 14, MyFont.ITALIC);
          myfont1 = new MyFont(MyFont.FontFamily.COURIER, 14, MyFont.ITALIC, BaseColor.BLUE);
          doc.Open();

        }

        //pdf name
        public Pdf(string name)
        {
            doc = new Document();
            ///////////////////////////////////////////
            ///לצור הכתב שיאפשר גם לשפה העברית
            var ARIALUNI_TFF = @"C:\Windows\Fonts\Arial.TTF";
            //Create a base font object making sure to specify IDENTITY-H
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            
            //Create a specific font object
            myfont1 = new iTextSharp.text.Font(bf, 12);
            myfont= new iTextSharp.text.Font(bf, 16);
            ///////////
            var savepath = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Orders",name + ".pdf");
            PdfWriter.GetInstance(doc, new FileStream(savepath, FileMode.Create));
            doc.Open();

        }
        //pdf title
        public void SetTitle(string title)
        {
            if (title != string.Empty)
            {
                PdfPTable myTable = new PdfPTable(1);
                myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                PdfPCell myCell = new PdfPCell();
                myCell.Border = Rectangle.NO_BORDER;
                myCell.HorizontalAlignment = Element.ALIGN_CENTER;
                myCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                myCell.Phrase = new Phrase(title, myfont);
                myTable.AddCell(myCell);
                doc.Add(myTable);
                doc.Add(new Paragraph("\n"));
            }
        }
        //set image 
        public void SetImage(string imagePath)
        {
            Image image = Image.GetInstance(imagePath);
            image.ScaleAbsolute(500, 70);
            
            doc.Add(image);
            doc.Add(new Paragraph("\n\n\n"));
        }

        public void SetDate()
        {
            string str = DateTime.Now.ToString("dd/MM/yyyy")+" :ךיראת";
            doc.Add(new Paragraph(str,myfont1));
            doc.Add(new Paragraph("\n\n\n"));
        }

        //insertOrder
        public void insertOrder(Order[] orders)
        {
            //חמשה עמודות
            int tableWidth = 5;

            PdfPTable myTable = new PdfPTable(tableWidth);
            myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            myTable.HorizontalAlignment = Element.ALIGN_CENTER;

            //set column width in percent
            float[] widthCell = new float[tableWidth];
            for (int i = 0; i < tableWidth; i++)
                widthCell[i] = 100 / tableWidth;

            myTable.SetTotalWidth(widthCell);


            PdfPCell myCell = new PdfPCell();
            
            myCell.FixedHeight = 20;
            myCell.BorderColor = BaseColor.DARK_GRAY;
            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
            myCell.VerticalAlignment = Element.ALIGN_MIDDLE;
           

            myCell.Phrase = new Phrase("קוד מוצר", myfont1);
            myTable.AddCell(myCell);
            myCell.Phrase = new Phrase("תיאור פריט", myfont1);
            myTable.AddCell(myCell);
            myCell.Phrase = new Phrase("מחיר", myfont1);
            myTable.AddCell(myCell);
            myCell.Phrase = new Phrase("כמות", myfont1);
            myTable.AddCell(myCell);
            myCell.Phrase = new Phrase("מחיר כולל", myfont1);
            myTable.AddCell(myCell);

            for (int i = 0; i < orders.Length; i++)
            {
                myCell.Phrase = new Phrase(orders[i].ProductId, myfont1);
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(orders[i].ProductName, myfont1);
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(orders[i].ProductPrice.ToString(), myfont1);
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(orders[i].ProductCount.ToString(), myfont1);
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(orders[i].TotalPrice.ToString(), myfont1);
                myTable.AddCell(myCell);

            }
            doc.Add(myTable);
            doc.Add(new Paragraph("\n\n\n"));
        }

        //pdf title
        public void SetCSDetails(string sellerName,string clientName,string totalPrice)
        {
                PdfPTable myTable = new PdfPTable(3);
                myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                PdfPCell myCell = new PdfPCell();
                myCell.Border = Rectangle.NO_BORDER;
                myCell.HorizontalAlignment = Element.ALIGN_CENTER;
                myCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                //////////////////////////////////////
                ///כותרות
                myCell.Phrase = new Phrase("שם המוכר", myfont);
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase("שם הלקוח", myfont);
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase("מחיר כולל", myfont);
                myTable.AddCell(myCell);
                
                /////////////////
                ///נתונים
                myCell.Phrase = new Phrase(sellerName, myfont1);
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(clientName, myfont1);
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(totalPrice, myfont1);
                myTable.AddCell(myCell);
                doc.Add(myTable);
                doc.Add(new Paragraph("\n"));
        }
        public void CloseReport()
        {
            doc.Close();
        }


    }
   
}
