using System;
using System.Data.SQLite;
using System.Diagnostics;

namespace LAB03_WebInquerito { 

   
    public class DBConnect
    {
        private SQLiteConnection connection;
        public DBConnect() 
        {
            Initialize();
        }


        private void Initialize()
        {
            string connectionString;
            string path = AppDomain.CurrentDomain.BaseDirectory + "bin\\";
            connectionString = "Data source = " + path + "inquerito.db; Version = 3;";
            connection = new SQLiteConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SQLiteException ex)
            {

                Debug.WriteLine(ex.Message);
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
       
        public bool Insert(string nome, string distrito, string comida, string clube)
        {
            try 
            {
                string query = "INSERT INTO dados (nome, distrito, comida, clube) " +
                    "VALUES ('" + nome + "', '" + distrito + "', '" + comida + "', '" + clube + "');";

                if(this.OpenConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex) 
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }

            return true;
        }


        public int Count()
        {
            int count = -1;
            string query = "select count(*) from dados";
            try
            {
                if (OpenConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }

        /*
        public bool Delete(string id)
        {
            try
            {
                string query = "DELETE FROM dados WHERE id = '" + id + "';";


                if (this.OpenConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }


            return true;
        }
        

        

        public bool Update(string nome, string distrito, string comida, string clube, string id)
        {
            try
            {
                string query = "UPDATE dados set nome = '" + nome + "', distrito = '" + distrito + "', comida = '" + comida + "', clube = '" + clube + "'  WHERE id = '" + id + "';";

                if (this.OpenConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }


            return true;
        }
        */
    }
}