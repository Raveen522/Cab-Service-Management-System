using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ayubo_Drive_Management_System
{
    public partial class frm_rent : Form
    {
        public frm_rent()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
            (@"Data Source=DESKTOP-GDEGPD0\SQLEXPRESS;Initial Catalog=Ayubo_Drive_DB;Integrated Security=True");
        string selected_vehicletype;

        private void Load_data()
        {

            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM rent";
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

        private void frmrent_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string insert_query = 
                    "INSERT INTO rent VALUES" +
                    "('" + txt_vehicleType.Text + "'," +
                    "" + float.Parse(txt_dailyrate.Text) + "," +
                    "" + float.Parse(txt_weeklyrate.Text) + "," +
                    "" + float.Parse(txt_monthlyrate.Text) + "," +
                    "" + float.Parse(txt_driverrate.Text) + ");";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rent Detials saved!");
                txt_dailyrate.Clear();
                txt_driverrate.Clear();
                txt_monthlyrate.Clear();
                txt_vehicleType.Clear();
                txt_weeklyrate.Clear();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_query = "DELETE FROM rent WHERE vehicle_type='" + selected_vehicletype + "' ;";
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
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selected_vehicletype = row.Cells[0].Value.ToString();
            }
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM rent WHERE  vehicle_type='" + selected_vehicletype + "' ";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_vehicleType.Text = dr[0].ToString();
                    txt_dailyrate.Text = dr[1].ToString();
                    txt_weeklyrate.Text = dr[2].ToString();
                    txt_monthlyrate.Text = dr[3].ToString();
                    txt_driverrate.Text = dr[4].ToString();
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
            txt_dailyrate.Clear();
            txt_driverrate.Clear();
            txt_monthlyrate.Clear();
            txt_vehicleType.Clear();
            txt_weeklyrate.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string insert_query = 
                    "UPDATE rent SET " +
                    "daily_rate=" + float.Parse(txt_dailyrate.Text) + "," +
                    "weekly_rate=" + float.Parse(txt_weeklyrate.Text) + "," +
                    "monthly_rate=" + float.Parse(txt_monthlyrate.Text) + "," +
                    "driver_rate=" + float.Parse(txt_driverrate.Text) + " " +
                    "WHERE vehicle_type='" + selected_vehicletype + "';";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rent Detials updated!");
                txt_dailyrate.Clear();
                txt_driverrate.Clear();
                txt_monthlyrate.Clear();
                txt_vehicleType.Clear();
                txt_weeklyrate.Clear();
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
    }
}
