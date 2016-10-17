using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolimorfismoForm;
namespace PolimorfismoForm
{
    public partial class FrmRectangulo : Form
    {
        public FrmRectangulo()
        {
            InitializeComponent();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            //Creamos un grafico en todo el formulario
            Graphics grafico = CreateGraphics();
            //Creamos el color del pincel
            Brush pincel = Brushes.Black;

            //Instanciamos el objeto circunferencia
            Rectangulo rect = new Rectangulo() {
                alto = 100, ancho = 100, X = 0, Y = 0 };
            rect.EstablecerColor(Color.Gray);
            //grafico.DrawRectangle (pincel, X, Y, alto, ancho)
            grafico.DrawRectangle(rect.ObtenerLapiz(), rect.ObtenerFigura());
        }
    }
}
