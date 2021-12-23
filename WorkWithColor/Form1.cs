using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bitmap = SystemIcons.Hand.ToBitmap();
            //pictureBoxMain.Image = (Bitmap)bitmap.Clone();
        }
        string pic;
        Bitmap bitmap;
        Bitmap original;
        Color AdditColor;
        int red;
        int gr;
        int bl;


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
            openFileDialog1.ShowDialog();
            pic = openFileDialog1.FileName;
            bitmap = (Bitmap)Bitmap.FromFile(pic);
            original = (Bitmap)bitmap.Clone();
            pictureBoxMain.Image = bitmap;

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (buttonLeft.Focused)
            {
                pictureBoxMain.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBoxMain.Refresh();
            }
            if (buttonRight.Focused)
            {
                pictureBoxMain.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBoxMain.Refresh();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (buttonPlus.Focused)
            {
                pictureBoxMain.Width += 10;
            }
            if (buttonMinus.Focused)
            {
                if (pictureBoxMain.Width > 10)
                    pictureBoxMain.Width -= 10;
                //pictureBoxMain.Height -= 10;
            }

            //if (pictureBoxMain.Width > 10)
            //    pictureBoxMain.Width -= 10;
        }

        private void buttonVertical_Click(object sender, EventArgs e)
        {
            if (buttonHorizontal.Focused)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBoxMain.Refresh();
            }
            if (buttonVertical.Focused)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBoxMain.Refresh();
                
            }
        }

        private void Func1()
        {
            red = Int32.Parse(textBoxRed.Text);
            gr = Int32.Parse(textBoxGreen.Text);
            bl = Int32.Parse(textBoxBlue.Text);
            AdditColor = Color.FromArgb(255, red, gr, bl);
            try             //проверка наличия изображения 

            //Обработать каждый пиксель изображения 

            {
                if (pictureBoxDesirColor.BackColor == Color.Azure)
                {
                    for (int i = 0; i < pictureBoxMain.Image.Height - 1; i++)
                    {
                        for (int j = 0; j < pictureBoxMain.Image.Width - 1; j++)
                        {
                            //Получить цвет текущего пикселя
                            Color color = ((Bitmap)pictureBoxMain.Image).GetPixel(j, i);

                            //Проверить каждую составляющую цвета на попадание в диапазон с допуском 



                            if (color.R - trackBarAdmittance.Value / 2 <= pictureBoxOrigColor.BackColor.R

                                 && color.R + trackBarAdmittance.Value / 2 >= pictureBoxOrigColor.BackColor.R

                                 && color.G - trackBarAdmittance.Value / 2 <= pictureBoxOrigColor.BackColor.G

                                 && color.G + trackBarAdmittance.Value / 2 >= pictureBoxOrigColor.BackColor.G

                                 && color.B - trackBarAdmittance.Value / 2 <= pictureBoxOrigColor.BackColor.B

                                 && color.B + trackBarAdmittance.Value / 2 >= pictureBoxOrigColor.BackColor.B)

                            {
                                //Взять цвет для окрашивания 
                                Color color2 = pictureBoxOrigColor.BackColor;

                                int colorB = color.B - color2.B;
                                int colorG = color.G - color2.G;
                                int colorR = color.R - color2.R;

                                if (AdditColor.R + colorR < 0)
                                    colorR = AdditColor.R;
                                if (AdditColor.G + colorG < 0)
                                    colorG = AdditColor.G;
                                if (AdditColor.B + colorB < 0)
                                    colorB = AdditColor.B;
                                if (AdditColor.R + colorR > 255)
                                    colorR = 255 - AdditColor.R;
                                if (AdditColor.G + colorG > 255)
                                    colorG = 255 - AdditColor.G;
                                if (AdditColor.B + colorB > 255)
                                    colorB = 255 - AdditColor.B;

                                //Образовать новый цвет 

                                color2 = Color.FromArgb(255, AdditColor.R + colorR,
                                AdditColor.G + colorG,
                                AdditColor.B + colorB);

                                //Окрасить созданным цветом текущий пиксель 

                                ((Bitmap)pictureBoxMain.Image).SetPixel(j, i, color2);

                            }

                        }

                    }

                    pictureBoxMain.Refresh();
                }


                for (int i = 0; i < pictureBoxMain.Image.Height - 1; i++)
                {
                    for (int j = 0; j < pictureBoxMain.Image.Width - 1; j++)
                    {
                        //Получить цвет текущего пикселя
                        Color color = ((Bitmap)pictureBoxMain.Image).GetPixel(j, i);

                        //Проверить каждую составляющую цвета на попадание в диапазон с допуском 

                        

                        if (color.R - trackBarAdmittance.Value / 2 <= pictureBoxOrigColor.BackColor.R

                             && color.R + trackBarAdmittance.Value / 2 >= pictureBoxOrigColor.BackColor.R

                             && color.G - trackBarAdmittance.Value / 2 <= pictureBoxOrigColor.BackColor.G

                             && color.G + trackBarAdmittance.Value / 2 >= pictureBoxOrigColor.BackColor.G

                             && color.B - trackBarAdmittance.Value / 2 <= pictureBoxOrigColor.BackColor.B

                             && color.B + trackBarAdmittance.Value / 2 >= pictureBoxOrigColor.BackColor.B)

                        {
                        //Взять цвет для окрашивания 
                        Color color2 = pictureBoxOrigColor.BackColor;

                            int colorB = color.B - color2.B;
                            int colorG = color.G - color2.G;
                            int colorR = color.R - color2.R;

                            if (pictureBoxDesirColor.BackColor.R + colorR < 0)
                                colorR = pictureBoxDesirColor.BackColor.R;
                            if (pictureBoxDesirColor.BackColor.G + colorG < 0)
                                colorG = pictureBoxDesirColor.BackColor.G;
                            if (pictureBoxDesirColor.BackColor.B + colorB < 0)
                                colorB = pictureBoxDesirColor.BackColor.B;
                            if (pictureBoxDesirColor.BackColor.R + colorR > 255)
                                colorR = 255 - pictureBoxDesirColor.BackColor.R;
                            if (pictureBoxDesirColor.BackColor.G + colorG > 255)
                                colorG = 255 - pictureBoxDesirColor.BackColor.G;
                            if (pictureBoxDesirColor.BackColor.B + colorB > 255)
                                colorB = 255 - pictureBoxDesirColor.BackColor.B;

                            //Образовать новый цвет 

                            color2 = Color.FromArgb(255, pictureBoxDesirColor.BackColor.R + colorR,
                            pictureBoxDesirColor.BackColor.G + colorG,
                            pictureBoxDesirColor.BackColor.B + colorB);

                            //Окрасить созданным цветом текущий пиксель 

                            ((Bitmap)pictureBoxMain.Image).SetPixel(j, i, color2);

                        }

                    }

                }

                pictureBoxMain.Refresh();

            }

            catch

            {

                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Func1();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = null;
            bitmap.Dispose();

            textBoxSettingsColor1.Clear();
            textBoxSettingsColor2.Clear();
            pictureBoxOrigColor.BackColor = Color.Azure;
            pictureBoxDesirColor.BackColor = Color.Azure;
            textBoxRed.Clear();
            textBoxGreen.Clear();
            textBoxBlue.Clear();

            trackBarRed.Value = 0;
            trackBarGreen.Value = 0;
            trackBarBlue.Value = 0;
        }

        private void pictureBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxMain.DrawToBitmap(bitmap, pictureBoxMain.ClientRectangle);
            var color = bitmap.GetPixel(e.X, e.Y);
            var r = color.R;
            var g = color.G;
            var b = color.B;

            textBoxSettingsColor1.Text = Convert.ToString("Red: " + r + " Green: " + g + " Blue: " + b);

            trackBarRed.Value = r;
            trackBarGreen.Value = g;
            trackBarBlue.Value = b;
            pictureBoxOrigColor.BackColor = color;
            textBoxRed.Text = Convert.ToString(r);
            textBoxGreen.Text = Convert.ToString(g);
            textBoxBlue.Text = Convert.ToString(b);
        }

        private void pictureBoxDesirColor_Click(object sender, EventArgs e)
        {
            ColorDialog clrdlg = new ColorDialog();
            if (clrdlg.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBoxDesirColor.BackColor = clrdlg.Color;

            int x = pictureBoxDesirColor.Width / 2;
            int y = pictureBoxDesirColor.Height / 2;

            var bmp = new Bitmap(pictureBoxDesirColor.Width, pictureBoxDesirColor.Height);
            var colordlg = bmp.GetPixel(x, y);

            var r = colordlg.R;
            var g = colordlg.G;
            var b = colordlg.B;
            textBoxSettingsColor2.Text = Convert.ToString("Red: " + r + " Green: " + g + " Blue: " + b);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null) 
            {
                saveFileDialog1.Title = "Save as...";
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.BMP)|*.BMP|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    try
                    {
                        pictureBoxMain.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Unable to save image!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = original;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = trackBarRed.Value.ToString();
            textBoxGreen.Text = trackBarGreen.Value.ToString();
            textBoxBlue.Text = trackBarBlue.Value.ToString();
        }
    }
}
