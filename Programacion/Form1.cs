using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName + ".txt", richTextBox1.Text);
                MessageBox.Show("Archivo guardado");
            }
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            openFileDialog1.Title = "Escoje el archivo";
            openFileDialog1.Filter = "Textos |  *.txt";
            if (openFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {                
                    richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);                
            }
        }

        
    }
}
