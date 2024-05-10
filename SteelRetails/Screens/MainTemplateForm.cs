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
    public partial class MainTemplateForm : Form
    {
        public Point MouseLocation;
        public bool IsUpdate { get; set; }
        public string Company { get; set; } = "ABC Company";
        public string Address1 { get; set; } = "123 Lane";
        public string Address2 { get; set; } = "Iron Area, CityName";
        public string Phone { get; set; } = "021-1234567";
        public string Email { get; set; } = "abc@xyz.com";
        public MainTemplateForm()
        {
            InitializeComponent();
            
        }

        private void MainTemplateForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
