using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TecParkk.Cliente;
namespace TecParkk


{
    
        public partial class Adicionar : Form
    {

        

        Controle controle;
        public Adicionar(Controle form)
        {
            InitializeComponent();
            
            this.controle = form;
        }

       

        public void bt_cadastrar_Click(object sender, EventArgs e)
        {
            int temp;
            int.TryParse(tx_tempo.Text,out temp);
            Cliente cliente = new Cliente(tx_nome.Text, tx_idade.Text, tx_resp.Text, tx_numResp.Text, temp, tx_obs.Text);
            this.controle.clientes.Add(cliente);
            MessageBox.Show("Cliente registrado com sucesso!");
            this.Close();
















        }



    }
}
