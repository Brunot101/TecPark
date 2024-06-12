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
    public partial class Resumo : Form
    {
        Cliente cliente;
        private float total;
        public Resumo(Cliente cliente, Precos precos)
        {
            InitializeComponent();
            this.cliente = cliente;
            tx_nome_resumo.Text = cliente.getNome();
            tx_contato_resumo.Text = cliente.getNumResp();
            tx_resp_resumo.Text = cliente.getResp();
            tx_tempo_resumo.Text = cliente.getTempoIni().ToString();
            tx_acrescimo15_resumo.Text = cliente.acrescimos[0].ToString();
            tx_acrescimo30_resumo.Text = cliente.acrescimos[1].ToString();
            tx_acrescimo45_resumo.Text = cliente.acrescimos[2].ToString();
            tx_acrescimo60_resumo.Text = cliente.acrescimos[3].ToString();

            if(float.Parse(tx_tempo_resumo.Text) == 15)
            {
                tx_precoini_resumo.Text = precos.preco15min.ToString();
            }
            else if (float.Parse(tx_tempo_resumo.Text) == 30)
            {
                tx_precoini_resumo.Text = precos.preco30min.ToString();
            }
            else if (float.Parse(tx_tempo_resumo.Text) == 45)
            {
                tx_precoini_resumo.Text = precos.preco45min.ToString();
            }
            else if (float.Parse(tx_tempo_resumo.Text) == 60)
            {
                tx_precoini_resumo.Text = precos.preco60min.ToString();
            }

            tx_temporest_resumo.Text = cliente.getTempo().ToString();
            tx_preco15min_resumo.Text = precos.preco15min.ToString();
            tx_preco30min_resumo.Text = precos.preco30min.ToString();
            tx_preco45min_resumo.Text = precos.preco45min.ToString();
            tx_preco60min_resumo.Text = precos.preco60min.ToString();

            tx_total_resumo.Text = (( float.Parse(tx_precoini_resumo.Text)) + (cliente.acrescimos[0] * precos.preco15min) +
                (cliente.acrescimos[1] * precos.preco30min) +
                (cliente.acrescimos[2] * precos.preco45min) +
                (cliente.acrescimos[3] * precos.preco60min)).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
