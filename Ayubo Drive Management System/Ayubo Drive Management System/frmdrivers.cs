using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo_Drive_Management_System
{
    public partial class frm_drivers : Form
    {
        public frm_drivers()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
            (@"Data Source=DESKTOP-GDEGPD0\SQLEXPRESS;Initial Catalog=Ayubo_Drive_DB;Integrated Security=True");
        int selected_driver;

        private void Load_data()
        {
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM driver";
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
        private void max_id()
        {
            try
            {
                conn.Close();
                string select_query = "SELECT MAX(driver_ID) FROM driver;";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_driverID.Text = Convert.ToString(Convert.ToInt32(dr[0].ToString()) + 1);
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

        private void clear_texts()
        {
            txt_driverrate.Clear();
            txt_driverAddress.Clear();
            txt_driverAge.Clear();
            txt_driverName.Clear();
            txt_driverName.Clear();
            txt_driverNIC.Clear();
            txt_driverTP.Clear();
        }

        private void frmdrivers_Load(object sender, EventArgs e)
        {
            Load_data();
            max_id();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_texts();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                string insert_query = "INSERT INTO driver " +
                    "VALUES(" + Convert.ToInt32(txt_driverID.Text) + "," +
                    "'" + txt_driverName.Text + "'," + float.Parse(txt_driverrate.Text) + "," +
                    "'" + dtpjoineddate.Value + "'," + Convert.ToInt32(txt_driverAge.Text) + "," +
                    "'" + txt_driverAddress.Text + "','" + txt_driverTP.Text + "'," +
                    "'" + txt_driverNIC.Text + "',0,1);";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Driver Detials saved!");
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
                max_id();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string insert_query = "UPDATE driver SET " +
                    "driver_name='" + txt_driverName.Text + "'," +
                    "driver_rate='" + float.Parse(txt_driverrate.Text) + "'," +
                    "joined_date='" + dtpjoineddate.Value + "'," +
                    "driver_age=" + Convert.ToInt32(txt_driverAge.Text) + "," +
                    "driver_address='" + txt_driverAddress.Text + "'," +
                    "driver_TP='" + txt_driverTP.Text + "'," +
                    "driver_NIC='" + txt_driverNIC.Text + "'  " +
                    "WHERE driver_ID=" + Convert.ToInt32(txt_driverID.Text) + ";";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Driver Detials updated!");

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
                max_id();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selected_driver = Convert.ToInt32(row.Cells[0].Value);
            }
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM driver WHERE  driver_ID=" + selected_driver + " ";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_driverID.Text = dr[0].ToString();
                    txt_driverName.Text = dr[1].ToString();
                    txt_driverrate.Text = dr[2].ToString();
                    dtpjoineddate.Value = Convert.ToDateTime(dr[3].ToString());
                    txt_driverAge.Text = dr[4].ToString();
                    txt_driverAddress.Text = dr[5].ToString();
                    txt_driverTP.Text = dr[6].ToString();
                    txt_driverNIC.Text = dr[7].ToString();

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_query = "DELETE FROM driver WHERE driver_ID=" + selected_driver + " ;";
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
                max_id();
            }
        }
    }
}
