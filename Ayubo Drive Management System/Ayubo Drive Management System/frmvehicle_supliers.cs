using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ayubo_Drive_Management_System
{
    public partial class frm_vehicle_supliers : Form
    {
        public frm_vehicle_supliers()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
            (@"Data Source=DESKTOP-GDEGPD0\SQLEXPRESS;Initial Catalog=Ayubo_Drive_DB;Integrated Security=True");
        int with_driver;
        int selected_owner;
        private void Load_data()
        {
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM vehicle_owner";
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
                string select_query = "SELECT MAX(owner_ID) FROM vehicle_owner;";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_owner_ID.Text = Convert.ToString(Convert.ToInt32(dr[0].ToString()) + 1);
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
            txt_driverID.Clear();
            txt_owneraddress.Clear();
            txt_ownerName.Clear();
            txt_ownerNIC.Clear();
            txt_owner_ID.Clear();
            txt_owner_TP.Clear();
        }


        private void frmvehicle_supliers_Load(object sender, EventArgs e)
        {
            max_id();
            Load_data();
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
                string insert_query = "INSERT INTO vehicle_owner VALUES" +
                    "(" + Convert.ToInt32(txt_owner_ID.Text) + "," +
                    "'" + txt_ownerNIC.Text + "'," +
                    "'" + txt_ownerName.Text + "'," +
                    "'" + txt_owneraddress.Text + "'," +
                    "'" + txt_owner_TP.Text + "'," +
                    "" + Convert.ToInt32(txt_driverID.Text) + ");";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle owner Detials saved!");
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_query = "DELETE FROM vehicle_owner WHERE owner_ID=" + selected_owner + " ;";
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selected_owner = Convert.ToInt32(row.Cells[0].Value);
            }
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM vehicle_owner WHERE  owner_ID=" + selected_owner + " ";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_owner_ID.Text = dr[0].ToString();
                    txt_ownerNIC.Text = dr[1].ToString();
                    txt_ownerName.Text = dr[2].ToString();
                    txt_owneraddress.Text = dr[3].ToString();
                    txt_owner_TP.Text = dr[4].ToString();
                    txt_driverID.Text = dr[5].ToString();
                    if (dr[5] != null)
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string insert_query = "UPDATE vehicle_owner SET " +
                    "owner_NIC='" + txt_ownerNIC.Text + "'," +
                    "owner_name='" + txt_ownerName.Text + "'," +
                    "address='" + txt_owneraddress.Text + "'," +
                    "telephone='" + txt_owner_TP.Text + "'," +
                    "driver_ID=" + Convert.ToInt32(txt_driverID.Text) + "  " +
                    "WHERE owner_ID=" + Convert.ToInt32(txt_owner_ID.Text) + ";";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("vehicle owner detials updated!");

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
