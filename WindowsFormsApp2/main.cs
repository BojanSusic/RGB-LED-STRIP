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
    public partial class main : Form
    {
        
        private Image image = Image.FromFile("SLike/slider.png");
        public int otvorena=0;
        public static string[] nazivi = new string[20];
        public Point tackaR=new Point(100,0);
        public Point tackaG = new Point(100, 0);
        public Point tackaB = new Point(100, 0);
        private int x=1;
        public main()
        {
            InitializeComponent();

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {

            //OTVARA FORMU ZA UNOS I DISABLE-UJE TRENUTNU FORMU 
            //A NAKON STO SE FORMA ZA UNOS ZATVOR IPET JE ENABLE-UJE
            save sav = new save();
            sav.ShowInTaskbar = false;
            this.Enabled = false;
         
            sav.StartPosition=FormStartPosition.Manual;
            sav.SetDesktopLocation(this.Left+190, this.Top+180);
            sav.BackColor = Color.FromArgb(tackaR.X, tackaG.X, tackaB.X);
            this.otvorena = sav.otvorena;
                sav.Show();

            
            if (sav.Created == false)
                this.Enabled = true;

            sav.FormClosed += (o, args) => { this.Enabled = true; };
            

        }

        bool dozvolaR = false;
        bool dozvolaG = false;
        bool dozvolaB = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dozvolaR = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dozvolaR) {
                x = tackaR.X;
                if(e.X>=0 && e.X<=255)
                tackaR.X = e.X;
            //    tacka.Y = e.Y;
                pictureBox1.Refresh();
            
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dozvolaR = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image,tackaR.X,tackaR.Y,7,15);
            promjenaBoje(tackaR.X,tackaG.X,tackaB.X);

        }
        

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, tackaG.X, tackaG.Y, 7, 15);
            promjenaBoje(tackaR.X, tackaG.X, tackaB.X);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            dozvolaG = true;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            dozvolaG = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dozvolaG)
            {
                x = tackaG.X;
                if (e.X >= 0 && e.X <= 255)
                    tackaG.X = e.X;
                //    tacka.Y = e.Y;
                pictureBox2.Refresh();

            }
        }
        
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            dozvolaB = true;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            dozvolaB = false;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dozvolaB)
            {
                x = tackaB.X;
                if (e.X >= 0 && e.X <= 255)
                    tackaB.X = MousePosition.X;
               
                pictureBox3.Refresh();

            }
        }

        private void pictureBox3_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, tackaB.X, tackaB.Y, 7, 15);
            promjenaBoje(tackaR.X, tackaG.X, tackaB.X); 
        }

        private void promjenaBoje(int R,int G, int B) {
            textBox1.Text= "#"+R.ToString("X")+G.ToString("X")+B.ToString("X");
            this.BackColor = Color.FromArgb(R, G, B);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap imp = new Bitmap(pictureBox5.Image);
            Color pixel = imp.GetPixel(e.X, e.Y);
            if (pixel.B == 23 || pixel.G==254)
                panel1.Hide();
            else if (pixel.B == 21 || pixel.G==255)
                panel1.Show();
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap imp = new Bitmap(pictureBox6.Image);
            Color pixel = imp.GetPixel(e.X, e.Y);
            if (pixel.R == 21 || pixel.B == 255)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (pixel.R == 20 || pixel.R == 255) {
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Icon = SystemIcons.Application;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;

            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal) {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
                Show();
            }
        }

        

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
               // notifyIcon1.ContextMenu;
            
            }
        }

        
        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left) {
              
                
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                //????
                
               
            }
                       
        }

       

        
    }
}
