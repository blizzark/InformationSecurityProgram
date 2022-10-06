using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurityProgram
{
    public partial class Form1 : Form
    {
        public static int size = 0;
        public static int sizefin = 0;
        public static int tmp = 0;
        public static int wordss = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(7);
            comboBox1.Items.Add(8);
  
            comboBox2.Items.Add(1);
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(3);
            comboBox2.Items.Add(4);
            comboBox2.Items.Add(5);
            comboBox2.Items.Add(6);
            comboBox2.Items.Add(7);
            comboBox2.Items.Add(8);
            comboBox2.SelectedIndex = 0;

            textBoxIn.Multiline = true;
            textBoxIn.ScrollBars = ScrollBars.Both;

            textBoxOut.Multiline = true;
            textBoxOut.ScrollBars = ScrollBars.Both;
        }

        private void textBoxIn_TextChanged(object sender, EventArgs e)
        {
            var words = textBoxIn.Text;
            wordss = words.Length;
            label8.Text = string.Format("{0} / {1}", words.Length, sizefin);
            if(words.Length > sizefin)
            {
              
                label8.ForeColor = Color.Red;
            }
            if (words.Length <= sizefin)
            {

                label8.ForeColor = Color.Black;
            }
        }

        private void openIn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы png|*.png";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                beginButIn.Enabled = true;
                pathBoxIn.Text = OPF.FileName;

                using (var bmp = (Bitmap)Image.FromFile(pathBoxIn.Text))
                {
                    var bd = bmp.LockBits(
                        new Rectangle(0, 0, bmp.Width, bmp.Height),
                        ImageLockMode.ReadWrite,
                        bmp.PixelFormat
                        );
                    // Буфер с изображением (массив пикселей)
                    var rgb = new byte[bd.Stride * bd.Height];
                    tmp = rgb.Length;
                    size = rgb.Length / (9 - Convert.ToInt32(comboBox1.Text));
                    sizefin = size - 200;
                    textBoxIn.MaxLength = sizefin;
                    label8.Text = string.Format("0 / {0}", sizefin);

                    textBoxIn.Enabled = true;
                }

            }
        }

        private void beginButIn_Click(object sender, EventArgs e)
        {
            if (textBoxIn.Text != "")
            {
                Implementation.path = pathBoxIn.Text;
                Implementation.text = textBoxIn.Text;
                Implementation.bitsUsage = Convert.ToInt32(comboBox1.Text);

                MessageBox.Show("Необходимо выбрать место, куда сохранить полученную картинку", "Внимание!");
                SaveFileDialog OPF = new SaveFileDialog();
                OPF.Filter = "Файлы png|*.png";
                if (OPF.ShowDialog() == DialogResult.OK)
                {

                    Implementation.pathOut = OPF.FileName;
                    try
                    {
                        Implementation.Encode();
                        MessageBox.Show("Текст успешно записан в картинку!", "успех!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Внимание ошибка: " + ex.Message, "Ошибка!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Внимание ошибка: Заполните поле исходного текста!", "Ошибка!");
            }

           
        }

        private void textBoxOut_TextChanged(object sender, EventArgs e)
        {
            textBoxOut.SelectionStart = textBoxOut.Text.Length;
            textBoxOut.ScrollToCaret();
            textBoxOut.Refresh();
        }


        private void Help_Click(object sender, EventArgs e)
        {
           
        }

        private void Dev_Click_1(object sender, EventArgs e)
        {
           

        }

        private void openOut_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы png|*.png";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                beginOut.Enabled = true;
                pathBoxOut.Text = OPF.FileName;
            }
        }

        private void beginOut_Click(object sender, EventArgs e)
        {
            Implementation.path = pathBoxOut.Text;
            Implementation.bitsUsage = Convert.ToInt32(comboBox2.Text);
            try
            {
                textBoxOut.Text = Implementation.Dencode();
                MessageBox.Show("Текст успешно вытащен из картинки!", "успех!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание ошибка: " + ex.Message, "Ошибка!");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click_1(object sender, EventArgs e)
        {
            Help windows = new Help();
            windows.ShowDialog();
        }

        private void Dev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данную программу разработал студент 475 группы:\nОвчинников Роман Сергеевич", "Разработчик");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                groupBox1.Enabled = true;
                sizefin = tmp / (9 - Convert.ToInt32(comboBox1.Text));
                label8.Text = string.Format("{0} / {1}", wordss, sizefin);
                textBoxIn.MaxLength = sizefin;


                if (wordss > sizefin)
                {

                    label8.ForeColor = Color.Red;
                }
                if (wordss <= sizefin)
                {

                    label8.ForeColor = Color.Black;
                }

            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
