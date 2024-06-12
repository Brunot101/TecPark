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
            
            Precos precos = new Precos();
            precos.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
