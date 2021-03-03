
namespace MangementStock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_set_up = new System.Windows.Forms.Button();
            this.btn_list_up = new System.Windows.Forms.Button();
            this.lb_sel_prod = new System.Windows.Forms.Label();
            this.lb_metric = new System.Windows.Forms.Label();
            this.nr_qnt = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_list_rem = new System.Windows.Forms.Button();
            this.btn_list_add = new System.Windows.Forms.Button();
            this.list_prod = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dbstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_pro_remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_pro_add = new System.Windows.Forms.Button();
            this.list_choose_ing = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_ing = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_prod_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prod_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ing_up = new System.Windows.Forms.Button();
            this.btn_ing_add = new System.Windows.Forms.Button();
            this.nr_ing_qnt = new System.Windows.Forms.NumericUpDown();
            this.nr_price = new System.Windows.Forms.NumericUpDown();
            this.n = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_metric = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.list_ing_main = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_qnt)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_ing_qnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_price)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_set_up);
            this.tabPage1.Controls.Add(this.btn_list_up);
            this.tabPage1.Controls.Add(this.lb_sel_prod);
            this.tabPage1.Controls.Add(this.lb_metric);
            this.tabPage1.Controls.Add(this.nr_qnt);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btn_list_rem);
            this.tabPage1.Controls.Add(this.btn_list_add);
            this.tabPage1.Controls.Add(this.list_prod);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.btn_pro_remove);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btn_pro_add);
            this.tabPage1.Controls.Add(this.list_choose_ing);
            this.tabPage1.Controls.Add(this.list_ing);
            this.tabPage1.Controls.Add(this.txt_prod_price);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_prod_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_set_up
            // 
            this.btn_set_up.ForeColor = System.Drawing.Color.Black;
            this.btn_set_up.Location = new System.Drawing.Point(353, 20);
            this.btn_set_up.Name = "btn_set_up";
            this.btn_set_up.Size = new System.Drawing.Size(90, 29);
            this.btn_set_up.TabIndex = 22;
            this.btn_set_up.Text = "Update";
            this.btn_set_up.UseVisualStyleBackColor = true;
            this.btn_set_up.Visible = false;
            this.btn_set_up.Click += new System.EventHandler(this.btn_set_up_Click);
            // 
            // btn_list_up
            // 
            this.btn_list_up.Enabled = false;
            this.btn_list_up.ForeColor = System.Drawing.Color.Black;
            this.btn_list_up.Location = new System.Drawing.Point(113, 314);
            this.btn_list_up.Name = "btn_list_up";
            this.btn_list_up.Size = new System.Drawing.Size(75, 29);
            this.btn_list_up.TabIndex = 21;
            this.btn_list_up.Text = "Update";
            this.btn_list_up.UseVisualStyleBackColor = true;
            this.btn_list_up.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_sel_prod
            // 
            this.lb_sel_prod.AutoSize = true;
            this.lb_sel_prod.Location = new System.Drawing.Point(309, 118);
            this.lb_sel_prod.Name = "lb_sel_prod";
            this.lb_sel_prod.Size = new System.Drawing.Size(0, 13);
            this.lb_sel_prod.TabIndex = 20;
            // 
            // lb_metric
            // 
            this.lb_metric.AutoSize = true;
            this.lb_metric.Location = new System.Drawing.Point(325, 325);
            this.lb_metric.Name = "lb_metric";
            this.lb_metric.Size = new System.Drawing.Size(36, 13);
            this.lb_metric.TabIndex = 19;
            this.lb_metric.Text = "Metric";
            this.lb_metric.Click += new System.EventHandler(this.label11_Click);
            // 
            // nr_qnt
            // 
            this.nr_qnt.Location = new System.Drawing.Point(265, 322);
            this.nr_qnt.Name = "nr_qnt";
            this.nr_qnt.Size = new System.Drawing.Size(54, 20);
            this.nr_qnt.TabIndex = 18;
            this.nr_qnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quantity: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btn_list_rem
            // 
            this.btn_list_rem.Enabled = false;
            this.btn_list_rem.Location = new System.Drawing.Point(349, 232);
            this.btn_list_rem.Name = "btn_list_rem";
            this.btn_list_rem.Size = new System.Drawing.Size(32, 23);
            this.btn_list_rem.TabIndex = 15;
            this.btn_list_rem.Text = "<";
            this.btn_list_rem.UseVisualStyleBackColor = true;
            this.btn_list_rem.Click += new System.EventHandler(this.btn_list_rem_Click);
            // 
            // btn_list_add
            // 
            this.btn_list_add.Enabled = false;
            this.btn_list_add.Location = new System.Drawing.Point(349, 184);
            this.btn_list_add.Name = "btn_list_add";
            this.btn_list_add.Size = new System.Drawing.Size(32, 23);
            this.btn_list_add.TabIndex = 14;
            this.btn_list_add.Text = ">";
            this.btn_list_add.UseVisualStyleBackColor = true;
            this.btn_list_add.Click += new System.EventHandler(this.btn_list_add_Click);
            // 
            // list_prod
            // 
            this.list_prod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_name,
            this.col_price});
            this.list_prod.FullRowSelect = true;
            this.list_prod.HideSelection = false;
            this.list_prod.Location = new System.Drawing.Point(28, 150);
            this.list_prod.MultiSelect = false;
            this.list_prod.Name = "list_prod";
            this.list_prod.Size = new System.Drawing.Size(160, 158);
            this.list_prod.TabIndex = 13;
            this.list_prod.UseCompatibleStateImageBehavior = false;
            this.list_prod.View = System.Windows.Forms.View.Details;
            this.list_prod.SelectedIndexChanged += new System.EventHandler(this.list_prod_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 26;
            // 
            // col_name
            // 
            this.col_name.Text = "Name";
            this.col_name.Width = 88;
            // 
            // col_price
            // 
            this.col_price.Text = "Price";
            this.col_price.Width = 40;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbstatus});
            this.statusStrip1.Location = new System.Drawing.Point(3, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(549, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dbstatus
            // 
            this.dbstatus.Name = "dbstatus";
            this.dbstatus.Size = new System.Drawing.Size(61, 17);
            this.dbstatus.Text = "Database: ";
            // 
            // btn_pro_remove
            // 
            this.btn_pro_remove.Enabled = false;
            this.btn_pro_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_pro_remove.Location = new System.Drawing.Point(28, 314);
            this.btn_pro_remove.Name = "btn_pro_remove";
            this.btn_pro_remove.Size = new System.Drawing.Size(79, 29);
            this.btn_pro_remove.TabIndex = 11;
            this.btn_pro_remove.Text = "Remove";
            this.btn_pro_remove.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(424, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_pro_add
            // 
            this.btn_pro_add.Enabled = false;
            this.btn_pro_add.ForeColor = System.Drawing.Color.Black;
            this.btn_pro_add.Location = new System.Drawing.Point(353, 20);
            this.btn_pro_add.Name = "btn_pro_add";
            this.btn_pro_add.Size = new System.Drawing.Size(90, 29);
            this.btn_pro_add.TabIndex = 7;
            this.btn_pro_add.Text = "Add";
            this.btn_pro_add.UseVisualStyleBackColor = true;
            this.btn_pro_add.Click += new System.EventHandler(this.btn_pro_add_Click);
            // 
            // list_choose_ing
            // 
            this.list_choose_ing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.list_choose_ing.FullRowSelect = true;
            this.list_choose_ing.HideSelection = false;
            this.list_choose_ing.Location = new System.Drawing.Point(387, 150);
            this.list_choose_ing.Name = "list_choose_ing";
            this.list_choose_ing.Size = new System.Drawing.Size(148, 166);
            this.list_choose_ing.TabIndex = 6;
            this.list_choose_ing.UseCompatibleStateImageBehavior = false;
            this.list_choose_ing.View = System.Windows.Forms.View.Details;
            this.list_choose_ing.SelectedIndexChanged += new System.EventHandler(this.list_choose_ing_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 29;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 54;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            this.columnHeader6.Width = 63;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Metric";
            // 
            // list_ing
            // 
            this.list_ing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.list_ing.FullRowSelect = true;
            this.list_ing.HideSelection = false;
            this.list_ing.Location = new System.Drawing.Point(221, 150);
            this.list_ing.Name = "list_ing";
            this.list_ing.Size = new System.Drawing.Size(127, 166);
            this.list_ing.TabIndex = 5;
            this.list_ing.UseCompatibleStateImageBehavior = false;
            this.list_ing.View = System.Windows.Forms.View.Details;
            this.list_ing.SelectedIndexChanged += new System.EventHandler(this.list_ing_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Metric";
            this.columnHeader5.Width = 43;
            // 
            // txt_prod_price
            // 
            this.txt_prod_price.Location = new System.Drawing.Point(234, 25);
            this.txt_prod_price.Name = "txt_prod_price";
            this.txt_prod_price.Size = new System.Drawing.Size(100, 20);
            this.txt_prod_price.TabIndex = 3;
            this.txt_prod_price.TextChanged += new System.EventHandler(this.txt_prod_price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(190, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // txt_prod_name
            // 
            this.txt_prod_name.Location = new System.Drawing.Point(72, 25);
            this.txt_prod_name.Name = "txt_prod_name";
            this.txt_prod_name.Size = new System.Drawing.Size(100, 20);
            this.txt_prod_name.TabIndex = 1;
            this.txt_prod_name.TextChanged += new System.EventHandler(this.txt_pro_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ing_up);
            this.tabPage2.Controls.Add(this.btn_ing_add);
            this.tabPage2.Controls.Add(this.nr_ing_qnt);
            this.tabPage2.Controls.Add(this.nr_price);
            this.tabPage2.Controls.Add(this.n);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cmb_metric);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.list_ing_main);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(555, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingredients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ing_up
            // 
            this.btn_ing_up.Location = new System.Drawing.Point(193, 318);
            this.btn_ing_up.Name = "btn_ing_up";
            this.btn_ing_up.Size = new System.Drawing.Size(75, 23);
            this.btn_ing_up.TabIndex = 10;
            this.btn_ing_up.Text = "Update";
            this.btn_ing_up.UseVisualStyleBackColor = true;
            this.btn_ing_up.Visible = false;
            // 
            // btn_ing_add
            // 
            this.btn_ing_add.Location = new System.Drawing.Point(193, 347);
            this.btn_ing_add.Name = "btn_ing_add";
            this.btn_ing_add.Size = new System.Drawing.Size(75, 23);
            this.btn_ing_add.TabIndex = 9;
            this.btn_ing_add.Text = "Add";
            this.btn_ing_add.UseVisualStyleBackColor = true;
            // 
            // nr_ing_qnt
            // 
            this.nr_ing_qnt.Location = new System.Drawing.Point(87, 345);
            this.nr_ing_qnt.Name = "nr_ing_qnt";
            this.nr_ing_qnt.Size = new System.Drawing.Size(49, 20);
            this.nr_ing_qnt.TabIndex = 8;
            this.nr_ing_qnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nr_price
            // 
            this.nr_price.Location = new System.Drawing.Point(85, 282);
            this.nr_price.Name = "nr_price";
            this.nr_price.Size = new System.Drawing.Size(49, 20);
            this.nr_price.TabIndex = 7;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(85, 250);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 20);
            this.n.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Quantity:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Metric:";
            // 
            // cmb_metric
            // 
            this.cmb_metric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_metric.FormattingEnabled = true;
            this.cmb_metric.Items.AddRange(new object[] {
            "kg",
            "ml",
            "g",
            "L",
            "pack",
            "box"});
            this.cmb_metric.Location = new System.Drawing.Point(85, 310);
            this.cmb_metric.Name = "cmb_metric";
            this.cmb_metric.Size = new System.Drawing.Size(56, 21);
            this.cmb_metric.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Price: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Name: ";
            // 
            // list_ing_main
            // 
            this.list_ing_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.list_ing_main.FullRowSelect = true;
            this.list_ing_main.HideSelection = false;
            this.list_ing_main.Location = new System.Drawing.Point(23, 6);
            this.list_ing_main.MultiSelect = false;
            this.list_ing_main.Name = "list_ing_main";
            this.list_ing_main.Size = new System.Drawing.Size(507, 204);
            this.list_ing_main.TabIndex = 0;
            this.list_ing_main.UseCompatibleStateImageBehavior = false;
            this.list_ing_main.View = System.Windows.Forms.View.Details;
            this.list_ing_main.SelectedIndexChanged += new System.EventHandler(this.list_ing_main_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 179;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Quantity";
            this.columnHeader10.Width = 99;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Metric";
            this.columnHeader11.Width = 96;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Price per Lot";
            this.columnHeader12.Width = 77;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.lb_status);
            this.tabPage3.Controls.Add(this.txt_db);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txt_port);
            this.tabPage3.Controls.Add(this.txt_pass);
            this.tabPage3.Controls.Add(this.txt_user);
            this.tabPage3.Controls.Add(this.txt_server);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(555, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 81);
            this.button3.TabIndex = 14;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Green;
            this.lb_status.Location = new System.Drawing.Point(49, 334);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(0, 26);
            this.lb_status.TabIndex = 13;
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(133, 150);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(130, 20);
            this.txt_db.TabIndex = 12;
            this.txt_db.Text = "store";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "DataBase:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Database Settings";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(133, 178);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(130, 20);
            this.txt_port.TabIndex = 9;
            this.txt_port.Text = "3306";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(133, 124);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(130, 20);
            this.txt_pass.TabIndex = 8;
            this.txt_pass.Text = "root";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(133, 98);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(130, 20);
            this.txt_user.TabIndex = 7;
            this.txt_user.Text = "root";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(133, 67);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(130, 20);
            this.txt_server.TabIndex = 6;
            this.txt_server.Text = "192.168.1.223";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Stock Managment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_qnt)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_ing_qnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_price)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_pro_remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_pro_add;
        private System.Windows.Forms.ListView list_choose_ing;
        private System.Windows.Forms.TextBox txt_prod_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_prod_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel dbstatus;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ListView list_prod;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_price;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ListView list_ing;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_list_rem;
        private System.Windows.Forms.Button btn_list_add;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_metric;
        private System.Windows.Forms.NumericUpDown nr_qnt;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lb_sel_prod;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_list_up;
        private System.Windows.Forms.Button btn_set_up;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_ing_up;
        private System.Windows.Forms.Button btn_ing_add;
        private System.Windows.Forms.NumericUpDown nr_ing_qnt;
        private System.Windows.Forms.NumericUpDown nr_price;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_metric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView list_ing_main;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button button3;
    }
}

