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

        public void SaveFile(string input)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog.FileName;
                File.WriteAllText(name, input);
            }
        }

        private void buttonImporta_Click(object sender, EventArgs e)
        {

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
                    catch (Exception a)
                    {

                    }

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
            listValoriArray.DataSource = Vector.getInstance().getArray();

        }
        /*
- Aldo, devi fare le funzioni di lettura scrittura da file e il vettore que usi è Vector.getInstance().getArray()
- manca anche la funzione di evento del buttone di Aggiunta, basta usare Vector.getInstance().addOrd(numero) e hai fatto
- Ti chiedevo di fare la relazione perche il cavi non puo e nemmeno io :( ma qualsiasi cosa chiamami
*/






    }
}
