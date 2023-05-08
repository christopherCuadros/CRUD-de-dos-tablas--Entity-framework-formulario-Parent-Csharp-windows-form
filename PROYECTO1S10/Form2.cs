using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1S10
{
    public partial class FrmSistema : Form
    {
        public FrmSistema()
        {
            InitializeComponent();
        }

        private void pasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas v = new FrmVentas();
            v.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor ven= new FrmVendedor();
            ven.Show();
        }
    }
}
