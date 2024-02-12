namespace GeorgeTownCleaningServices
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            txtCustomerPhone = new TextBox();
            txtCustomerName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtDressesQuantity = new NumericUpDown();
            txtPantsQuantity = new NumericUpDown();
            txtShirtsQuantity = new NumericUpDown();
            txtSubTotalDresses = new TextBox();
            txtSubTotalPants = new TextBox();
            txtSubTotalShirts = new TextBox();
            label10 = new Label();
            txtDressPrice = new TextBox();
            txtPantsPrice = new TextBox();
            txtShirtPrice = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            groupBox3 = new GroupBox();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDressesQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPantsQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtShirtsQuantity).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpOrderDate);
            groupBox1.Controls.Add(txtCustomerPhone);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(181, 106);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(344, 26);
            dtpOrderDate.TabIndex = 5;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(181, 67);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(344, 26);
            txtCustomerPhone.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(181, 27);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(344, 26);
            txtCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(19, 114);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 3;
            label3.Text = "Order Date:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F);
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 1;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F);
            label2.Location = new Point(19, 75);
            label2.Name = "label2";
            label2.Size = new Size(121, 18);
            label2.TabIndex = 2;
            label2.Text = "Customer Phone:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDressesQuantity);
            groupBox2.Controls.Add(txtPantsQuantity);
            groupBox2.Controls.Add(txtShirtsQuantity);
            groupBox2.Controls.Add(txtSubTotalDresses);
            groupBox2.Controls.Add(txtSubTotalPants);
            groupBox2.Controls.Add(txtSubTotalShirts);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDressPrice);
            groupBox2.Controls.Add(txtPantsPrice);
            groupBox2.Controls.Add(txtShirtPrice);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(24, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 177);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items";
            // 
            // txtDressesQuantity
            // 
            txtDressesQuantity.Location = new Point(132, 132);
            txtDressesQuantity.Name = "txtDressesQuantity";
            txtDressesQuantity.Size = new Size(69, 26);
            txtDressesQuantity.TabIndex = 22;
            // 
            // txtPantsQuantity
            // 
            txtPantsQuantity.Location = new Point(132, 96);
            txtPantsQuantity.Name = "txtPantsQuantity";
            txtPantsQuantity.Size = new Size(69, 26);
            txtPantsQuantity.TabIndex = 21;
            txtPantsQuantity.ValueChanged += txtPantsQuantity_ValueChanged;
            // 
            // txtShirtsQuantity
            // 
            txtShirtsQuantity.Location = new Point(132, 63);
            txtShirtsQuantity.Name = "txtShirtsQuantity";
            txtShirtsQuantity.Size = new Size(69, 26);
            txtShirtsQuantity.TabIndex = 20;
            txtShirtsQuantity.ValueChanged += txtShirtsQuantity_ValueChanged;
            // 
            // txtSubTotalDresses
            // 
            txtSubTotalDresses.Location = new Point(412, 139);
            txtSubTotalDresses.Name = "txtSubTotalDresses";
            txtSubTotalDresses.ReadOnly = true;
            txtSubTotalDresses.RightToLeft = RightToLeft.Yes;
            txtSubTotalDresses.Size = new Size(79, 26);
            txtSubTotalDresses.TabIndex = 19;
            // 
            // txtSubTotalPants
            // 
            txtSubTotalPants.Location = new Point(412, 101);
            txtSubTotalPants.Name = "txtSubTotalPants";
            txtSubTotalPants.ReadOnly = true;
            txtSubTotalPants.RightToLeft = RightToLeft.Yes;
            txtSubTotalPants.Size = new Size(79, 26);
            txtSubTotalPants.TabIndex = 18;
            // 
            // txtSubTotalShirts
            // 
            txtSubTotalShirts.Location = new Point(412, 67);
            txtSubTotalShirts.Name = "txtSubTotalShirts";
            txtSubTotalShirts.ReadOnly = true;
            txtSubTotalShirts.RightToLeft = RightToLeft.Yes;
            txtSubTotalShirts.Size = new Size(79, 26);
            txtSubTotalShirts.TabIndex = 17;
            txtSubTotalShirts.TextChanged += txtSubTotalShirts_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(412, 34);
            label10.Name = "label10";
            label10.Size = new Size(79, 18);
            label10.TabIndex = 16;
            label10.Text = "SubTotal:";
            // 
            // txtDressPrice
            // 
            txtDressPrice.Location = new Point(267, 134);
            txtDressPrice.Name = "txtDressPrice";
            txtDressPrice.ReadOnly = true;
            txtDressPrice.RightToLeft = RightToLeft.Yes;
            txtDressPrice.Size = new Size(87, 26);
            txtDressPrice.TabIndex = 15;
            // 
            // txtPantsPrice
            // 
            txtPantsPrice.Location = new Point(267, 96);
            txtPantsPrice.Name = "txtPantsPrice";
            txtPantsPrice.ReadOnly = true;
            txtPantsPrice.RightToLeft = RightToLeft.Yes;
            txtPantsPrice.Size = new Size(87, 26);
            txtPantsPrice.TabIndex = 14;
            // 
            // txtShirtPrice
            // 
            txtShirtPrice.Location = new Point(267, 60);
            txtShirtPrice.Name = "txtShirtPrice";
            txtShirtPrice.ReadOnly = true;
            txtShirtPrice.RightToLeft = RightToLeft.Yes;
            txtShirtPrice.Size = new Size(87, 26);
            txtShirtPrice.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(267, 34);
            label9.Name = "label9";
            label9.Size = new Size(87, 18);
            label9.TabIndex = 12;
            label9.Text = "Unit Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(132, 34);
            label8.Name = "label8";
            label8.Size = new Size(78, 18);
            label8.TabIndex = 8;
            label8.Text = "Quantity:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(19, 34);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 7;
            label7.Text = "Items:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 142);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 2;
            label6.Text = "Dresses:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 104);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 1;
            label5.Text = "Pants:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 70);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 0;
            label4.Text = "Shirts:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(43, 472);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(153, 48);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(248, 472);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(153, 48);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(436, 472);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 48);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label41);
            groupBox3.Controls.Add(label40);
            groupBox3.Controls.Add(label39);
            groupBox3.Controls.Add(label38);
            groupBox3.Controls.Add(label37);
            groupBox3.Controls.Add(label36);
            groupBox3.Controls.Add(label35);
            groupBox3.Controls.Add(label34);
            groupBox3.Controls.Add(label33);
            groupBox3.Controls.Add(label32);
            groupBox3.Controls.Add(label31);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(595, 60);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(544, 569);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Invoice";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(362, 442);
            label41.Name = "label41";
            label41.Size = new Size(52, 18);
            label41.TabIndex = 29;
            label41.Text = "label41";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(193, 442);
            label40.Name = "label40";
            label40.Size = new Size(52, 18);
            label40.TabIndex = 28;
            label40.Text = "label40";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(6, 442);
            label39.Name = "label39";
            label39.Size = new Size(52, 18);
            label39.TabIndex = 27;
            label39.Text = "label39";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(424, 317);
            label38.Name = "label38";
            label38.Size = new Size(52, 18);
            label38.TabIndex = 26;
            label38.Text = "label38";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(199, 320);
            label37.Name = "label37";
            label37.Size = new Size(52, 18);
            label37.TabIndex = 25;
            label37.Text = "label37";
            label37.Click += label37_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BorderStyle = BorderStyle.Fixed3D;
            label36.Location = new Point(362, 399);
            label36.Name = "label36";
            label36.Size = new Size(64, 20);
            label36.TabIndex = 24;
            label36.Text = "Change:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BorderStyle = BorderStyle.Fixed3D;
            label35.Location = new Point(206, 399);
            label35.Name = "label35";
            label35.Size = new Size(39, 20);
            label35.TabIndex = 23;
            label35.Text = "Pay:";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BorderStyle = BorderStyle.Fixed3D;
            label34.Location = new Point(6, 399);
            label34.Name = "label34";
            label34.Size = new Size(76, 20);
            label34.TabIndex = 22;
            label34.Text = "Not Total:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BorderStyle = BorderStyle.Fixed3D;
            label33.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.Location = new Point(424, 286);
            label33.Name = "label33";
            label33.Size = new Size(52, 21);
            label33.TabIndex = 21;
            label33.Text = "Taxes";
            label33.Click += label33_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BorderStyle = BorderStyle.Fixed3D;
            label32.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.Location = new Point(193, 288);
            label32.Name = "label32";
            label32.Size = new Size(64, 21);
            label32.TabIndex = 20;
            label32.Text = "tax rate";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(8, 317);
            label31.Name = "label31";
            label31.Size = new Size(52, 18);
            label31.TabIndex = 19;
            label31.Text = "label31";
            label31.Click += label31_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BorderStyle = BorderStyle.Fixed3D;
            label30.Location = new Point(6, 284);
            label30.Name = "label30";
            label30.Size = new Size(62, 20);
            label30.TabIndex = 18;
            label30.Text = "Subtotal";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(395, 224);
            label29.Name = "label29";
            label29.Size = new Size(52, 18);
            label29.TabIndex = 17;
            label29.Text = "label29";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(391, 201);
            label28.Name = "label28";
            label28.Size = new Size(52, 18);
            label28.TabIndex = 16;
            label28.Text = "label28";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(391, 178);
            label27.Name = "label27";
            label27.Size = new Size(52, 18);
            label27.TabIndex = 15;
            label27.Text = "label27";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(199, 232);
            label26.Name = "label26";
            label26.Size = new Size(52, 18);
            label26.TabIndex = 14;
            label26.Text = "label26";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(199, 207);
            label25.Name = "label25";
            label25.Size = new Size(52, 18);
            label25.TabIndex = 13;
            label25.Text = "label25";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(199, 184);
            label24.Name = "label24";
            label24.Size = new Size(52, 18);
            label24.TabIndex = 12;
            label24.Text = "label24";
            label24.Click += label24_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 201);
            label23.Name = "label23";
            label23.Size = new Size(44, 18);
            label23.TabIndex = 11;
            label23.Text = "Pants";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 226);
            label22.Name = "label22";
            label22.Size = new Size(60, 18);
            label22.TabIndex = 10;
            label22.Text = "Dresses";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 178);
            label21.Name = "label21";
            label21.Size = new Size(43, 18);
            label21.TabIndex = 9;
            label21.Text = "Shirts";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BorderStyle = BorderStyle.Fixed3D;
            label20.FlatStyle = FlatStyle.System;
            label20.Location = new Point(395, 132);
            label20.Name = "label20";
            label20.Size = new Size(40, 20);
            label20.TabIndex = 8;
            label20.Text = "Price";
            label20.Click += label20_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Location = new Point(199, 132);
            label19.Name = "label19";
            label19.Size = new Size(41, 20);
            label19.TabIndex = 7;
            label19.Text = "QTY";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Location = new Point(6, 132);
            label18.Name = "label18";
            label18.Size = new Size(54, 20);
            label18.TabIndex = 6;
            label18.Text = "Items ";
            label18.Click += label18_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(450, 53);
            label17.Name = "label17";
            label17.Size = new Size(52, 18);
            label17.TabIndex = 5;
            label17.Text = "label17";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(135, 74);
            label16.Name = "label16";
            label16.Size = new Size(52, 18);
            label16.TabIndex = 4;
            label16.Text = "label16";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(141, 22);
            label15.Name = "label15";
            label15.Size = new Size(52, 18);
            label15.TabIndex = 3;
            label15.Text = "label15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Location = new Point(434, 20);
            label14.Name = "label14";
            label14.Size = new Size(86, 20);
            label14.TabIndex = 2;
            label14.Text = "Order date:";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Location = new Point(6, 72);
            label13.Name = "label13";
            label13.Size = new Size(123, 20);
            label13.TabIndex = 1;
            label13.Text = "Customer Phone:";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.FlatStyle = FlatStyle.Popup;
            label12.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label12.Location = new Point(6, 22);
            label12.Name = "label12";
            label12.Size = new Size(120, 20);
            label12.TabIndex = 0;
            label12.Text = "Customer name:";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.WhiteSmoke;
            label11.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(-5, 11);
            label11.Name = "label11";
            label11.Size = new Size(607, 46);
            label11.TabIndex = 11;
            label11.Text = "GeorgeTown Cleaning Services";
            // 
            // button1
            // 
            button1.Location = new Point(788, 635);
            button1.Name = "button1";
            button1.Size = new Size(153, 38);
            button1.TabIndex = 0;
            button1.Text = "Clean";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1184, 672);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(groupBox3);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 11.25F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "GeorgeTown Cleaning Services";
            Load += frmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDressesQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPantsQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtShirtsQuantity).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCustomerName;
        private Label label3;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpOrderDate;
        private TextBox txtCustomerPhone;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtDressPrice;
        private TextBox txtPantsPrice;
        private TextBox txtShirtPrice;
        private Label label9;
        private TextBox txtSubTotalDresses;
        private TextBox txtSubTotalPants;
        private TextBox txtSubTotalShirts;
        private Label label10;
        private Button btnCalculate;
        private Button btnCancel;
        private Button btnExit;
        private GroupBox groupBox3;
        private Label label11;
        private NumericUpDown txtDressesQuantity;
        private NumericUpDown txtPantsQuantity;
        private NumericUpDown txtShirtsQuantity;
        private Button button1;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label18;
        private Label label20;
        private Label label19;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label34;
        private Label label36;
        private Label label35;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label41;
    }
}
