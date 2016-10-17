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
using ConsoleApplication2;

namespace PolimorfismoForm
{
    public partial class FrmCirculo : Form
    {
        public FrmCirculo()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Creamos un grafico en todo el formulario
            Graphics grafico = CreateGraphics();
            //Creamos el color del pincel
            Brush pincel = Brushes.Black;

            //Instanciamos el objeto circunferencia
            Circulo circunferencia = new Circulo()
            {
                alto = 100,
                ancho = 100,
                X = 0, Y = 0
            };
            circunferencia.EstablecerColor(Color.Green);
            //Rellenamos la circunferencia con: (pincel, X, Y, alto, ancho)    grafico.FillEllipse(circunferencia.ObtenerPincel(), circunferencia.ObtenerFigura());
            //Dibujamos una circunferencia de contorno
            grafico.DrawEllipse(Pens.Red, circunferencia.ObtenerFigura());
        }
    }
}
