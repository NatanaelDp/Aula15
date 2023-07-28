using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            atualizaInterface();
        }
        void atualizaInterface()
        {
            listView1.Clear();
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                listView1.Items.Add(Program.clientes[i].nome);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string usuarioCadastro=txtUsuario .Text;
            string senha=txtSenha .Text;
            string nome=txtNomeCompleto.Text;
            int idade=2023-int.Parse(txtAnoNascimento.Text);

            Usuario usuario = new Usuario(usuarioCadastro,senha);
            Cliente cliente = new Cliente(nome,idade,usuario);
            Program.clientes.Add(cliente);
            atualizaInterface();
        }
    }
}
