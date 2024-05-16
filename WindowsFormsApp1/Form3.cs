using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\claudiu\\Desktop\\Facultate\\An3\\II\\Tema2\\WindowsFormsApp1\\Database1.mdf;Integrated Security=True";
        public WebService1 web = new WebService1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Comenzi' table. You can move, or remove it, as needed.
            this.comenziTableAdapter.Fill(this.database1DataSet.Comenzi);
            // TODO: This line of code loads data into the 'database1DataSet.Magazie' table. You can move, or remove it, as needed.
            this.magazieTableAdapter.Fill(this.database1DataSet.Magazie);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = web.updateMagazie("Magazie");
            dataGridView2.DataSource = web.updateMagazie("Comenzi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            int intValue;
            if (int.TryParse(textBox2.Text, out intValue))
            {
                MessageBox.Show(web.plaseazaComanda(nume, intValue));
            }
            else
            {
                MessageBox.Show("Introduceti cantitatea!");
            }
        }
    }
}
