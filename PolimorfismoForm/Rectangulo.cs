using Polimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PolimorfismoForm
{
    class Rectangulo : Figura
    {
        //Métodos
        public override string Dibujar()
        {
            return "Dibujar Rectangulo";  //return base.Dibujar();
            
        }
        //Nuevo color
        public override void EstablecerColor(Color otrocolor)
        {
            if (otrocolor == null)
            {
                base.EstablecerColor(Color.Black);
                Console.ReadKey();
            }
            else
                base.EstablecerColor(otrocolor);
           
        }
        //Regresamos el color
        public override Color ObtenerColor()
        {
            return base.ObtenerColor();
            
        }
        //Construimos un rectangulo
        public override Rectangle ObtenerFigura()
        {
            Rectangle contorno = new Rectangle();
            contorno.X = this.X;
            contorno.Y = this.Y;
            contorno.Width = this.Tamaño.Width;
            contorno.Height = this.Tamaño.Height;
            return contorno;
            
        }

        //Construimos el color de relleno
        public Pen ObtenerLapiz()
        {
            return new Pen(this.ObtenerColor());
            
        }

        //Construimos el color de relleno
        public Brush ObtenerPincel()
        {
            return new SolidBrush(this.ObtenerColor()); ;
            
        }
    }
}
