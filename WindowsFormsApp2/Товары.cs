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
    public partial class Товары : Form
    {
        public Товары()
        {
            InitializeComponent();
        }

        private void usl_Click(object sender, EventArgs e)
        {
            Услуги pp = new Услуги();
            pp.Show();
            this.Hide();
        }
    }
}
