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
            listValoriArray.DataSource = Vector.getInstance().getArray();
        }
        /*
         - Aldo, devi fare le funzioni di lettura scrittura da file e il vettore que usi è Vector.getInstance().getArray()
         - manca anche la funzione di evento del buttone di Aggiunta, basta usare Vector.getInstance().addOrd(numero) e hai fatto
         - Ti chiedevo di fare la relazione perche il cavi non puo e nemmeno io :( ma qualsiasi cosa chiamami
         */






    }
}
