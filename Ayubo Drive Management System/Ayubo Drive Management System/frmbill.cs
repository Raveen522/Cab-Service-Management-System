using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Ayubo_Drive_Management_System
{
    public partial class frm_bill : Form
    {
        public frm_bill()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
            (@"Data Source=DESKTOP-GDEGPD0\SQLEXPRESS;Initial Catalog=Ayubo_Drive_DB;Integrated Security=True");
        float rent_driver_rate;
        float package_price;
        float extra_hour_rate;
        float extra_km_rate;
        float overnight_vehivle_rate;
        float overnight_driver_rate;
        float daily_rate;
        float weekly_rate;
        float monthly_rate;
        int max_km_limit;
        int max_hour_limit;
        bool with_driver;
        bool rent;
        string rent_or_hire;

        private void data_from_rent()
        {
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM rent WHERE vehicle_type='" + txt_vehicletype.Text + "'";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    daily_rate = float.Parse(dr[1].ToString());
                    weekly_rate = float.Parse(dr[2].ToString());
                    monthly_rate = float.Parse(dr[3].ToString());
                    rent_driver_rate = float.Parse(dr[4].ToString());
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
        private void data_from_package()
        {
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM hire_package " +
                    "WHERE package_name='" + txt_package.Text + "' AND vehicle_type='" + txt_vehicletype.Text + "'";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    package_price = float.Parse(dr[3].ToString());
                    max_km_limit = Convert.ToInt32(dr[4].ToString());
                    max_hour_limit = Convert.ToInt32(dr[5].ToString());
                    extra_km_rate = Convert.ToInt32(dr[6].ToString());
                    extra_hour_rate = Convert.ToInt32(dr[7].ToString());
                    overnight_vehivle_rate = Convert.ToInt32(dr[8].ToString());
                    overnight_driver_rate = Convert.ToInt32(dr[9].ToString());

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

        private void rent_calculation()
        {
            float total_rent_value;

            int no_of_days;
            int no_of_weeks;
            int no_of_months;

            no_of_days = Convert.ToInt32((dtpreturndate.Value - dtprentdate.Value).TotalDays);
            no_of_months = no_of_days / 30;
            no_of_weeks = (no_of_days % 30) / 7;
            no_of_days = (no_of_days % 30) % 7;

            if (with_driver == true)
            {
                total_rent_value = no_of_months * monthly_rate + 
                    no_of_weeks * weekly_rate + no_of_days * daily_rate + rent_driver_rate * no_of_days;
            }
            else
            {
                total_rent_value = no_of_months * monthly_rate + no_of_weeks * weekly_rate + no_of_days * daily_rate;

            }

            lbl_total_bill.Text = total_rent_value.ToString();
        }

        private void day_tour_calculation()
        {
            float total_hire_value;
            float basic_hire_charge;
            float waiting_hire_charge = 0;
            float extra_km_charge = 0;

            int no_of_extra_km;
            int no_of_extra_hours;

            no_of_extra_km = (Convert.ToInt32(txt_end_km_read.Text) - Convert.ToInt32(txt_start_km_read.Text)) -
                max_km_limit;
            no_of_extra_hours = Convert.ToInt32(txt_hours.Text) - max_hour_limit;

            if (no_of_extra_km > 0)
            {
                extra_km_charge = no_of_extra_km * extra_km_rate;
            }
            if (no_of_extra_hours > 0)
            {
                waiting_hire_charge = no_of_extra_hours * extra_hour_rate;
            }
            basic_hire_charge = float.Parse(txt_package.Text);

            total_hire_value = basic_hire_charge + waiting_hire_charge + extra_km_charge;

            lbl_base_package_charge.Text = basic_hire_charge.ToString();
            lbl_waiting_hire_charge.Text = waiting_hire_charge.ToString();
            lbl_extra_km_charge.Text = extra_km_charge.ToString();
            lbl_total_bill.Text = total_hire_value.ToString();
        }

        private void long_tour_calculation()
        {
            float total_hire_value;
            float basic_hire_charge;
            float overnight_stay_charge;
            float extra_km_charge = 0;
            int no_of_long_tour_days = Convert.ToInt32((dtpreturndate.Value - dtprentdate.Value).TotalDays); ;
            int no_of_extra_km;

            no_of_extra_km = (Convert.ToInt32(txt_end_km_read.Text) - Convert.ToInt32(txt_start_km_read.Text)) - 
                max_km_limit;
            overnight_stay_charge = no_of_long_tour_days * (overnight_driver_rate + overnight_vehivle_rate);

            if (no_of_extra_km > 0)
            {
                extra_km_charge = no_of_extra_km * extra_km_rate;
            }

            basic_hire_charge = package_price;
            total_hire_value = basic_hire_charge + overnight_stay_charge + extra_km_charge;

            lbl_base_package_charge.Text = basic_hire_charge.ToString();
            lbl_overnight_stay_price.Text = overnight_stay_charge.ToString();
            lbl_extra_km_charge.Text = extra_km_charge.ToString();
            lbl_total_bill.Text = total_hire_value.ToString();
            ;
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string select_query = "SELECT * FROM customer WHERE" +
                    " customer_ID=" + Convert.ToInt32(txt_customerID.Text) + " ";
                SqlCommand cmd = new SqlCommand(select_query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_customerName.Text = dr[0].ToString();
                    txt_customerTP.Text = dr[1].ToString();
                    txt_customerNIC.Text = dr[13].ToString();
                    txt_vehicletype.Text = dr[12].ToString();

                    txt_package.Text = dr[6].ToString();
                    dtprentdate.Value = Convert.ToDateTime(dr[11].ToString());

                    txt_driverID.Text = dr[9].ToString();

                    txt_vehicle_no.Text = dr[7].ToString();


                    if (Convert.ToInt32(dr[8]) != 0)
                    {
                        rbtn_driver_yes.Checked = true;
                        rbtn_driver_no.Checked = false;
                        txt_driverID.Enabled = true;
                        with_driver = true;
                    }
                    else
                    {
                        rbtn_driver_yes.Checked = false;
                        rbtn_driver_no.Checked = true;
                        txt_driverID.Enabled = false;
                        with_driver = false;
                        txt_driverID.Text = "0";
                    }

                    if (dr[10].ToString() == "hire")
                    {
                        rbtn_hire.Checked = true;
                        rbtn_rent.Checked = false;
                        txt_package.Enabled = true;
                        rent = false;
                        rent_or_hire = "hire";
                    }
                    else
                    {
                        rbtn_hire.Checked = false;
                        rbtn_rent.Checked = true;
                        txt_package.Enabled = false;
                        rent = true;
                        rent_or_hire = "rent";
                        txt_package.Text = "-";
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
            data_from_package();
            data_from_rent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (rent == true)
            {

                rent_calculation();
            }
            else
            {

                if (Convert.ToInt32((dtpreturndate.Value - dtprentdate.Value).TotalDays) > 2)
                {
                    long_tour_calculation();
                }
                else
                {
                    day_tour_calculation();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_end_km_read.Clear();
            txt_start_km_read.Clear();
            txt_hours.Clear();
            dtpreturndate.Value = DateTime.Today;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int INTwith_driver;

            if (with_driver == true)
            {
                INTwith_driver = 1;
            }
            else
            {
                INTwith_driver = 0;
            }
            try
            {
                string insert_query = "INSERT INTO bill VALUES" +
                    "(" + Convert.ToInt32(txt_customerID.Text) + "," +
                    "'" + txt_customerName.Text + "','" + txt_customerTP.Text + "'," +
                    "'" + txt_customerNIC.Text + "','" + txt_vehicletype.Text + "'," +
                    "'" + txt_vehicle_no.Text + "','" + rent_or_hire + "'," +
                    "'" + txt_package.Text + "','" + dtprentdate.Value + "'," +
                    "'" + dtpreturndate.Value + "'," + INTwith_driver + "," +
                    "" + Convert.ToInt32(txt_start_km_read.Text) + "," +
                    "" + Convert.ToInt32(txt_end_km_read.Text) + "," +
                    "" + Convert.ToInt32(txt_hours.Text) + "," +
                    "" + float.Parse(lbl_base_package_charge.Text) + "," +
                    "" + float.Parse(lbl_overnight_stay_price.Text) + "," +
                    "" + float.Parse(lbl_extra_km_charge.Text) + "," +
                    "" + float.Parse(lbl_waiting_hire_charge.Text) + "," +
                    "" + float.Parse(lbl_extra_driver_charge.Text) + "," + float.Parse(lbl_total_bill.Text) + ");";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill detials saved!");


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

        private void frm_bill_Load(object sender, EventArgs e)
        {

        }
    }
}
