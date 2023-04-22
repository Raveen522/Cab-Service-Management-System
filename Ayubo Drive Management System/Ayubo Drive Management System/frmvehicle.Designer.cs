namespace Ayubo_Drive_Management_System
{
    partial class frm_vehicle
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_vehicleNo = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vehicleRegno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vehicletype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_vehiclemodel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ownerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_monthlyrate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_driver_no = new System.Windows.Forms.RadioButton();
            this.rbtn_driver_yes = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_driverID = new System.Windows.Forms.TextBox();
            this.dtprentdate = new System.Windows.Forms.DateTimePicker();
            this.dtpexpiredate = new System.Windows.Forms.DateTimePicker();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Vehicle No";
            // 
            // txt_vehicleNo
            // 
            this.txt_vehicleNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicleNo.Location = new System.Drawing.Point(159, 71);
            this.txt_vehicleNo.Name = "txt_vehicleNo";
            this.txt_vehicleNo.Size = new System.Drawing.Size(142, 17);
            this.txt_vehicleNo.TabIndex = 86;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btndelete.Location = new System.Drawing.Point(739, 507);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(79, 30);
            this.btndelete.TabIndex = 85;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Tomato;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btn_clear.Location = new System.Drawing.Point(654, 507);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(79, 30);
            this.btn_clear.TabIndex = 84;
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
            this.btn_save.Location = new System.Drawing.Point(562, 507);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 30);
            this.btn_save.TabIndex = 83;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Reg No";
            // 
            // txt_vehicleRegno
            // 
            this.txt_vehicleRegno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vehicleRegno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicleRegno.Location = new System.Drawing.Point(159, 127);
            this.txt_vehicleRegno.Name = "txt_vehicleRegno";
            this.txt_vehicleRegno.Size = new System.Drawing.Size(142, 17);
            this.txt_vehicleRegno.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Vehicle Type";
            // 
            // txt_vehicletype
            // 
            this.txt_vehicletype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vehicletype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicletype.Location = new System.Drawing.Point(159, 184);
            this.txt_vehicletype.Name = "txt_vehicletype";
            this.txt_vehicletype.Size = new System.Drawing.Size(179, 17);
            this.txt_vehicletype.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Vehicle model";
            // 
            // txt_vehiclemodel
            // 
            this.txt_vehiclemodel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vehiclemodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehiclemodel.Location = new System.Drawing.Point(159, 241);
            this.txt_vehiclemodel.Name = "txt_vehiclemodel";
            this.txt_vehiclemodel.Size = new System.Drawing.Size(179, 17);
            this.txt_vehiclemodel.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Owner ID";
            // 
            // txt_ownerID
            // 
            this.txt_ownerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ownerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownerID.Location = new System.Drawing.Point(159, 296);
            this.txt_ownerID.Name = "txt_ownerID";
            this.txt_ownerID.Size = new System.Drawing.Size(179, 17);
            this.txt_ownerID.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Rented Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 99;
            this.label7.Text = "Rent expire date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 101;
            this.label8.Text = "Monthly rate";
            // 
            // txt_monthlyrate
            // 
            this.txt_monthlyrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_monthlyrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monthlyrate.Location = new System.Drawing.Point(572, 187);
            this.txt_monthlyrate.Name = "txt_monthlyrate";
            this.txt_monthlyrate.Size = new System.Drawing.Size(179, 17);
            this.txt_monthlyrate.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtn_driver_no);
            this.groupBox1.Controls.Add(this.rbtn_driver_yes);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(894, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 41);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_driver_no
            // 
            this.rbtn_driver_no.AutoSize = true;
            this.rbtn_driver_no.Location = new System.Drawing.Point(54, 16);
            this.rbtn_driver_no.Name = "rbtn_driver_no";
            this.rbtn_driver_no.Size = new System.Drawing.Size(39, 17);
            this.rbtn_driver_no.TabIndex = 1;
            this.rbtn_driver_no.Text = "No";
            this.rbtn_driver_no.UseVisualStyleBackColor = true;
            this.rbtn_driver_no.CheckedChanged += new System.EventHandler(this.rbtn_driver_no_CheckedChanged);
            // 
            // rbtn_driver_yes
            // 
            this.rbtn_driver_yes.AutoSize = true;
            this.rbtn_driver_yes.Checked = true;
            this.rbtn_driver_yes.Location = new System.Drawing.Point(9, 16);
            this.rbtn_driver_yes.Name = "rbtn_driver_yes";
            this.rbtn_driver_yes.Size = new System.Drawing.Size(43, 17);
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
            this.label13.Location = new System.Drawing.Point(794, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 102;
            this.label13.Text = "With Driver?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(794, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 105;
            this.label9.Text = "Driver ID";
            // 
            // txt_driverID
            // 
            this.txt_driverID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_driverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverID.Location = new System.Drawing.Point(896, 118);
            this.txt_driverID.Name = "txt_driverID";
            this.txt_driverID.Size = new System.Drawing.Size(179, 17);
            this.txt_driverID.TabIndex = 104;
            // 
            // dtprentdate
            // 
            this.dtprentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtprentdate.Location = new System.Drawing.Point(570, 71);
            this.dtprentdate.Name = "dtprentdate";
            this.dtprentdate.Size = new System.Drawing.Size(181, 20);
            this.dtprentdate.TabIndex = 106;
            // 
            // dtpexpiredate
            // 
            this.dtpexpiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpexpiredate.Location = new System.Drawing.Point(571, 129);
            this.dtpexpiredate.Name = "dtpexpiredate";
            this.dtpexpiredate.Size = new System.Drawing.Size(181, 20);
            this.dtpexpiredate.TabIndex = 107;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btnupdate.Location = new System.Drawing.Point(470, 507);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(86, 30);
            this.btnupdate.TabIndex = 126;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(432, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 210);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // frmvehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayubo_Drive_Management_System.Properties.Resources.Vehiclebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1109, 559);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dtpexpiredate);
            this.Controls.Add(this.dtprentdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_driverID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_monthlyrate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ownerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_vehiclemodel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_vehicletype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vehicleRegno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_vehicleNo);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmvehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.frmvehicle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_vehicleNo;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vehicleRegno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vehicletype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_vehiclemodel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ownerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_monthlyrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_driver_no;
        private System.Windows.Forms.RadioButton rbtn_driver_yes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_driverID;
        private System.Windows.Forms.DateTimePicker dtprentdate;
        private System.Windows.Forms.DateTimePicker dtpexpiredate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}