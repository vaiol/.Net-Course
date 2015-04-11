using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLaba2
{
    using MySql.Data.MySqlClient;
    using System.Windows;
    class DBConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
 
        public DBConnector()
        {
            Initialize();
        }

        public DBConnector(String adress, String schema, String login, String pass)
        {
            server = adress;
            database = schema;
            uid = login;
            password = pass;

            Console.WriteLine("CONNECT: " + adress + ", " + schema + ", " + login + ", " + pass);

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private void Initialize()
        {
            server = "localhost";
            database = "netLaba2";
            uid = "root";
            password = "zkycewuf";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";CHARSET=UTF8";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    case 1042:
                        MessageBox.Show("Invalid DB adress, please try again");
                        break;
                    case 1049:
                        MessageBox.Show("Schema not found, please try again");
                        break;
                    default:
                        MessageBox.Show("Unknown Error: " + ex.Number);
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(Entity entity)
        {
            string decim = entity.Price + "";
            decim = decim.Replace(",", ".");
            Console.WriteLine(decim);
            string query = "INSERT INTO entity (name, count, price) VALUES('"+ entity.Name+"', '"+ entity.Count +"', '"+ decim +"')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Update(Entity entity)
        {
            string decim = entity.Price + "";
            decim = decim.Replace(",", ".");
            string query = "UPDATE entity SET name='"+ entity.Name +"', count='"+entity.Count+"', price='"+decim+"' WHERE id='"+entity.ID+"'";

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Delete(int id)
        {

            string query = "DELETE FROM entity WHERE id='"+id+"'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<Entity> Select()
        {
            string query = "SELECT * FROM entity";

            //Create a list to store the result
            List<Entity> list = new List<Entity>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Entity tmp = new Entity();
                    tmp.ID = (int) dataReader["id"];
                    tmp.Name = dataReader["name"] + "";
                    tmp.Count = (int) dataReader["count"];
                    String price = dataReader["price"] + "";
                    price = price.Replace(".", ",");
                    tmp.Price = Convert.ToDouble(price);
                    list.Add(tmp);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public Entity Select(int id)
        {
            string query = "SELECT * FROM entity WHERE id='"+id+"'";

            //Create a list to store the result
            Entity result = null;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    result = new Entity();
                    result.ID = (int)dataReader["id"];
                    result.Name = dataReader["name"] + "";
                    result.Count = (int)dataReader["count"];
                    String price = dataReader["price"] + "";
                    price = price.Replace(".", ",");
                    result.Price = Convert.ToDouble(price);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return result;
            }
            else
            {
                return result;
            }
        }


    }
}
