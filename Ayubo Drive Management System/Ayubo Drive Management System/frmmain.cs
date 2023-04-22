using System;
using System.Windows.Forms;
namespace Ayubo_Drive_Management_System
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmabout frmabout = new frmabout();
            frmabout.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            frm_customers frmcustomers = new frm_customers(); 
            frmcustomers.Show();
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            frm_rent frmrent = new frm_rent();    
            frmrent.Show();
        }

        private void btn_hire_Click(object sender, EventArgs e)
        {
            frm_packages frmhires = new frm_packages(); 
            frmhires.Show();    
        }
        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            frm_vehicle frmvehicle = new frm_vehicle();   
            frmvehicle.Show();
        }
        private void btn_drivers_Click(object sender, EventArgs e)
        {
            frm_drivers frmdrivers = new frm_drivers();   
            frmdrivers.Show();
        }
        private void btn_vehicle_supliers_Click(object sender, EventArgs e)
        {
            frm_vehicle_supliers frmvehicle_supliers = new frm_vehicle_supliers();    
            frmvehicle_supliers.Show(); 
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            frm_bill frmbill = new frm_bill();
            frmbill.Show();
        }
        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
