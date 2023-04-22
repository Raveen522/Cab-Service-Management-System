namespace Ayubo_Drive_Management_System
{
    partial class frm_packages
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
            this.txt_packageID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_packageName = new System.Windows.Forms.TextBox();
            this.txt_extra_km_rate = new System.Windows.Forms.TextBox();
            this.txt_max_hour_limit = new System.Windows.Forms.TextBox();
            this.txt_max_km_limit = new System.Windows.Forms.TextBox();
            this.txt_packagePrice = new System.Windows.Forms.TextBox();
            this.txt_vehicleType = new System.Windows.Forms.TextBox();
            this.txt_overnight_driver_rate = new System.Windows.Forms.TextBox();
            this.txt_overnight_vehicle_rate = new System.Windows.Forms.TextBox();
            this.txt_extra_hour_rate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_packageID
            // 
            this.txt_packageID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_packageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_packageID.Location = new System.Drawing.Point(158, 71);
            this.txt_packageID.Name = "txt_packageID";
            this.txt_packageID.Size = new System.Drawing.Size(143, 17);
            this.txt_packageID.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Package ID";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Tomato;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btn_clear.Location = new System.Drawing.Point(669, 508);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(79, 30);
            this.btn_clear.TabIndex = 44;
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
            this.btn_save.Location = new System.Drawing.Point(577, 508);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 30);
            this.btn_save.TabIndex = 43;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_packageName
            // 
            this.txt_packageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_packageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_packageName.Location = new System.Drawing.Point(158, 126);
            this.txt_packageName.Name = "txt_packageName";
            this.txt_packageName.Size = new System.Drawing.Size(180, 17);
            this.txt_packageName.TabIndex = 47;
            // 
            // txt_extra_km_rate
            // 
            this.txt_extra_km_rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_extra_km_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_extra_km_rate.Location = new System.Drawing.Point(624, 72);
            this.txt_extra_km_rate.Name = "txt_extra_km_rate";
            this.txt_extra_km_rate.Size = new System.Drawing.Size(180, 17);
            this.txt_extra_km_rate.TabIndex = 48;
            // 
            // txt_max_hour_limit
            // 
            this.txt_max_hour_limit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_max_hour_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_max_hour_limit.Location = new System.Drawing.Point(158, 350);
            this.txt_max_hour_limit.Name = "txt_max_hour_limit";
            this.txt_max_hour_limit.Size = new System.Drawing.Size(180, 17);
            this.txt_max_hour_limit.TabIndex = 49;
            // 
            // txt_max_km_limit
            // 
            this.txt_max_km_limit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_max_km_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_max_km_limit.Location = new System.Drawing.Point(158, 293);
            this.txt_max_km_limit.Name = "txt_max_km_limit";
            this.txt_max_km_limit.Size = new System.Drawing.Size(180, 17);
            this.txt_max_km_limit.TabIndex = 50;
            // 
            // txt_packagePrice
            // 
            this.txt_packagePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_packagePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_packagePrice.Location = new System.Drawing.Point(158, 238);
            this.txt_packagePrice.Name = "txt_packagePrice";
            this.txt_packagePrice.Size = new System.Drawing.Size(180, 17);
            this.txt_packagePrice.TabIndex = 51;
            // 
            // txt_vehicleType
            // 
            this.txt_vehicleType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicleType.Location = new System.Drawing.Point(158, 184);
            this.txt_vehicleType.Name = "txt_vehicleType";
            this.txt_vehicleType.Size = new System.Drawing.Size(180, 17);
            this.txt_vehicleType.TabIndex = 52;
            // 
            // txt_overnight_driver_rate
            // 
            this.txt_overnight_driver_rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_overnight_driver_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overnight_driver_rate.Location = new System.Drawing.Point(624, 242);
            this.txt_overnight_driver_rate.Name = "txt_overnight_driver_rate";
            this.txt_overnight_driver_rate.Size = new System.Drawing.Size(180, 17);
            this.txt_overnight_driver_rate.TabIndex = 54;
            // 
            // txt_overnight_vehicle_rate
            // 
            this.txt_overnight_vehicle_rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_overnight_vehicle_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overnight_vehicle_rate.Location = new System.Drawing.Point(624, 185);
            this.txt_overnight_vehicle_rate.Name = "txt_overnight_vehicle_rate";
            this.txt_overnight_vehicle_rate.Size = new System.Drawing.Size(180, 17);
            this.txt_overnight_vehicle_rate.TabIndex = 55;
            // 
            // txt_extra_hour_rate
            // 
            this.txt_extra_hour_rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_extra_hour_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_extra_hour_rate.Location = new System.Drawing.Point(624, 130);
            this.txt_extra_hour_rate.Name = "txt_extra_hour_rate";
            this.txt_extra_hour_rate.Size = new System.Drawing.Size(180, 17);
            this.txt_extra_hour_rate.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Package Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Vehicle Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Package Price Rs.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Extra Hour Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Extra km Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Max Hour Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Max Km Limit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 66;
            this.label10.Text = "Overnight Driver Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(446, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Overnight Vehicle Rate";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btndelete.Location = new System.Drawing.Point(754, 508);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(79, 30);
            this.btndelete.TabIndex = 69;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 160);
            this.dataGridView1.TabIndex = 70;

            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Ubuntu", 12.75F);
            this.btnupdate.Location = new System.Drawing.Point(485, 508);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(86, 30);
            this.btnupdate.TabIndex = 71;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // frmpackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayubo_Drive_Management_System.Properties.Resources.Hirebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1098, 557);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_extra_hour_rate);
            this.Controls.Add(this.txt_overnight_vehicle_rate);
            this.Controls.Add(this.txt_overnight_driver_rate);
            this.Controls.Add(this.txt_vehicleType);
            this.Controls.Add(this.txt_packagePrice);
            this.Controls.Add(this.txt_max_km_limit);
            this.Controls.Add(this.txt_max_hour_limit);
            this.Controls.Add(this.txt_extra_km_rate);
            this.Controls.Add(this.txt_packageName);
            this.Controls.Add(this.txt_packageID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmpackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmpackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_packageID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_packageName;
        private System.Windows.Forms.TextBox txt_extra_km_rate;
        private System.Windows.Forms.TextBox txt_max_hour_limit;
        private System.Windows.Forms.TextBox txt_max_km_limit;
        private System.Windows.Forms.TextBox txt_packagePrice;
        private System.Windows.Forms.TextBox txt_vehicleType;
        private System.Windows.Forms.TextBox txt_overnight_driver_rate;
        private System.Windows.Forms.TextBox txt_overnight_vehicle_rate;
        private System.Windows.Forms.TextBox txt_extra_hour_rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnupdate;
    }
}