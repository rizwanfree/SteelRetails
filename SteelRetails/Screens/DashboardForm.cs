using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelRetails.Screens
{
    public partial class DashboardForm : MainTemplateForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            DialogResult dr = loginForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
