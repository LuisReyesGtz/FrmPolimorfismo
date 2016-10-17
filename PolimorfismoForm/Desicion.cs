using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolimorfismoForm
{
    public partial class FrmDecision : Form
    {

        public FrmDecision()
        {
            InitializeComponent();

        }

        private void FrmDecision_Load(object sender, EventArgs e)
        {
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            FrmCirculo C = new FrmCirculo();
            C.Show();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            FrmTriangulo T = new FrmTriangulo();
            T.Show();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            FrmRectangulo R = new FrmRectangulo();
            R.Show();
        }




    }
}