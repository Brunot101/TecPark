using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecParkk
{
    
    public partial class Tempo : Form
    {
        private Cliente cliente1;
        int acrescimo15 = 0;
        int acrescimo30 = 0;
        int acrescimo45 = 0;
        int acrescimo60 = 0;
        public event EventHandler AtualizarTempo;
        public Tempo(Cliente cliente)
        {
            InitializeComponent();
            this.cliente1 = cliente;
            tx_temporest.Text = cliente.getTempo().ToString();
            tx_acrescimo15.Text = acrescimo15.ToString();
            tx_acrescimo30.Text = acrescimo30.ToString();
            tx_acrescimo45.Text = acrescimo45.ToString();
            tx_acrescimo60.Text = acrescimo60.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void bt_acrescimo15(object sender, EventArgs e)
        {
            acrescimo15 += 15;
            cliente1.acrescimos[0] += 1;
            tx_acrescimo15.Text = acrescimo15.ToString();

        }


        private void bt_acrescimo30(object sender, EventArgs e)
        {
            acrescimo30 += 30;
            cliente1.acrescimos[1] += 1;
            tx_acrescimo30.Text = acrescimo30.ToString();
        }

        private void bt_acrescimo45(object sender, EventArgs e)
        {   
            acrescimo45 += 45;
            cliente1.acrescimos[2] += 1;
            tx_acrescimo45.Text = acrescimo45.ToString();
        }
        private void bt_acrescimo60(object sender, EventArgs e)
        {
            acrescimo60 += 60;
            cliente1.acrescimos[3] += 1;
            tx_acrescimo60.Text = acrescimo60.ToString();
        }




        private void bt_menos15_Click(object sender, EventArgs e)
        {   

            if(acrescimo15 - 15 > 0)
            {
                acrescimo15 -= 15;
                cliente1.acrescimos[0] -= 1;
                tx_acrescimo15.Text = acrescimo15.ToString();
            }
            else
            {
                acrescimo15 = 0;
                cliente1.setTempo(cliente1.getTempo() + acrescimo15);
            }
            

        }


        private void bt_menos30_Click(object sender, EventArgs e)
        {
            if (acrescimo30 - 30 > 0)
            {
                acrescimo30 -= 30;
                cliente1.acrescimos[1] -= 1;
            }
            else
            {
                acrescimo30 = 0;
                
            }
            tx_acrescimo30.Text = acrescimo30.ToString();
        }

        private void bt_menos45_Click(object sender, EventArgs e)
        {
            if (acrescimo45 - 45 > 0)
            {
                acrescimo45 -= 45;
                cliente1.acrescimos[2] -= 1;
            }
            else
            {
                acrescimo45 = 0;
                
            }
            tx_acrescimo45.Text = acrescimo45.ToString();
        }
        private void bt_menos60_Click(object sender, EventArgs e)
        {
            if (acrescimo60 - 60 > 0)
            {
                acrescimo60 -= 60;
                cliente1.acrescimos[3] -= 1;
            }
            else
            {
                acrescimo60 = 0;
                
            }
            tx_acrescimo60.Text = acrescimo60.ToString();
        }


        private void bt_savetempo_Click(Object sender, EventArgs e)
        {
            cliente1.setTempo(cliente1.getTempo() + this.acrescimo15 + this.acrescimo30 + this.acrescimo45 + this.acrescimo60);
            AtualizarTempo?.Invoke(this, EventArgs.Empty);
            this.Close();
        }


    }
}
