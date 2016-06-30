using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contatosDBDataSet1.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contatosDBDataSet1.People);
            // TODO: This line of code loads data into the 'contatosDBDataSet1.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contatosDBDataSet1.People);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
