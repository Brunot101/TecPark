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
        public Resumo(Cliente cliente)
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
            tx_temporest_resumo.Text = cliente.getTempo().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
