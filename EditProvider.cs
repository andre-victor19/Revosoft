using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditProvider : Form
    {
        private int idProvider { get; set; }
        private string companyName { get; set; }
        public EditProvider()
        {
            InitializeComponent();
        }

        public EditProvider(string idProvider, string companyName)
        {
            InitializeComponent();
            this.companyName = companyName;
            this.idProvider = Convert.ToInt32(idProvider);
        }

        private void EditProvider_Load(object sender, EventArgs e)
        {
            this.Text = companyName;
        }
    }
}
