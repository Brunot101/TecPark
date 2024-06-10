using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
namespace TecParkk
{
    
    public class Cliente
    {
        public event EventHandler TempoAtualizado;
        private string nome { get; set; }
        private string idade { get; set; }
        private string resp { get; set; }
        private string numResp { get; set; }
        private int tempo { get; set; }
        private string obs { get; set; }
        private Timer timer;

        public Cliente(string nome, string idade, string resp, string numResp, int tempo, string obs)
        {
            {
                this.nome = nome;
                this.resp = resp;
                this.idade = idade;
                this.resp = resp;
                this.numResp = numResp;
                this.tempo = tempo;
                this.obs = obs;
                this.timer = new Timer();
                this.timer.Interval = 60000; // 1 minuto
                this.timer.Tick += Timer_Tick;
                this.timer.Start();

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.tempo > 0)
            {
                this.setTempo(this.getTempo() - 1);
                if(this.tempo == 0) {

                    MessageBox.Show( "O tempo do cliente " + this.nome.ToUpper() + " Acabou!");
                }
                TempoAtualizado?.Invoke(this, EventArgs.Empty);
            }
            
        }

        public string getNome()
        {

            return nome;
        }

        public string getIdade()
        {

            return idade;
        }

        public string getResp()
        {

            return resp;
        }
        public string getNumResp()
        {

            return numResp;
        }

        public int getTempo()
        {

            return tempo;
        }

        public string getObs()
        {

            return obs;
        }


        public void setTempo(int tempo)
        {
            this.tempo = tempo;
        }




    }
}
