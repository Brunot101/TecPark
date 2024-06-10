using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TecParkk.Cliente;
using Timer = System.Windows.Forms.Timer;

namespace TecParkk
{
    public partial class Controle : Form
    {
        public List<Cliente> clientes = new List<Cliente>();
        private Timer timer;
       
        public Controle()
        {
            
            InitializeComponent();
            InitializeDataGridView();
            this.FormClosed += Controle_FormClosed;


        }
        private void Controle_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            foreach (var cliente in clientes)
            {
                cliente.TempoAtualizado -= Cliente_TempoAtualizado;
                
            }

           
        }
        private void InitializeDataGridView()
        {
            
            dataGridViewClientes.ColumnCount = 5;
            dataGridViewClientes.Columns[0].Name = "Nome";
            dataGridViewClientes.Columns[1].Name = "Idade";
            dataGridViewClientes.Columns[2].Name = "Responsável";
            dataGridViewClientes.Columns[3].Name = "Número do Responsável";
            dataGridViewClientes.Columns[4].Name = "Tempo";

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Ações";
            actionsColumn.Text = "Editar";
            actionsColumn.UseColumnTextForButtonValue = true; 
            dataGridViewClientes.Columns.Add(actionsColumn);


            DataGridViewButtonColumn removeColumn = new DataGridViewButtonColumn();
            removeColumn.Name = "Remover";
            removeColumn.Text = "X";
            removeColumn.UseColumnTextForButtonValue = true;
            dataGridViewClientes.Columns.Add(removeColumn);

            DataGridViewButtonColumn payCheckColumn = new DataGridViewButtonColumn();
            payCheckColumn.Name = "Pagamento";
            payCheckColumn.Text = "R$";
            payCheckColumn.UseColumnTextForButtonValue = true;
            dataGridViewClientes.Columns.Add(payCheckColumn);

        }
        

        public void AtualizarDataGridView()
        {
            dataGridViewClientes.Rows.Clear();
            foreach (var cliente in clientes)
            {
                dataGridViewClientes.Rows.Add(cliente.getNome(), cliente.getIdade(), cliente.getResp(), cliente.getNumResp(), cliente.getTempo(), cliente.getObs());

            }
        }

        
        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            Adicionar form = new Adicionar(this);
            form.ShowDialog();
            foreach (var cliente in clientes)
            {
                cliente.TempoAtualizado += Cliente_TempoAtualizado;
            }
            
            AtualizarDataGridView();
        }
        private void Cliente_TempoAtualizado(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                AtualizarDataGridView();
            });
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.clientes.ToString());
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewClientes.Columns["Ações"].Index && e.RowIndex >= 0 && e.RowIndex < clientes.Count())
            {

                Acoes acao = new Acoes(clientes[e.RowIndex]);
                acao.AtualizarTempo += AtualizarTempo;
                acao.ShowDialog(this);
                AtualizarDataGridView();
                var cliente = clientes[e.RowIndex];


            }

            if (e.ColumnIndex == dataGridViewClientes.Columns["Remover"].Index && e.RowIndex >= 0 && e.RowIndex < clientes.Count())
            {

                Remove remove = new Remove(clientes,clientes[e.RowIndex]);
                remove.ShowDialog();
                AtualizarDataGridView();
                


            }

            if (e.ColumnIndex == dataGridViewClientes.Columns["Pagamento"].Index && e.RowIndex >= 0 && e.RowIndex < clientes.Count())
            {

                Resumo resumo = new Resumo(clientes[e.RowIndex]);
                resumo.ShowDialog();
                AtualizarDataGridView();



            }
        }

      

        private void AtualizarTempo(object sender, EventArgs e)
        {
            AtualizarDataGridView(); 
        }


        private void Controle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
