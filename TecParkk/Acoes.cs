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
    public partial class Acoes : Form
    {
        Cliente cliente1;
        public event EventHandler AtualizarTempo;

        public Acoes(Cliente cliente)
        {
            
            InitializeComponent();
            cliente1 = cliente;
            this.tx_nome_acoes.Text = cliente.getNome();
            this.tx_obs_acoes.Text = cliente.getObs();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_tempo_Click(object sender, EventArgs e)
        {
            
            Tempo tempo = new Tempo(this.cliente1);
            tempo.AtualizarTempo += FormTempo_TempoAtualizado;
            tempo.ShowDialog();
        }

        private void FormTempo_TempoAtualizado(object sender, EventArgs e)
        {
            
            AtualizarTempo?.Invoke(this, EventArgs.Empty);
        }
    }
}
