using System.Drawing;
using System.Windows.Forms;

namespace gfxDemo
{
    public partial class Form1 : Form
    {
        //Instansiera en röd penna
        private Pen PenRed = new Pen(Color.Red, 1);

        //Instansiera en blå penna
        private Pen PenBlue = new Pen(Color.Blue, 2);

        //Instansiera en grön penna
        private Pen PenGreen = new Pen(Color.Green, 3);

        //Deklarera grafikhanteraren
        private Graphics gfx;

        public Form1()
        {
            InitializeComponent();
        }

        //Privat flagga för att se till att inte flera rundor
        //med grafik körs igång samtidigt
        private bool isDrawing = false;

        //Paint eventet triggar igång denna metod
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Kolla om flaggan är satt, annars börja rita
            if (!isDrawing)
            {
                //Sätt flaggan så att ritandet inte körs igång igen
                isDrawing = true;

                //Rensa formuläret för att bli av med resterna från den tidigare bilden
                this.Refresh();

                //Hämta in grafikdelen från formuläret
                gfx = this.CreateGraphics();

                //Ta reda på storleken på fönstret
                int w = this.Width;
                int h = this.Height;

                //Sätt ett värde för avståndet mellan strecken
                float m = 1.5f;

                //Rulla igång loopen
                for (int i = 0; i < 200; i += 5)
                {
                    //Använd den blåa pennan för att rita ut en linje
                    gfx.DrawLine(PenBlue, 10 + i, 10 + i, w - i, h - i);

                    //Rita en linje till, skapa en coolare effekt
                    gfx.DrawLine(PenGreen, 10 + i * m, 10 + i * m, w - i * m, h - i * m);
                }

                //När loopen är klar, nollställ flaggan så att metoden kan //antopas igen
                isDrawing = false;
            }
        }
    }
}