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
    public partial class Remove : Form
    {
        List<Cliente> clienteList = new List<Cliente>();
        Cliente cliente;
        public Remove(List  <Cliente> clientes, Cliente cliente )
        {
            InitializeComponent();
            this.cliente = cliente;
            this.clienteList = clientes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            this.clienteList.Remove(this.cliente);
            this.Close();

        }
    }
}
