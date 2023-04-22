using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo_Drive_Management_System
{
    public partial class frm_customers : Form
    {
        public frm_customers()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
            (@"Data Source=DESKTOP-GDEGPD0\SQLEXPRESS;Initial Catalog=Ayubo_Drive_DB;Integrated Security=True");
        string hire_or_rent;
        int with_driver;

        private void frmcustomers_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Close();
                string select_query = "SELECT MAX(customer_ID) FROM customer;";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_customerID.Text = Convert.ToString(Convert.ToInt32(dr[0].ToString()) + 1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (rbtn_hire.Checked == true)
            {
                hire_or_rent = "hire";
                txt_rentID.Text = "0";
            }
            else
            {
                hire_or_rent = "rent";
                txt_hireID.Text = "0";
            }
            if (rbtn_driver_yes.Checked == true)
            {
                with_driver = 1;

            }
            else
            {
                with_driver = 0;
                txt_driverID.Text = "0";
            }
            try
            {
                string insert_query = 
                    "INSERT INTO customer VALUES" +
                    "(" + Convert.ToInt32(txt_customerID.Text) + "," +
                    "'" + txt_customerName.Text + "'," +
                    "" + Convert.ToInt32(txt_hireID.Text) + "," +
                    "" + Convert.ToInt32(txt_rentID.Text) + "," +
                    "'" + txt_customerAddress.Text + "'," +
                    "'" + txt_customerTP.Text + "'," +
                    "'" + cmbpackage.Text + "'," +
                    "'" + txt_vehicleNo.Text + "'," +
                    "" + with_driver + "," +
                    "'" + Convert.ToInt32(txt_driverID.Text) + "'," +
                    "'" + hire_or_rent + "','" + dtprentdate.Value + "'," +
                    "'" + txt_vehicle_type.Text + "','" + txt_customerNIC.Text + "');";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer saved!");
                txt_customerAddress.Clear();
                txt_customerName.Clear();
                txt_customerNIC.Clear();
                txt_customerTP.Clear();
                txt_driverID.Clear();
                txt_hireID.Clear();
                txt_rentID.Clear();
                txt_vehicleNo.Clear();
                txt_vehicle_type.Clear();
                txt_customerNIC.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void rbtn_hire_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_hire.Checked == true)
            {
                cmbpackage.Enabled = true;
                txt_hireID.Enabled = true;
                txt_rentID.Enabled = false;
            }
            else
            {
                cmbpackage.Enabled = false;
                txt_hireID.Enabled = false;
                txt_rentID.Enabled = true;
            }
        }

        private void rbtn_driver_no_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_driver_no.Checked == true)
            {
                txt_driverID.Enabled = false;
            }
            else
            {
                txt_driverID.Enabled = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            txt_customerAddress.Clear();
            txt_customerName.Clear();
            txt_customerNIC.Clear();
            txt_customerTP.Clear();
            txt_driverID.Clear();
            txt_hireID.Clear();
            txt_rentID.Clear();
            txt_vehicleNo.Clear();
            txt_vehicle_type.Clear();
            txt_customerNIC.Clear();
        }
    }
}
