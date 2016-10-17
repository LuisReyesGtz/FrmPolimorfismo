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
    public partial class FrmTriangulo : Form
    {
        public FrmTriangulo()
        {
            InitializeComponent();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {

            //Creamos un grafico en todo el formulario
            Graphics grafico = CreateGraphics();
            //Creamos el colorear del pincel
            Brush pincel = Brushes.Black;

            //Instanciamos el objeto circunferencia
            Triangulo triangulo = new Triangulo() { alto = 100, ancho = 100, X = 0, Y = 0 };
            triangulo.EstablecerColor(Color.Blue);
            //int diametro = 100;
            //grafico.DrawLine(Pens.Purple, 2, diametro, diametro, 2);
            grafico.DrawPolygon(triangulo.ObtenerLapiz(), triangulo.DibujarTriangulo());
        }
    }
}
