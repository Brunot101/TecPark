namespace TecParkk
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cadastro = new Cadastrar();
            cadastro.ShowDialog();
        }

        private void bt_fuga_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
