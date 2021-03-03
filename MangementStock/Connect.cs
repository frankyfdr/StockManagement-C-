using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace MangementStock
{
    class Connect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string pass;

        private void Initialize()
        { 
            server = "192.168.1.223";
            database = "store";
            user = "root";
            pass = "root";
            string con = "SERVER=" + server + ";" + "DATABASE=" + database +
                ";" + "UID=" + user + ";" + "Pwd=" + pass + ";";
            connection = new MySqlConnection(con);
        }
        public Connect()
        {
            Initialize();
        }
        private bool OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool TestCon()
        {
            if (OpenConnection())
                return true;
            else
                return false;
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
        public MySqlDataReader  getProducts()
        {
           //seting the sql query
            string query = "select * from products";

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            //mysql comamand obeject
            MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;
                cmd.Connection = connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                
                return reader;
        }
        public MySqlDataReader getIngredients()
        {
            //seting the sql query
            string query = "select * from stock";

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            //mysql comamand obeject
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = query;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public MySqlDataReader getProd_ing(int prod_id)
        {
            //checking the state of the connection
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            
            MySqlCommand cmd = new MySqlCommand("geting",connection); //calling the stored procedure
            cmd.CommandType = CommandType.StoredProcedure; //defining the type of the command as sotre presedured
            cmd.Parameters.AddWithValue("@request_prod", prod_id);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }




        public void addIng(int prod_id,int ing_id,int qnt)
        {
            //checking the state of the connection
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            
            MySqlCommand cmd = new MySqlCommand("ing_to_prod",connection); //calling the stored procedure
            cmd.CommandType = CommandType.StoredProcedure; //defining the type of the command as sotre presedured
            cmd.Parameters.AddWithValue("@prod_id", prod_id);
            cmd.Parameters.AddWithValue("@ing_id", ing_id);
            cmd.Parameters.AddWithValue("@qnt", qnt);
            cmd.ExecuteNonQuery();
        }

        


        public void addProduct(string name, int price)
        {
            //seting the sql query
            string query = "INSERT INTO `products` (`name`,`price`) VALUES ('"+name+"',"+price+");";
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();


            //mysql comamand obeject
            MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
            
        }
    }
    
}
