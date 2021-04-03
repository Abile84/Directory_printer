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

namespace Directory_printer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length<=0)
            {
                MessageBox.Show("seleziona una cartella!!");
                    return;

            }

            string[] path = Directory.GetFiles(textBox1.Text, comboBox1.SelectedItem.ToString(), SearchOption.AllDirectories);
            File.WriteAllLines("list.txt", path);
            MessageBox.Show("Finito!!");
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text= "Seleziona un tipo di file da cercare";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Stampa su file di testo l'elenco dei file.";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Seleziona una cartella..";
        }

        private void comboBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
           // toolStripStatusLabel1.Text = "Hai selezionato"+ comboBox1.SelectedItem+ " file.";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hai selezionato " + comboBox1.SelectedItem.ToString().Replace("*.","") + " files.";
        }
    }
}
