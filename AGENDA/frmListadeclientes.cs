using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lista_telefonica;

namespace AGENDA
{
    public partial class frmListadeclientes : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public frmListadeclientes ()
        {
            InitializeComponent();
        }
      
        private void btnModelo_Click(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade();
            cidade.Nome = "Gabriel";
            cidade.Endereco = "EeEEAEAEAEAE";
            cidade.Telefone = "12154851545";


            Repositorio.Incluir(cidade);
            bsCidades.ResetBindings(false);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListadeclientes_Load_1(object sender, EventArgs e)
        {
            bsCidades.DataSource = Repositorio;
        }
    }
}
