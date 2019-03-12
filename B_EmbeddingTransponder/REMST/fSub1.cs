using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMST
{
    public partial class fSub1 : Form
    {

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F back_brown.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F back_grey.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F back_pink.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F back_purple.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F back_red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F back_yellow.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F balloon.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F bomb.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F ControlBox.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F eyes.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F gun.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F ignored.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F lake.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F mine.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F places_A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F places_B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F places_C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F places_D.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F recharging.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F shoot1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F shoot2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F sliders_blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F sliders_red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F volcanoes_o.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F volcanoes_x.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                case 12:
                    _pic2 = picture12;
                    break;
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                case 16:
                    _pic2 = picture16;
                    break;
                case 17:
                    _pic2 = picture17;
                    break;
                case 18:
                    _pic2 = picture18;
                    break;
                case 19:
                    _pic2 = picture19;
                    break;
                case 20:
                    _pic2 = picture20;
                    break;
                case 21:
                    _pic2 = picture21;
                    break;
                case 22:
                    _pic2 = picture22;
                    break;
                case 23:
                    _pic2 = picture23;
                    break;
                case 24:
                    _pic2 = picture24;
                    break;
                case 25:
                    _pic2 = picture25;
                    break;
                case 26:
                    _pic2 = picture26;
                    break;
                default:
                    _pic2 = picture27;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void FSub1_Load(object sender, EventArgs e)
        {

        }
    }
}
