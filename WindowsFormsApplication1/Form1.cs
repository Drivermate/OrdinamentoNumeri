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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        SqlConnection con;

        public Form1()
        {
            
            InitializeComponent();
          
            //
            // In a using statement, acquire the SqlConnection as a resource.
            //
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\studente\\Documents\\visual studio 2015\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database1.mdf\";Integrated Security=True;");
            con.Open();
        }

        private void button_fine_Click(object sender, EventArgs e)
        {
            con.Close();
            Close();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            SqlCommand myCommand = new SqlCommand("INSERT INTO Anagrafica (Id, cognome, nome) " +
                                     "Values (1, 'Braccini', 'Gianluca')", con);

            myCommand.ExecuteNonQuery();

        }

        private void button_read_Click(object sender, EventArgs e)
        {
           try
          {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from Anagrafica",
                                                         con);
                myReader = myCommand.ExecuteReader();
                
                DataTable dt = new DataTable();
                dt.Load(myReader);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
               
            }
            catch (System.IO.IOException errore)
            {
               Console.WriteLine(errore.ToString());
            }
        }
    }
}
