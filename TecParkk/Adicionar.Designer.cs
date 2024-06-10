namespace TecParkk
{
    partial class Adicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tx_nome = new TextBox();
            tx_idade = new TextBox();
            tx_resp = new TextBox();
            tx_tempo = new TextBox();
            tx_obs = new TextBox();
            tx_numResp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bt_cadastrar = new Button();
            SuspendLayout();
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(189, 76);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(236, 23);
            tx_nome.TabIndex = 0;
            // 
            // tx_idade
            // 
            tx_idade.Location = new Point(189, 135);
            tx_idade.Name = "tx_idade";
            tx_idade.Size = new Size(96, 23);
            tx_idade.TabIndex = 1;
            // 
            // tx_resp
            // 
            tx_resp.Location = new Point(189, 193);
            tx_resp.Name = "tx_resp";
            tx_resp.Size = new Size(236, 23);
            tx_resp.TabIndex = 2;
            // 
            // tx_tempo
            // 
            tx_tempo.Location = new Point(564, 79);
            tx_tempo.Name = "tx_tempo";
            tx_tempo.Size = new Size(100, 23);
            tx_tempo.TabIndex = 3;
            // 
            // tx_obs
            // 
            tx_obs.Location = new Point(503, 155);
            tx_obs.Multiline = true;
            tx_obs.Name = "tx_obs";
            tx_obs.Size = new Size(233, 124);
            tx_obs.TabIndex = 4;
            // 
            // tx_numResp
            // 
            tx_numResp.Location = new Point(189, 256);
            tx_numResp.Name = "tx_numResp";
            tx_numResp.Size = new Size(236, 23);
            tx_numResp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 79);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "NOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 143);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "IDADE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 196);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 8;
            label3.Text = "RESPONSÁVEL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 256);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 9;
            label4.Text = "NÚMERO DO RESPONSÁVEL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 79);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 10;
            label5.Text = "TEMPO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 135);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 11;
            label6.Text = "OBSERVAÇÕES";
            // 
            // bt_cadastrar
            // 
            bt_cadastrar.Location = new Point(368, 396);
            bt_cadastrar.Name = "bt_cadastrar";
            bt_cadastrar.Size = new Size(96, 23);
            bt_cadastrar.TabIndex = 12;
            bt_cadastrar.Text = "CADASTRAR";
            bt_cadastrar.UseVisualStyleBackColor = true;
            bt_cadastrar.Click += bt_cadastrar_Click;
            // 
            // Adicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 450);
            Controls.Add(bt_cadastrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tx_numResp);
            Controls.Add(tx_obs);
            Controls.Add(tx_tempo);
            Controls.Add(tx_resp);
            Controls.Add(tx_idade);
            Controls.Add(tx_nome);
            Name = "Adicionar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_nome;
        private TextBox tx_idade;
        private TextBox tx_resp;
        private TextBox tx_tempo;
        private TextBox tx_obs;
        private TextBox tx_numResp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button bt_cadastrar;
    }
}