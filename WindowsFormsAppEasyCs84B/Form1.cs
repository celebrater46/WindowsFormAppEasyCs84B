using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs84B
{
    public partial class Form1 : Form
    {
        private Image im;
        private int i;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Fade in a picture";
            this.Width = 400;
            this.Height = 300;
            
            im = Image.FromFile("C:Z\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs84B\\WindowsFormsAppEasyCs84B\\img\\sample.jpg");
            i = 0;
            Timer tm = new Timer();
            tm.Start();

            tm.Tick += new EventHandler(TmTick);
            this.Paint += new PaintEventHandler(FmPaint);
        }

        public void TmTick(Object sender, EventArgs e)
        {
            if (i > im.Width + 200)
            {
                i = 0;
            }
            else
            {
                i += 10;
            }
            this.Invalidate();
        }

        public void FmPaint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(im, new Rectangle(0, 0, i, im.Height), 0, 0, i, im.Height, GraphicsUnit.Pixel);
        }
    }
}