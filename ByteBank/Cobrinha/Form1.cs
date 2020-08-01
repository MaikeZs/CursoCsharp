using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Cobrinha
{
    public partial class formulario : Form
    {
        private SoundPlayer Som = new SoundPlayer(@"C:\Estudo\CursoCsharp\ByteBank\Cobrinha\sons\ai-pai-para.wav");
        private const string pra_cima = "Up";
        private const string para_baixo = "Down";
        private const string para_direita = "Right";
        private const string para_esquerda = "Left";
        private int PassoHorizontal = 0;
        public int PassoVertical = 30;
        public int Horizontal { get; set; }
        public int Vertical { get; set; }


        public formulario()
        {
            this.AutoSize = false;
            InitializeComponent();
        }

        private void Andar()
        {
            Point point = new Point(Horizontal, Vertical);
            boll.Location = point;
            Console.WriteLine(Size.Width);
            Console.WriteLine(point);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bateu())
            {
                Som.Play();
                timer1.Enabled = false;
            }
            Horizontal += PassoHorizontal;
            Vertical += PassoVertical;

            
            Andar();

        }

        private bool bateu()
        {
            return bateuEncima()
                || bateuEmbaixo()
                || bateuParedeDireita()
                || bateuParedeEsquerda();
        }

        private bool bateuParedeEsquerda()
        {
            return (PassoHorizontal < 0 && boll.Location.X <= 0);
        }

        private bool bateuParedeDireita()
        {
            return (PassoHorizontal > 0 && boll.Location.X >= (Size.Width - boll.Size.Width));
        }

        private bool bateuEncima()
        {
            return (PassoVertical < 0 && boll.Location.Y <= 0);
        }

        private bool bateuEmbaixo()
        {
            return (PassoVertical > 0 && boll.Location.Y >= (Size.Height - boll.Size.Height));
        }

        private bool vertical()
        {
            return PassoHorizontal == 0;
        }

        private bool horizontal()
        {
            return PassoVertical == 0;
        }

        private void formulario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue) 
            {
                case 38://pra cima
                    virar(0,-30);
                    break;
                case 40:// pra baixa
                    virar(0,30);
                    break;
                case 37://esquerda
                    virar(-30,0);
                    break;
                case 39://direita
                    virar(30,0);
                    break;

            }
        }
        private void virar(int X,int Y) 
        {
            PassoHorizontal = X;
            PassoVertical = Y;
        }
    }
}
