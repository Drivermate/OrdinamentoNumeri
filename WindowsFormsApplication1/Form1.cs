using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string OpenFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;
                }
            }
            return "0";
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog z = new OpenFileDialog();
            z.Filter = "Text Files (.txt)|*.txt";
            z.Title = "Open a file..";
            if (z.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader s = new System.IO.StreamReader(z.FileName);
                rtb.Text = s.ReadToEnd();
                s.Close();
            }*/

            int i = 0;

            String line;
            int num;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(OpenFile());

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    try
                    {
                        num = System.Convert.ToInt32(line);

                        Vector.getInstance().addOrd(num);

                        i++;
                        line = sr.ReadLine();
                    }
                    catch { }
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception a)
            {
                MessageBox.Show("Exception: " + a.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            //listValoriArray.DataSource = Vector.getInstance().getArray();
            rtb.Container= Vector.Equals().

        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files (.txt)|*.txt";
            svf.Title = "Save file..";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter a = new System.IO.StreamWriter(svf.FileName);
                a.Write(rtb.Text);
                a.Close();
            }
        }

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files (.txt)|*.txt";
            svf.Title = "Save file..";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter a = new System.IO.StreamWriter(svf.FileName);
                a.Write(rtb.Text);
                a.Close();
            }
        }
    }
}