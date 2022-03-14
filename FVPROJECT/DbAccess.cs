//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVPROJECT
{
    class DbAccess
    {
        protected OleDbConnection _conn = null;
        public DbAccess(string connectionString)
        {
            _conn = new OleDbConnection(connectionString);
        }

        protected void Connect()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
        }

        protected void Disconnect()
        {
            _conn.Close();
        }

        protected void ExecuteSimpleQuery(OleDbCommand command)
        {
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    command.ExecuteNonQuery();

                }
                finally
                {
                    Disconnect();
                }
            }
        }
        protected int ExecuteScalarIntQuery(OleDbCommand command)
        {
            int ret = -1;
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    ret = (int)command.ExecuteScalar();
                }
                finally
                {
                    Disconnect();
                }
            }
            return ret;
        }
        protected string ExecuteScalarStringQuery(OleDbCommand command)
        {
            string ret ="";
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    ret = Convert.ToString(command.ExecuteScalar());
                }
                finally
                {
                    Disconnect();
                }
            }
            return ret;
        }

        protected DataSet GetMultipleQuery(OleDbCommand command)
        {
            DataSet dataSet = new DataSet();
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet);
                }
                finally
                {
                    Disconnect();
                }
            }
            return dataSet;
        }


    }
}
