namespace SI2021_16_RentACar
{
    partial class Rent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1_rent = new System.Windows.Forms.Label();
            this.label2_rentacar = new System.Windows.Forms.Label();
            this.label3_ajs = new System.Windows.Forms.Label();
            this.panel2_upper = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1_under = new System.Windows.Forms.Panel();
            this.listBox1_rentacarlist = new System.Windows.Forms.ListBox();
            this.label3_address = new System.Windows.Forms.Label();
            this.button1_next = new System.Windows.Forms.Button();
            this.button2_back = new System.Windows.Forms.Button();
            this.textBox4_upin = new System.Windows.Forms.TextBox();
            this.label6_carid = new System.Windows.Forms.Label();
            this.label8_startdate = new System.Windows.Forms.Label();
            this.label7_amount = new System.Windows.Forms.Label();
            this.button1_delete = new System.Windows.Forms.Button();
            this.button2_add = new System.Windows.Forms.Button();
            this.textBox6_carid = new System.Windows.Forms.TextBox();
            this.textBox7_amount = new System.Windows.Forms.TextBox();
            this.label9_price = new System.Windows.Forms.Label();
            this.textBox8_price = new System.Windows.Forms.TextBox();
            this.label5_number = new System.Windows.Forms.Label();
            this.textBox5_number = new System.Windows.Forms.TextBox();
            this.label3_upin = new System.Windows.Forms.Label();
            this.textBox3_upin = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2_upper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1_under.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 55);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label1_rent
            // 
            this.label1_rent.AutoSize = true;
            this.label1_rent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.label1_rent.Location = new System.Drawing.Point(432, 62);
            this.label1_rent.Name = "label1_rent";
            this.label1_rent.Size = new System.Drawing.Size(53, 25);
            this.label1_rent.TabIndex = 31;
            this.label1_rent.Text = "Rent";
            this.label1_rent.Click += new System.EventHandler(this.label1_mainmenu_Click);
            // 
            // label2_rentacar
            // 
            this.label2_rentacar.AutoSize = true;
            this.label2_rentacar.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.label2_rentacar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.label2_rentacar.Location = new System.Drawing.Point(377, 6);
            this.label2_rentacar.Name = "label2_rentacar";
            this.label2_rentacar.Size = new System.Drawing.Size(173, 42);
            this.label2_rentacar.TabIndex = 30;
            this.label2_rentacar.Text = "Rent A Car";
            this.label2_rentacar.Click += new System.EventHandler(this.label2_rentacar_Click);
            // 
            // label3_ajs
            // 
            this.label3_ajs.AutoSize = true;
            this.label3_ajs.Font = new System.Drawing.Font("Pristina", 50F);
            this.label3_ajs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.label3_ajs.Location = new System.Drawing.Point(746, 12);
            this.label3_ajs.Name = "label3_ajs";
            this.label3_ajs.Size = new System.Drawing.Size(145, 88);
            this.label3_ajs.TabIndex = 28;
            this.label3_ajs.Text = "AJS";
            // 
            // panel2_upper
            // 
            this.panel2_upper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.panel2_upper.Controls.Add(this.label2);
            this.panel2_upper.Controls.Add(this.pictureBox3);
            this.panel2_upper.Controls.Add(this.close_button);
            this.panel2_upper.Controls.Add(this.pictureBox2);
            this.panel2_upper.Controls.Add(this.label1_rent);
            this.panel2_upper.Controls.Add(this.label2_rentacar);
            this.panel2_upper.Controls.Add(this.label3_ajs);
            this.panel2_upper.Location = new System.Drawing.Point(0, -1);
            this.panel2_upper.Name = "panel2_upper";
            this.panel2_upper.Size = new System.Drawing.Size(935, 100);
            this.panel2_upper.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(27, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Rent a Car - AJS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 18);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // close_button
            // 
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(906, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(29, 23);
            this.close_button.TabIndex = 35;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(406, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "© 2021. AJS Soft";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1_under
            // 
            this.panel1_under.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.panel1_under.Controls.Add(this.label1);
            this.panel1_under.Location = new System.Drawing.Point(0, 495);
            this.panel1_under.Name = "panel1_under";
            this.panel1_under.Size = new System.Drawing.Size(935, 34);
            this.panel1_under.TabIndex = 31;
            // 
            // listBox1_rentacarlist
            // 
            this.listBox1_rentacarlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.listBox1_rentacarlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1_rentacarlist.FormattingEnabled = true;
            this.listBox1_rentacarlist.Location = new System.Drawing.Point(337, 111);
            this.listBox1_rentacarlist.Name = "listBox1_rentacarlist";
            this.listBox1_rentacarlist.Size = new System.Drawing.Size(558, 275);
            this.listBox1_rentacarlist.TabIndex = 32;
            // 
            // label3_address
            // 
            this.label3_address.AutoSize = true;
            this.label3_address.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label3_address.Location = new System.Drawing.Point(21, 123);
            this.label3_address.Name = "label3_address";
            this.label3_address.Size = new System.Drawing.Size(70, 20);
            this.label3_address.TabIndex = 36;
            this.label3_address.Text = "Address:";
            // 
            // button1_next
            // 
            this.button1_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.button1_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_next.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button1_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.button1_next.Location = new System.Drawing.Point(802, 435);
            this.button1_next.Name = "button1_next";
            this.button1_next.Size = new System.Drawing.Size(93, 33);
            this.button1_next.TabIndex = 38;
            this.button1_next.Text = "Next";
            this.button1_next.UseVisualStyleBackColor = false;
            this.button1_next.Click += new System.EventHandler(this.button1_next_Click);
            // 
            // button2_back
            // 
            this.button2_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.button2_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_back.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button2_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.button2_back.Location = new System.Drawing.Point(36, 435);
            this.button2_back.Name = "button2_back";
            this.button2_back.Size = new System.Drawing.Size(93, 33);
            this.button2_back.TabIndex = 39;
            this.button2_back.Text = "Back";
            this.button2_back.UseVisualStyleBackColor = false;
            this.button2_back.Click += new System.EventHandler(this.button2_back_Click);
            // 
            // textBox4_upin
            // 
            this.textBox4_upin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.textBox4_upin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4_upin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.textBox4_upin.Location = new System.Drawing.Point(113, 123);
            this.textBox4_upin.Name = "textBox4_upin";
            this.textBox4_upin.Size = new System.Drawing.Size(177, 20);
            this.textBox4_upin.TabIndex = 44;
            this.textBox4_upin.TextChanged += new System.EventHandler(this.textBox4_upin_TextChanged);
            // 
            // label6_carid
            // 
            this.label6_carid.AutoSize = true;
            this.label6_carid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label6_carid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label6_carid.Location = new System.Drawing.Point(21, 209);
            this.label6_carid.Name = "label6_carid";
            this.label6_carid.Size = new System.Drawing.Size(56, 20);
            this.label6_carid.TabIndex = 45;
            this.label6_carid.Text = "Car ID:";
            this.label6_carid.Click += new System.EventHandler(this.label6_carid_Click);
            // 
            // label8_startdate
            // 
            this.label8_startdate.AutoSize = true;
            this.label8_startdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8_startdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label8_startdate.Location = new System.Drawing.Point(21, 301);
            this.label8_startdate.Name = "label8_startdate";
            this.label8_startdate.Size = new System.Drawing.Size(40, 20);
            this.label8_startdate.TabIndex = 46;
            this.label8_startdate.Text = "Day:";
            this.label8_startdate.Click += new System.EventHandler(this.label8_startdate_Click);
            // 
            // label7_amount
            // 
            this.label7_amount.AutoSize = true;
            this.label7_amount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label7_amount.Location = new System.Drawing.Point(21, 240);
            this.label7_amount.Name = "label7_amount";
            this.label7_amount.Size = new System.Drawing.Size(71, 20);
            this.label7_amount.TabIndex = 47;
            this.label7_amount.Text = "Amount:";
            this.label7_amount.Click += new System.EventHandler(this.label7_amount_Click);
            // 
            // button1_delete
            // 
            this.button1_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.button1_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_delete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button1_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.button1_delete.Location = new System.Drawing.Point(197, 343);
            this.button1_delete.Name = "button1_delete";
            this.button1_delete.Size = new System.Drawing.Size(93, 33);
            this.button1_delete.TabIndex = 48;
            this.button1_delete.Text = "Delete";
            this.button1_delete.UseVisualStyleBackColor = false;
            // 
            // button2_add
            // 
            this.button2_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.button2_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button2_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.button2_add.Location = new System.Drawing.Point(25, 343);
            this.button2_add.Name = "button2_add";
            this.button2_add.Size = new System.Drawing.Size(93, 33);
            this.button2_add.TabIndex = 49;
            this.button2_add.Text = "Add";
            this.button2_add.UseVisualStyleBackColor = false;
            this.button2_add.Click += new System.EventHandler(this.button2_add_Click);
            // 
            // textBox6_carid
            // 
            this.textBox6_carid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.textBox6_carid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6_carid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.textBox6_carid.Location = new System.Drawing.Point(113, 209);
            this.textBox6_carid.Name = "textBox6_carid";
            this.textBox6_carid.Size = new System.Drawing.Size(177, 20);
            this.textBox6_carid.TabIndex = 50;
            this.textBox6_carid.TextChanged += new System.EventHandler(this.textBox6_carid_TextChanged);
            // 
            // textBox7_amount
            // 
            this.textBox7_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.textBox7_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.textBox7_amount.Location = new System.Drawing.Point(113, 240);
            this.textBox7_amount.Name = "textBox7_amount";
            this.textBox7_amount.Size = new System.Drawing.Size(177, 20);
            this.textBox7_amount.TabIndex = 51;
            // 
            // label9_price
            // 
            this.label9_price.AutoSize = true;
            this.label9_price.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label9_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label9_price.Location = new System.Drawing.Point(21, 271);
            this.label9_price.Name = "label9_price";
            this.label9_price.Size = new System.Drawing.Size(47, 20);
            this.label9_price.TabIndex = 53;
            this.label9_price.Text = "Price:";
            this.label9_price.Click += new System.EventHandler(this.label9_price_Click);
            // 
            // textBox8_price
            // 
            this.textBox8_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.textBox8_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.textBox8_price.Location = new System.Drawing.Point(113, 271);
            this.textBox8_price.Name = "textBox8_price";
            this.textBox8_price.Size = new System.Drawing.Size(177, 20);
            this.textBox8_price.TabIndex = 54;
            this.textBox8_price.TextChanged += new System.EventHandler(this.textBox8_price_TextChanged);
            // 
            // label5_number
            // 
            this.label5_number.AutoSize = true;
            this.label5_number.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label5_number.Location = new System.Drawing.Point(21, 154);
            this.label5_number.Name = "label5_number";
            this.label5_number.Size = new System.Drawing.Size(72, 20);
            this.label5_number.TabIndex = 56;
            this.label5_number.Text = "Number:";
            // 
            // textBox5_number
            // 
            this.textBox5_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.textBox5_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.textBox5_number.Location = new System.Drawing.Point(113, 152);
            this.textBox5_number.Name = "textBox5_number";
            this.textBox5_number.Size = new System.Drawing.Size(177, 20);
            this.textBox5_number.TabIndex = 57;
            // 
            // label3_upin
            // 
            this.label3_upin.AutoSize = true;
            this.label3_upin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3_upin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.label3_upin.Location = new System.Drawing.Point(21, 183);
            this.label3_upin.Name = "label3_upin";
            this.label3_upin.Size = new System.Drawing.Size(50, 20);
            this.label3_upin.TabIndex = 61;
            this.label3_upin.Text = "UPIN:";
            // 
            // textBox3_upin
            // 
            this.textBox3_upin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.textBox3_upin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3_upin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.textBox3_upin.Location = new System.Drawing.Point(113, 183);
            this.textBox3_upin.Name = "textBox3_upin";
            this.textBox3_upin.Size = new System.Drawing.Size(177, 20);
            this.textBox3_upin.TabIndex = 62;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.numericUpDown1.Location = new System.Drawing.Point(113, 301);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 20);
            this.numericUpDown1.TabIndex = 64;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.panel2.Location = new System.Drawing.Point(-9, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 503);
            this.panel2.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.panel1.Location = new System.Drawing.Point(930, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 407);
            this.panel1.TabIndex = 66;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(933, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3_upin);
            this.Controls.Add(this.label3_upin);
            this.Controls.Add(this.textBox5_number);
            this.Controls.Add(this.label5_number);
            this.Controls.Add(this.textBox8_price);
            this.Controls.Add(this.label9_price);
            this.Controls.Add(this.textBox7_amount);
            this.Controls.Add(this.textBox6_carid);
            this.Controls.Add(this.button2_add);
            this.Controls.Add(this.button1_delete);
            this.Controls.Add(this.label7_amount);
            this.Controls.Add(this.label8_startdate);
            this.Controls.Add(this.label6_carid);
            this.Controls.Add(this.textBox4_upin);
            this.Controls.Add(this.button2_back);
            this.Controls.Add(this.button1_next);
            this.Controls.Add(this.label3_address);
            this.Controls.Add(this.listBox1_rentacarlist);
            this.Controls.Add(this.panel1_under);
            this.Controls.Add(this.panel2_upper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent a Car - AJS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rent_FormClosed);
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2_upper.ResumeLayout(false);
            this.panel2_upper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1_under.ResumeLayout(false);
            this.panel1_under.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1_rent;
        private System.Windows.Forms.Label label2_rentacar;
        private System.Windows.Forms.Label label3_ajs;
        private System.Windows.Forms.Panel panel2_upper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1_under;
        private System.Windows.Forms.ListBox listBox1_rentacarlist;
        private System.Windows.Forms.Label label3_address;
        private System.Windows.Forms.Button button1_next;
        private System.Windows.Forms.Button button2_back;
        private System.Windows.Forms.TextBox textBox4_upin;
        private System.Windows.Forms.Label label6_carid;
        private System.Windows.Forms.Label label8_startdate;
        private System.Windows.Forms.Label label7_amount;
        private System.Windows.Forms.Button button1_delete;
        private System.Windows.Forms.Button button2_add;
        private System.Windows.Forms.TextBox textBox6_carid;
        private System.Windows.Forms.TextBox textBox7_amount;
        private System.Windows.Forms.Label label9_price;
        private System.Windows.Forms.TextBox textBox8_price;
        private System.Windows.Forms.Label label5_number;
        private System.Windows.Forms.TextBox textBox5_number;
        private System.Windows.Forms.Label label3_upin;
        private System.Windows.Forms.TextBox textBox3_upin;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}