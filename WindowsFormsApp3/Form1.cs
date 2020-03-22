using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog OpenDlg = new OpenFileDialog();
        SaveFileDialog SaveDlg = new SaveFileDialog();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ctrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация о приложении и разработчике");
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveDlg.ShowDialog()==DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
           

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
