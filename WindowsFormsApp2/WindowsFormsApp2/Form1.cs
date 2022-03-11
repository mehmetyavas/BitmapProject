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


    public partial class Form1 : Form
    {
        public int mouseX;
        public int mouseY;
        
            PictureBox pictureBox;
        public Form1()
        {
            InitializeComponent();

        }

      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            //Kare

            
                Graphics g = e.Graphics;
                Pen mypen = new Pen(Color.Black);
                Brush myBrush = new SolidBrush(Color.Red);
                g.DrawLine(mypen, 0, 0, 600, 0);
                g.DrawLine(mypen, 0, 0, 0, 600);
                g.DrawLine(mypen, 0, 600, 600, 600);
                g.DrawLine(mypen, 600, 0, 600, 600);

                

                mypen = new Pen(Color.Red);
                g.DrawLine(mypen, mouseX, mouseY, 0, 0);
                mypen = new Pen(Color.Blue);
                g.DrawLine(mypen, mouseX, mouseY, 600, 0);
                mypen = new Pen(Color.Green);
                g.DrawLine(mypen, mouseX, mouseY, 0, 600);
                mypen = new Pen(Color.Orange);
                g.DrawLine(mypen, mouseX, mouseY, 600, 600);
                //SOl Dik
                mypen = new Pen(Color.Black);
                g.DrawLine(mypen, mouseX, mouseY, 0, mouseY);
                //Üst Dik
                g.DrawLine(mypen, mouseX, mouseY, mouseX, 0);
                //Sağ Dik
                g.DrawLine(mypen, mouseX, mouseY, 600, mouseY);
                //alt Dik
                g.DrawLine(mypen, mouseX, mouseY, mouseX, 600);
            lblRedX.Text = "RedX=" + mouseX + "cm";
            lblRedY.Text = "RedY=" + mouseY + "cm";
            lblRedUzaklik.Text = "Sol üst uzaklık=" + Convert.ToInt16(Math.Sqrt(mouseX * mouseY)) + "cm";


            lblBlueX.Text = "BlueX=" + mouseX + "cm";
            lblBlueY.Text = "BlueY=" + mouseY + "cm";
            lblBlueUzaklik.Text = "Sağ Üst uzaklık=" + Convert.ToInt16(Math.Sqrt(mouseX * mouseY)) + "cm";

            lblOrangeX.Text = "OrangeX=" + mouseX + "cm";
            lblOrangeY.Text = "OrangeY=" + mouseY + "cm";
            lblOrangeUzaklik.Text = "Sağ Alt uzaklık=" + Convert.ToInt16(Math.Sqrt(mouseX * mouseY)) + "cm";

            lblGreenX.Text = "GreenX=" + mouseX + "cm";
            lblGreenY.Text = "GreenY=" + mouseY + "cm";
            lblGreenUzaklik.Text = "Sol Alt uzaklık=" + Convert.ToInt16(Math.Sqrt(mouseX * mouseY)) + "cm";
           



            //TODO
            // blue,green ,orange uzaklık ve lokasyonunu değiştir cbums

        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            mouseX = e.X;
              mouseY = e.Y; 

            lblMX.Text = "MouseX =" + mouseX;
            lblMY.Text = "MouseY =" + mouseY;
            Invalidate();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {

                pictureBox = new PictureBox();
                pictureBox.Name = "pictureBox1";
                pictureBox.Size = new Size(3, 3);
                pictureBox.Location = new Point(Convert.ToInt16(txtBoxPointX.Text), Convert.ToInt16(txtBoxPointX.Text));
                pictureBox.BackColor = Color.Red;
                this.Controls.Add(pictureBox);
            }
            catch (Exception)
            {
                MessageBox.Show("x ve y değerini doğru girin.");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            pictureBox = new PictureBox();
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new Size(3, 3);
            pictureBox.Location = new Point(mouseX, mouseY);
            pictureBox.BackColor = Color.Red;
            this.Controls.Add(pictureBox);
        }
    }
}
