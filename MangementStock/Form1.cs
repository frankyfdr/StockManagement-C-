using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MangementStock
{
    public partial class Form1 : Form
    {
        Connect con = new Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();

           
        }
        public void load()
        {

            if (con.TestCon())
                dbstatus.Text += "Connected";
            else
                dbstatus.Text += "Disconnected";


            setProducts();
            setIngrediets();

            con.CloseConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

       private void setProducts()
        {
            MySqlDataReader reader = con.getProducts();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["id"].ToString();
                item.SubItems.Add(reader["name"].ToString());
                item.SubItems.Add(reader["price"].ToString());
                list_prod.Items.Add(item);
            }
            reader.Close();
        }

        private void setIngrediets()
        {
            MySqlDataReader reader = con.getIngredients();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                ListViewItem item_main = new ListViewItem();
                string id = reader["id"].ToString();
                string name = reader["name"].ToString();
                string metric = reader["metric"].ToString();
                string qnt = reader["quantity"].ToString();
                string price = reader["price"].ToString();

                item.Text = id;
                item.SubItems.Add(name);
                item.SubItems.Add(metric);
                list_ing.Items.Add(item);

                item_main.Text = id;
                item_main.SubItems.Add(name);
                item_main.SubItems.Add(qnt);
                item_main.SubItems.Add(metric);
                item_main.SubItems.Add(price);
                list_ing_main.Items.Add(item_main);
                
            }
            reader.Close();
        }
        private void enable()
        {
            if (txt_prod_price.Text != "" && txt_prod_name.Text != "")
                btn_pro_add.Enabled = true;
                    
        }

        private void txt_prod_price_TextChanged(object sender, EventArgs e)
        {
            enable();
        }

        private void txt_pro_name_TextChanged(object sender, EventArgs e)
        {
            enable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = txt_server.Text;
            string database = txt_db.Text;
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            string port = txt_port.Text;
            string con = "SERVER=" + server + ";Port="+port + ";DATABASE=" + database +
                ";" + "UID=" + user + ";" + "Pwd=" + pass + ";";
            MySqlConnection connection = new MySqlConnection(con);

            try
            {
                connection.Open();
                lb_status.Text = "Connection Sucessfull";
            }
            catch(MySqlException ex)
            {
                lb_status.Text = "";
                MessageBox.Show(ex.Message);
                MessageBox.Show(con);
            }
        }

   

        private void btn_pro_add_Click(object sender, EventArgs e)
        {
            con.addProduct(txt_prod_name.Text,Convert.ToInt32(txt_prod_price.Text));
            list_prod.Items.Clear();
            setProducts();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_list_add_Click(object sender, EventArgs e)
        {
            if (lb_sel_prod.Text != "")
            {
                string id = list_ing.SelectedItems[0].Text;
                string name = list_ing.SelectedItems[0].SubItems[1].Text;

                list_ing.Items[list_ing.SelectedIndices[0]].Remove();

                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(nr_qnt.Value.ToString());
                item.SubItems.Add(lb_metric.Text);
                list_choose_ing.Items.Add(item);
            }
            else
                MessageBox.Show("Warning", "Select a product from the list first", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void list_ing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_ing.SelectedItems.Count != 0)
            {
                string metric = list_ing.SelectedItems[0].SubItems[2].Text;
                lb_metric.Text = metric;
                btn_list_add.Enabled = true;
            }
            else
                btn_list_add.Enabled = false;
        }

        private void btn_list_rem_Click(object sender, EventArgs e)
        {
            string id = list_choose_ing.SelectedItems[0].Text;
            string name = list_choose_ing.SelectedItems[0].SubItems[1].Text;
            string metric = list_choose_ing.SelectedItems[0].SubItems[3].Text;

            list_choose_ing.Items[list_choose_ing.SelectedIndices[0]].Remove();

            ListViewItem item = new ListViewItem(id);
            item.SubItems.Add(name);
            item.SubItems.Add(metric);
            list_ing.Items.Add(item);
        }

        private void list_choose_ing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_choose_ing.SelectedItems.Count != 0)
            {
                btn_list_rem.Enabled = true;
            }
            else
                btn_list_rem.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = list_prod.SelectedItems[0].SubItems[1].Text;
            string price = list_prod.SelectedItems[0].SubItems[2].Text;
            txt_prod_name.Text = name;
            txt_prod_price.Text = price;

            btn_set_up.Visible = true;
            btn_pro_add.Visible = false;
        }

        private void btn_set_up_Click(object sender, EventArgs e)
        {
            btn_set_up.Visible = false;
            btn_pro_add.Visible = true;
            txt_prod_name.Text = "";
            txt_prod_price.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int prod_id = Convert.ToInt32(lb_sel_prod.Text);

            for (int idx = 0; idx < list_choose_ing.Items.Count; idx++)
            {
                int ing_id = Convert.ToInt32(list_choose_ing.Items[idx].Text);
                int qnt = Convert.ToInt32(list_choose_ing.Items[idx].SubItems[2].Text);
                con.addIng(prod_id, ing_id, qnt);
            }
        }

        private void list_ing_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list_ing_main.SelectedItems.Count != 0)
            {
                btn_ing_up.Visible = true;
            }
            else
                btn_ing_up.Visible = false;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            load();
        }

        private void list_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_prod.SelectedItems.Count != 0)
            {
                list_choose_ing.Items.Clear();
                btn_pro_remove.Enabled = true;
                btn_list_up.Enabled = true;
                lb_sel_prod.Text = list_prod.SelectedItems[0].Text;
                MySqlDataReader reader = con.getProd_ing(Convert.ToInt32(list_prod.SelectedItems[0].Text));

                while (reader.Read())
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = reader["id"].ToString();
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["quantity"].ToString());
                    item.SubItems.Add(reader["metric"].ToString());
                    list_choose_ing.Items.Add(item);
                }
                reader.Close();
            }
            else
            {
                btn_pro_remove.Enabled = false;
                btn_list_up.Enabled = false;
                lb_sel_prod.Text = "";
            }
        }
    }
}
