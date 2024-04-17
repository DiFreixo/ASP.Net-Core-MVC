using System.Data;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace LAB05_WebBDMySQL
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string username;
        private string password;
        private string database;
        private string port;


        public DBConnect()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "192.168.1.77"; //"localhost";
            database = "gestaoformandos2";
            username = "programador";
            password = "Server2023!";
            port = "3306";
            string connectionString = "Server = " + server + ";Port = " + port + ";Database = " + database + "; Uid = " + username + "; Pwd = " + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        // open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        //close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

     
        // guardar registo na base de dados
        public bool Insert(string nome, char genero, string idade)
        {
            bool flag = true;

            try
            {
                string query = "Insert into formando (nome, genero, idade) values ('" +
                    nome + "','" + genero + "'," + idade + ")";
                if (this.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                flag = false;
            }
            finally
            {
                this.CloseConnection();
            }
            return flag;
        }

        // apresentar a lista de formandos
        public void CarregarFormandos(ref DropDownList lista)
        {
            try
            {
                string query = "Select id_formando, nome, genero, idade From formando order by id_formando";

                if (this.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    lista.Items.Clear();
                    lista.Items.Add("");
                    while (reader.Read())
                    {
                        lista.Items.Add(reader.GetValue(0).ToString() + " - "
                            + reader.GetValue(1));
                    }
                }
            }
            catch (MySqlException ex)
            {
               Debug.WriteLine(ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public bool DevolverFormando(string id, ref string nome, ref char genero,
            ref int idade)
        {
            try
            {
                string query = "Select id_formando, nome, genero, idade From formando where id_formando = " + id;

                if (this.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        nome = reader.GetString(1);
                        genero = reader.GetChar(2);
                        //genero = reader.GetString(2)[0];
                        idade = reader.GetInt16(3);
                        //idade = int.Parse(reader.GetValue(3).ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                this.CloseConnection();
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                this.CloseConnection();
            }
            return true;
        }


        // apagar registo da tabela formandos da base de dados
        public bool Delete(string id)
        {
            try
            {
                string query = "Delete From formando where id_formando = " + id;
                if (this.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
               Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                this.CloseConnection();
            }
            return true;
        }

        // contagem do número de registos da tabela formandos
        public int Count()
        {
            int count = -1;
            try
            {
                if (this.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("Select Count(*) From formando", connection);
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                }

            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }
            return count;
        }

        public void Bind(ref GridView gv1)
        {
            try
            {
                string query = "Select * From formando order by id_formando";

                // abrir a conexão à base de dados
                if (this.OpenConnection())
                {   // criar o comando MySql
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "formando");
                    gv1.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }

/*
        public double Media()
        {

        }
*/


    }
}