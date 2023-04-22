namespace Ayubo_Drive_Management_System
{
    partial class frm_vehicle_supliers
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
            this.txt_owner_ID = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_driver_no = new System.Windows.Forms.RadioButton();
            this.rbtn_driver_yes = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ownerNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ownerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_owner_TP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_owneraddress = new System.Windows.Forms.TextBox();
            this.txt_driverID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Owner ID";
            // 
            // txt_owner_ID
            // 
            this.txt_owner_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_owner_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_owner_ID.Location = new System.Drawing.Point(159, 71);
            this.txt_owner_ID.Name = "txt_owner_ID";
            this.txt_owner_ID.Size = new System.Drawing.Size(142, 17);
            this.txt_owner_ID.TabIndex = 86;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btndelete.Location = new System.Drawing.Point(734, 493);
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
            this.btn_clear.Location = new System.Drawing.Point(649, 493);
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
            this.btn_save.Location = new System.Drawing.Point(557, 493);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 30);
            this.btn_save.TabIndex = 83;
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
            this.groupBox1.Location = new System.Drawing.Point(622, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 41);
            this.groupBox1.TabIndex = 105;
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
            this.label13.Location = new System.Drawing.Point(507, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 104;
            this.label13.Text = "With Driver?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Owner NIC";
            // 
            // txt_ownerNIC
            // 
            this.txt_ownerNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ownerNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownerNIC.Location = new System.Drawing.Point(159, 127);
            this.txt_ownerNIC.Name = "txt_ownerNIC";
            this.txt_ownerNIC.Size = new System.Drawing.Size(180, 17);
            this.txt_ownerNIC.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 109;
            this.label2.Text = "Owner Name";
            // 
            // txt_ownerName
            // 
            this.txt_ownerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ownerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownerName.Location = new System.Drawing.Point(159, 183);
            this.txt_ownerName.Name = "txt_ownerName";
            this.txt_ownerName.Size = new System.Drawing.Size(180, 17);
            this.txt_ownerName.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Telephone";
            // 
            // txt_owner_TP
            // 
            this.txt_owner_TP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_owner_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_owner_TP.Location = new System.Drawing.Point(159, 237);
            this.txt_owner_TP.Name = "txt_owner_TP";
            this.txt_owner_TP.Size = new System.Drawing.Size(180, 17);
            this.txt_owner_TP.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 123;
            this.label10.Text = "Address";
            // 
            // txt_owneraddress
            // 
            this.txt_owneraddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_owneraddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_owneraddress.Location = new System.Drawing.Point(159, 286);
            this.txt_owneraddress.Multiline = true;
            this.txt_owneraddress.Name = "txt_owneraddress";
            this.txt_owneraddress.Size = new System.Drawing.Size(180, 80);
            this.txt_owneraddress.TabIndex = 122;
            // 
            // txt_driverID
            // 
            this.txt_driverID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_driverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverID.Location = new System.Drawing.Point(626, 129);
            this.txt_driverID.Name = "txt_driverID";
            this.txt_driverID.Size = new System.Drawing.Size(142, 17);
            this.txt_driverID.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(507, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 121;
            this.label9.Text = "Driver ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 220);
            this.dataGridView1.TabIndex = 124;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btnupdate.Location = new System.Drawing.Point(465, 493);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(86, 30);
            this.btnupdate.TabIndex = 125;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // frmvehicle_supliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayubo_Drive_Management_System.Properties.Resources.VehicleSupliersbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1004, 556);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_owneraddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_driverID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_owner_TP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ownerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ownerNIC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_owner_ID);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmvehicle_supliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Supliers";
            this.Load += new System.EventHandler(this.frmvehicle_supliers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_owner_ID;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_driver_no;
        private System.Windows.Forms.RadioButton rbtn_driver_yes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ownerNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ownerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_owner_TP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_owneraddress;
        private System.Windows.Forms.TextBox txt_driverID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnupdate;
    }
}