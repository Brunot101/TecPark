using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecParkk
{
    public partial class Precos : Form

    {
        public float preco15min = 0;
        public float preco30min = 0;
        public float preco45min = 0;
        public float preco60min = 0;

        public Precos()
        {
           
            InitializeComponent();
            tx_preco15min_precos.Text = this.preco15min.ToString();
            tx_preco30min_precos.Text = this.preco30min.ToString();
            tx_preco45min_precos.Text = this.preco45min.ToString();
            tx_preco60min_precos.Text = this.preco60min.ToString();


        }

        void bt_salvar_Click(object sender, EventArgs e)
        {
            this.preco15min= float.Parse(tx_preco15min_precos.Text);
            this.preco30min = float.Parse(tx_preco30min_precos.Text);
            this.preco45min = float.Parse(tx_preco45min_precos.Text);
            this.preco60min = float.Parse(tx_preco60min_precos.Text);
            float teste = this.preco15min + this.preco30min;
            MessageBox.Show("Preços registrados com sucesso!");
            this.Close();
            Controle controle = new Controle(this);
            controle.ShowDialog();

        }
    }   
}
