namespace Ayubo_Drive_Management_System
{
    partial class frm_bill
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_driver_no = new System.Windows.Forms.RadioButton();
            this.rbtn_driver_yes = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_driverID = new System.Windows.Forms.TextBox();
            this.txt_customerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_customerTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_customerNIC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_vehicletype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_package = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_start_km_read = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_overnight_stay_price = new System.Windows.Forms.Label();
            this.lbl_waiting_hire_charge = new System.Windows.Forms.Label();
            this.lbl_extra_km_charge = new System.Windows.Forms.Label();
            this.lbl_extra_driver_charge = new System.Windows.Forms.Label();
            this.lbl_total_bill = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_hire = new System.Windows.Forms.RadioButton();
            this.rbtn_rent = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_hours = new System.Windows.Forms.TextBox();
            this.txt_end_km_read = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpreturndate = new System.Windows.Forms.DateTimePicker();
            this.dtprentdate = new System.Windows.Forms.DateTimePicker();
            this.dtprenttime = new System.Windows.Forms.DateTimePicker();
            this.dtpreturntime = new System.Windows.Forms.DateTimePicker();
            this.btnfind = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_vehicle_no = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbl_base_package_charge = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Tomato;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btn_clear.Location = new System.Drawing.Point(1215, 550);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 37);
            this.btn_clear.TabIndex = 35;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btn_save.Location = new System.Drawing.Point(1328, 550);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 37);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtn_driver_no);
            this.groupBox1.Controls.Add(this.rbtn_driver_yes);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(733, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(131, 50);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_driver_no
            // 
            this.rbtn_driver_no.AutoSize = true;
            this.rbtn_driver_no.Location = new System.Drawing.Point(72, 20);
            this.rbtn_driver_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_driver_no.Name = "rbtn_driver_no";
            this.rbtn_driver_no.Size = new System.Drawing.Size(46, 20);
            this.rbtn_driver_no.TabIndex = 1;
            this.rbtn_driver_no.Text = "No";
            this.rbtn_driver_no.UseVisualStyleBackColor = true;
            // 
            // rbtn_driver_yes
            // 
            this.rbtn_driver_yes.AutoSize = true;
            this.rbtn_driver_yes.Checked = true;
            this.rbtn_driver_yes.Location = new System.Drawing.Point(12, 20);
            this.rbtn_driver_yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_driver_yes.Name = "rbtn_driver_yes";
            this.rbtn_driver_yes.Size = new System.Drawing.Size(52, 20);
            this.rbtn_driver_yes.TabIndex = 0;
            this.rbtn_driver_yes.TabStop = true;
            this.rbtn_driver_yes.Text = "Yes";
            this.rbtn_driver_yes.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(573, 356);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "With Driver?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(573, 409);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Driver ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Customer ID";
            // 
            // txt_driverID
            // 
            this.txt_driverID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_driverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverID.Location = new System.Drawing.Point(733, 407);
            this.txt_driverID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_driverID.Name = "txt_driverID";
            this.txt_driverID.Size = new System.Drawing.Size(213, 22);
            this.txt_driverID.TabIndex = 29;
            // 
            // txt_customerID
            // 
            this.txt_customerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerID.Location = new System.Drawing.Point(185, 74);
            this.txt_customerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(167, 22);
            this.txt_customerID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Customer Name";
            // 
            // txt_customerName
            // 
            this.txt_customerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerName.Location = new System.Drawing.Point(185, 137);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(288, 22);
            this.txt_customerName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Telephone";
            // 
            // txt_customerTP
            // 
            this.txt_customerTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customerTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerTP.Location = new System.Drawing.Point(185, 197);
            this.txt_customerTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerTP.Name = "txt_customerTP";
            this.txt_customerTP.Size = new System.Drawing.Size(208, 22);
            this.txt_customerTP.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "NIC";
            // 
            // txt_customerNIC
            // 
            this.txt_customerNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customerNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerNIC.Location = new System.Drawing.Point(185, 258);
            this.txt_customerNIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerNIC.Name = "txt_customerNIC";
            this.txt_customerNIC.Size = new System.Drawing.Size(208, 22);
            this.txt_customerNIC.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Vehicle type";
            // 
            // txt_vehicletype
            // 
            this.txt_vehicletype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vehicletype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicletype.Location = new System.Drawing.Point(185, 316);
            this.txt_vehicletype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_vehicletype.Name = "txt_vehicletype";
            this.txt_vehicletype.Size = new System.Drawing.Size(208, 22);
            this.txt_vehicletype.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Package";
            // 
            // txt_package
            // 
            this.txt_package.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_package.Location = new System.Drawing.Point(733, 60);
            this.txt_package.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_package.Name = "txt_package";
            this.txt_package.Size = new System.Drawing.Size(208, 22);
            this.txt_package.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Rent Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(573, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Return Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Rented date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(573, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 53;
            this.label9.Text = "Return date";
            // 
            // txt_start_km_read
            // 
            this.txt_start_km_read.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_start_km_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_start_km_read.Location = new System.Drawing.Point(175, 38);
            this.txt_start_km_read.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_start_km_read.Name = "txt_start_km_read";
            this.txt_start_km_read.Size = new System.Drawing.Size(121, 22);
            this.txt_start_km_read.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(573, 546);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 57;
            this.label14.Text = "No. Hours";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1073, 196);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(258, 25);
            this.label15.TabIndex = 60;
            this.label15.Text = "Extra km Charges            Rs.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1076, 159);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(264, 25);
            this.label17.TabIndex = 58;
            this.label17.Text = "Overnight Stay Price       Rs.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1073, 240);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(267, 25);
            this.label18.TabIndex = 61;
            this.label18.Text = "Waiting hire Charges       Rs.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1075, 283);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(260, 25);
            this.label19.TabIndex = 62;
            this.label19.Text = "Extra driver Charges       Rs.";
            // 
            // lbl_overnight_stay_price
            // 
            this.lbl_overnight_stay_price.AutoSize = true;
            this.lbl_overnight_stay_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_overnight_stay_price.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overnight_stay_price.Location = new System.Drawing.Point(1339, 161);
            this.lbl_overnight_stay_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_overnight_stay_price.Name = "lbl_overnight_stay_price";
            this.lbl_overnight_stay_price.Size = new System.Drawing.Size(61, 25);
            this.lbl_overnight_stay_price.TabIndex = 63;
            this.lbl_overnight_stay_price.Text = "00.00";
            // 
            // lbl_waiting_hire_charge
            // 
            this.lbl_waiting_hire_charge.AutoSize = true;
            this.lbl_waiting_hire_charge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_waiting_hire_charge.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_waiting_hire_charge.Location = new System.Drawing.Point(1339, 241);
            this.lbl_waiting_hire_charge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_waiting_hire_charge.Name = "lbl_waiting_hire_charge";
            this.lbl_waiting_hire_charge.Size = new System.Drawing.Size(61, 25);
            this.lbl_waiting_hire_charge.TabIndex = 66;
            this.lbl_waiting_hire_charge.Text = "00.00";
            // 
            // lbl_extra_km_charge
            // 
            this.lbl_extra_km_charge.AutoSize = true;
            this.lbl_extra_km_charge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_extra_km_charge.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extra_km_charge.Location = new System.Drawing.Point(1340, 197);
            this.lbl_extra_km_charge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_extra_km_charge.Name = "lbl_extra_km_charge";
            this.lbl_extra_km_charge.Size = new System.Drawing.Size(61, 25);
            this.lbl_extra_km_charge.TabIndex = 65;
            this.lbl_extra_km_charge.Text = "00.00";
            // 
            // lbl_extra_driver_charge
            // 
            this.lbl_extra_driver_charge.AutoSize = true;
            this.lbl_extra_driver_charge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_extra_driver_charge.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extra_driver_charge.Location = new System.Drawing.Point(1339, 284);
            this.lbl_extra_driver_charge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_extra_driver_charge.Name = "lbl_extra_driver_charge";
            this.lbl_extra_driver_charge.Size = new System.Drawing.Size(61, 25);
            this.lbl_extra_driver_charge.TabIndex = 67;
            this.lbl_extra_driver_charge.Text = "00.00";
            // 
            // lbl_total_bill
            // 
            this.lbl_total_bill.AutoSize = true;
            this.lbl_total_bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_bill.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_bill.Location = new System.Drawing.Point(1336, 390);
            this.lbl_total_bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total_bill.Name = "lbl_total_bill";
            this.lbl_total_bill.Size = new System.Drawing.Size(75, 29);
            this.lbl_total_bill.TabIndex = 69;
            this.lbl_total_bill.Text = "00.00";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1072, 390);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(284, 29);
            this.label26.TabIndex = 68;
            this.label26.Text = "Total bill                        Rs.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbtn_hire);
            this.groupBox2.Controls.Add(this.rbtn_rent);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(185, 409);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(203, 50);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            // 
            // rbtn_hire
            // 
            this.rbtn_hire.AutoSize = true;
            this.rbtn_hire.Location = new System.Drawing.Point(104, 18);
            this.rbtn_hire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_hire.Name = "rbtn_hire";
            this.rbtn_hire.Size = new System.Drawing.Size(53, 20);
            this.rbtn_hire.TabIndex = 1;
            this.rbtn_hire.Text = "Hire";
            this.rbtn_hire.UseVisualStyleBackColor = true;
            // 
            // rbtn_rent
            // 
            this.rbtn_rent.AutoSize = true;
            this.rbtn_rent.Checked = true;
            this.rbtn_rent.Location = new System.Drawing.Point(9, 18);
            this.rbtn_rent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_rent.Name = "rbtn_rent";
            this.rbtn_rent.Size = new System.Drawing.Size(56, 20);
            this.rbtn_rent.TabIndex = 0;
            this.rbtn_rent.TabStop = true;
            this.rbtn_rent.Text = "Rent";
            this.rbtn_rent.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(16, 425);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(103, 25);
            this.label27.TabIndex = 70;
            this.label27.Text = "Rent/Hire";
            // 
            // txt_hours
            // 
            this.txt_hours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hours.Location = new System.Drawing.Point(729, 555);
            this.txt_hours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.Size = new System.Drawing.Size(121, 22);
            this.txt_hours.TabIndex = 73;
            // 
            // txt_end_km_read
            // 
            this.txt_end_km_read.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_end_km_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_end_km_read.Location = new System.Drawing.Point(444, 38);
            this.txt_end_km_read.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_end_km_read.Name = "txt_end_km_read";
            this.txt_end_km_read.Size = new System.Drawing.Size(121, 22);
            this.txt_end_km_read.TabIndex = 74;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(19, 34);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(138, 25);
            this.label28.TabIndex = 75;
            this.label28.Text = "Start Reading";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(308, 34);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(128, 25);
            this.label29.TabIndex = 76;
            this.label29.Text = "End Reading";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.txt_end_km_read);
            this.groupBox3.Controls.Add(this.txt_start_km_read);
            this.groupBox3.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(555, 453);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(583, 86);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "No. km";
            // 
            // dtpreturndate
            // 
            this.dtpreturndate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpreturndate.Location = new System.Drawing.Point(731, 300);
            this.dtpreturndate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpreturndate.Name = "dtpreturndate";
            this.dtpreturndate.Size = new System.Drawing.Size(212, 22);
            this.dtpreturndate.TabIndex = 78;
            // 
            // dtprentdate
            // 
            this.dtprentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtprentdate.Location = new System.Drawing.Point(732, 239);
            this.dtprentdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtprentdate.Name = "dtprentdate";
            this.dtprentdate.Size = new System.Drawing.Size(212, 22);
            this.dtprentdate.TabIndex = 79;
            // 
            // dtprenttime
            // 
            this.dtprenttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtprenttime.Location = new System.Drawing.Point(731, 122);
            this.dtprenttime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtprenttime.Name = "dtprenttime";
            this.dtprenttime.Size = new System.Drawing.Size(212, 22);
            this.dtprenttime.TabIndex = 80;
            // 
            // dtpreturntime
            // 
            this.dtpreturntime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpreturntime.Location = new System.Drawing.Point(731, 182);
            this.dtpreturntime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpreturntime.Name = "dtpreturntime";
            this.dtpreturntime.Size = new System.Drawing.Size(212, 22);
            this.dtpreturntime.TabIndex = 81;
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Tomato;
            this.btnfind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btnfind.Location = new System.Drawing.Point(392, 65);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(105, 37);
            this.btnfind.TabIndex = 82;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 364);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 84;
            this.label10.Text = "Vehicle no";
            // 
            // txt_vehicle_no
            // 
            this.txt_vehicle_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vehicle_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicle_no.Location = new System.Drawing.Point(185, 370);
            this.txt_vehicle_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_vehicle_no.Name = "txt_vehicle_no";
            this.txt_vehicle_no.Size = new System.Drawing.Size(208, 22);
            this.txt_vehicle_no.TabIndex = 83;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.GreenYellow;
            this.btncalculate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculate.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btncalculate.Location = new System.Drawing.Point(1077, 550);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(129, 37);
            this.btncalculate.TabIndex = 85;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbl_base_package_charge
            // 
            this.lbl_base_package_charge.AutoSize = true;
            this.lbl_base_package_charge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_base_package_charge.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_base_package_charge.Location = new System.Drawing.Point(1340, 126);
            this.lbl_base_package_charge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_base_package_charge.Name = "lbl_base_package_charge";
            this.lbl_base_package_charge.Size = new System.Drawing.Size(61, 25);
            this.lbl_base_package_charge.TabIndex = 87;
            this.lbl_base_package_charge.Text = "00.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1077, 123);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(257, 25);
            this.label20.TabIndex = 86;
            this.label20.Text = "Base package Charge     Rs.";
            // 
            // frm_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayubo_Drive_Management_System.Properties.Resources.Billbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1459, 602);
            this.Controls.Add(this.lbl_base_package_charge);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_vehicle_no);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.dtpreturntime);
            this.Controls.Add(this.dtprenttime);
            this.Controls.Add(this.dtprentdate);
            this.Controls.Add(this.dtpreturndate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_hours);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lbl_total_bill);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lbl_extra_driver_charge);
            this.Controls.Add(this.lbl_waiting_hire_charge);
            this.Controls.Add(this.lbl_extra_km_charge);
            this.Controls.Add(this.lbl_overnight_stay_price);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_package);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_vehicletype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_customerNIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_customerTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_driverID);
            this.Controls.Add(this.txt_customerID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.frm_bill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_driver_no;
        private System.Windows.Forms.RadioButton rbtn_driver_yes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_driverID;
        private System.Windows.Forms.TextBox txt_customerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_customerTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_customerNIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_vehicletype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_package;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_start_km_read;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_overnight_stay_price;
        private System.Windows.Forms.Label lbl_waiting_hire_charge;
        private System.Windows.Forms.Label lbl_extra_km_charge;
        private System.Windows.Forms.Label lbl_extra_driver_charge;
        private System.Windows.Forms.Label lbl_total_bill;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_hire;
        private System.Windows.Forms.RadioButton rbtn_rent;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_hours;
        private System.Windows.Forms.TextBox txt_end_km_read;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpreturndate;
        private System.Windows.Forms.DateTimePicker dtprentdate;
        private System.Windows.Forms.DateTimePicker dtprenttime;
        private System.Windows.Forms.DateTimePicker dtpreturntime;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_vehicle_no;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lbl_base_package_charge;
        private System.Windows.Forms.Label label20;
    }
}