using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_08_WindowsForm_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBoxKategori.Enabled = false;
            //textBoxStok.Enabled = false;
            //textBoxUrunAdi.Enabled = false;
            //textBoxYazar.Enabled = false;
            //richTextBoxAciklama.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboboxDoldurV1();                         //write the names of books
            pictureBoxResim.BackColor = Color.DarkRed;  //set the initial color
        }

        private void comboboxDoldurV1()
        {
            foreach (Urun item in DataBase.sanalDatabase)
            {
                comboBoxUrunListe.Items.Add(item.urunAdi); 
            }
        }

        private void comboBoxUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox= (ComboBox)sender;
            Urun urun = DataBase.sanalDatabase[comboBox.SelectedIndex];
            
            textBoxUrunAdi.Text = urun.urunAdi;
            textBoxYazar.Text = urun.yazar;
            textBoxKategori.Text = urun.kategori;
            textBoxStok.Text = urun.stokAdet.ToString();
            richTextBoxAciklama.Text = urun.aciklama;
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            path = path.Remove(path.Length - 9, 9); 
            /*
             * with this codes, taking the current path of images 
             */

            path = path + "images" + urun.urunResim;
            pictureBoxResim.Image = Image.FromFile(path);
            pictureBoxResim.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }
    }
}
