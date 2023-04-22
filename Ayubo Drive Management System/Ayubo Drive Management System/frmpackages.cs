using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ayubo_Drive_Management_System
{
    public partial class frm_packages : Form
    {
        public frm_packages()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
            (@"Data Source=DESKTOP-GDEGPD0\SQLEXPRESS;Initial Catalog=Ayubo_Drive_DB;Integrated Security=True");
        int selected_package;
        private void Load_data()
        {
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM hire_package";
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
                string select_query = "SELECT MAX(package_ID) FROM hire_package;";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_packageID.Text = Convert.ToString(Convert.ToInt32(dr[0].ToString()) + 1);
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
            txt_extra_hour_rate.Clear();
            txt_extra_km_rate.Clear();
            txt_max_hour_limit.Clear();
            txt_max_km_limit.Clear();
            txt_overnight_driver_rate.Clear();
            txt_overnight_vehicle_rate.Clear();
            txt_packageName.Clear();
            txt_packagePrice.Clear();
            txt_vehicleType.Clear();
        }
        private void frmpackages_Load(object sender, EventArgs e)
        {
            max_id();
            Load_data();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string insert_query = "INSERT INTO hire_package VALUES" +
                    "(" + Convert.ToInt32(txt_packageID.Text) + "," +
                    "'" + txt_packageName.Text + "'," +
                    "'" + txt_vehicleType.Text + "'," +
                    "" + float.Parse(txt_packagePrice.Text) + "," +
                    "" + float.Parse(txt_max_km_limit.Text) + "," +
                    "" + Convert.ToInt32(txt_max_hour_limit.Text) + "," +
                    "" + float.Parse(txt_extra_km_rate.Text) + "," +
                    "" + float.Parse(txt_extra_hour_rate.Text) + "," +
                    "" + float.Parse(txt_overnight_vehicle_rate.Text) + "," +
                    "" + float.Parse(txt_overnight_driver_rate.Text) + ");";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package Detials saved!");
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_texts();
            Load_data();
            max_id();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selected_package = Convert.ToInt32(row.Cells[0].Value);
            }
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM hire_package WHERE  package_ID=" + selected_package + " ";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_packageID.Text = dr[0].ToString();
                    txt_packageName.Text = dr[1].ToString();
                    txt_vehicleType.Text = dr[2].ToString();
                    txt_packagePrice.Text = dr[3].ToString();
                    txt_max_km_limit.Text = dr[4].ToString();
                    txt_max_hour_limit.Text = dr[5].ToString();
                    txt_extra_km_rate.Text = dr[6].ToString();
                    txt_extra_hour_rate.Text = dr[7].ToString();
                    txt_overnight_vehicle_rate.Text = dr[8].ToString();
                    txt_overnight_driver_rate.Text = dr[9].ToString();
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
                string delete_query = "DELETE FROM hire_package WHERE package_ID=" + selected_package + " ;";
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string insert_query = "UPDATE hire_package SET " +
                    "package_name='" + txt_packageName.Text + "'," +
                    "vehicle_type='" + txt_vehicleType.Text + "'," +
                    "package_price=" + float.Parse(txt_packagePrice.Text) + "," +
                    "max_km_limit=" + float.Parse(txt_max_km_limit.Text) + "," +
                    "max_hour_limit=" + Convert.ToInt32(txt_max_hour_limit.Text) + "," +
                    "extra_km_rate=" + float.Parse(txt_extra_km_rate.Text) + "," +
                    "extra_hour_rate=" + float.Parse(txt_extra_hour_rate.Text) + "," +
                    "overnight_vehicle_rate=" + float.Parse(txt_overnight_vehicle_rate.Text) + "," +
                    "overnight_driver_rate=" + float.Parse(txt_overnight_driver_rate.Text) + " " +
                    "WHERE package_ID=" + Convert.ToInt32(txt_packageID.Text) + ";";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package Detials updated!");

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
    }
}
