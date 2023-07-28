using System.Security.Cryptography.X509Certificates;

namespace Aula15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuario=new Usuario("admin","admin");
            Cliente cliente=new Cliente("Admin",0,usuario);
            Program.clientes.Add(cliente);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario=txtLoginUsuario.Text;
            string senha=txtSenhaUsuario.Text;

           

            for (int i = 0; i < Program.clientes.Count; i++)
            {
                if (Program.clientes[i].usuario.usuario == usuario && Program.clientes[i].usuario.senha==senha )
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
              
        }
        
    }
}