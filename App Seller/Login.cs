using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Seller
{
    public partial class Login : Form
    {

        private Form1 _form1;
        public Login(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnLogar_Click(object sender, EventArgs e)
        {
            LoginRequest request = new LoginRequest();
            string result = await request.LoginR("C", "D", "B");

            MessageBox.Show(result);
        }
    }
}
