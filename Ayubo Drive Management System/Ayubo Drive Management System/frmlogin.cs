using System;
using System.Windows.Forms;

namespace Ayubo_Drive_Management_System
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="admin" && txtpw.Text == "raveen123")
            {
                frmmain frmmain = new frmmain();
                frmmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
