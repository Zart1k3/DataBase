using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Услуги : Form
    {
        public Услуги()
        {
            InitializeComponent();
        }

        private void usl_Click(object sender, EventArgs e)
        {
            Товары pp = new Товары();
            pp.Show();
            this.Hide();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            Клиенты aa = new Клиенты();
            aa.Show();
            this.Hide();
        }
    }
}
