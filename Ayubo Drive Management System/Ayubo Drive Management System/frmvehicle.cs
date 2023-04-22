using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ayubo_Drive_Management_System
{
    public partial class frm_vehicle : Form
    {
        public frm_vehicle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
            (@"Data Source=DESKTOP-GDEGPD0\SQLEXPRESS;Initial Catalog=Ayubo_Drive_DB;Integrated Security=True");
        string selected_vehicle;
        int with_driver;
        private void Load_data()
        {

            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM vehicle";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
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

        private void clear_texts()
        {
            txt_driverID.Clear();
            txt_monthlyrate.Clear();
            txt_ownerID.Clear();
            txt_vehiclemodel.Clear();
            txt_vehicleNo.Clear();
            txt_vehicleRegno.Clear();
            txt_vehicletype.Clear();
        }
        private void frmvehicle_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selected_vehicle = Convert.ToString(row.Cells[0].Value);
            }
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM vehicle WHERE  vehicle_no='" + selected_vehicle + "' ";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_vehicleNo.Text = dr[0].ToString();
                    txt_vehicleRegno.Text = dr[1].ToString();
                    txt_vehicletype.Text = dr[2].ToString();
                    txt_vehiclemodel.Text = dr[3].ToString();
                    dtprentdate.Value = Convert.ToDateTime(dr[4].ToString());
                    dtpexpiredate.Value = Convert.ToDateTime(dr[5].ToString());
                    txt_monthlyrate.Text = dr[6].ToString();
                    with_driver = Convert.ToInt32(dr[7]);
                    txt_driverID.Text = dr[8].ToString();
                    txt_ownerID.Text = dr[9].ToString();
                }
                if (with_driver == 1)
                {
                    rbtn_driver_yes.Checked = true;
                    rbtn_driver_no.Checked = false;
                }
                else
                {
                    rbtn_driver_yes.Checked = false;
                    rbtn_driver_no.Checked = true;
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_texts();
            Load_data();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_query = "DELETE FROM vehicle WHERE vehicle_no=" + selected_vehicle + " ;";
                SqlCommand cmd = new SqlCommand(delete_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                Load_data();
                clear_texts();

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
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
                string insert_query = "INSERT INTO vehicle VALUES" +
                    "('" + txt_vehicleNo.Text + "'," +
                    "'" + txt_vehicleRegno.Text + "'," +
                    "'" + txt_vehicletype.Text + "'," +
                    "'" + txt_vehiclemodel.Text + "'," +
                    "'" + dtprentdate.Value + "'," +
                    "'" + dtpexpiredate.Value + "'," +
                    "" + float.Parse(txt_monthlyrate.Text) + "," +
                    "" + with_driver + "," +
                    "" + Convert.ToInt32(txt_driverID.Text) + "," +
                    "" + Convert.ToInt32(txt_ownerID.Text) + ");";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle detials saved!");
                clear_texts();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                Load_data();

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (rbtn_driver_yes.Checked == true)
            {
                with_driver = 1;
            }
            else
            {
                with_driver = 0;
            }

            try
            {
                string insert_query = "UPDATE vehicle SET " +
                    "reg_no='" + txt_vehicleRegno.Text + "'," +
                    "vehicle_type='" + txt_vehicletype.Text + "'," +
                    "vehicle_model='" + txt_vehiclemodel.Text + "'," +
                    "rented_date='" + dtprentdate.Value + "'," +
                    "rent_expire_date='" + dtpexpiredate.Value + "'," +
                    "monthly_rent=" + float.Parse(txt_monthlyrate.Text) + "," +
                    "with_driver=" + with_driver + "," +
                    "driver_ID=" + Convert.ToInt32(txt_driverID.Text) + "," +
                    "owner_ID=" + Convert.ToInt32(txt_ownerID.Text) + " " +
                    "WHERE vehicle_no='" + txt_vehicleNo.Text + "';";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle detials updated!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                clear_texts();
                Load_data();
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
    }
}
