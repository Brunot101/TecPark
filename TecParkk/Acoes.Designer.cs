namespace TecParkk
{
    partial class Acoes
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
            tx_nome_acoes = new TextBox();
            label1 = new Label();
            tx_obs_acoes = new TextBox();
            label2 = new Label();
            bt_editar = new Button();
            bt_tempo = new Button();
            SuspendLayout();
            // 
            // tx_nome_acoes
            // 
            tx_nome_acoes.Location = new Point(236, 52);
            tx_nome_acoes.Name = "tx_nome_acoes";
            tx_nome_acoes.ReadOnly = true;
            tx_nome_acoes.Size = new Size(327, 23);
            tx_nome_acoes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 34);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do cliente";
            label1.Click += label1_Click;
            // 
            // tx_obs_acoes
            // 
            tx_obs_acoes.Location = new Point(12, 117);
            tx_obs_acoes.Multiline = true;
            tx_obs_acoes.Name = "tx_obs_acoes";
            tx_obs_acoes.ReadOnly = true;
            tx_obs_acoes.Size = new Size(215, 153);
            tx_obs_acoes.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 99);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Observações";
            // 
            // bt_editar
            // 
            bt_editar.Location = new Point(322, 116);
            bt_editar.Name = "bt_editar";
            bt_editar.Size = new Size(75, 23);
            bt_editar.TabIndex = 4;
            bt_editar.Text = "Editar Info.";
            bt_editar.UseVisualStyleBackColor = true;
            // 
            // bt_tempo
            // 
            bt_tempo.Location = new Point(414, 116);
            bt_tempo.Name = "bt_tempo";
            bt_tempo.Size = new Size(75, 23);
            bt_tempo.TabIndex = 5;
            bt_tempo.Text = "Tempo";
            bt_tempo.UseVisualStyleBackColor = true;
            bt_tempo.Click += bt_tempo_Click;
            // 
            // Acoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 275);
            Controls.Add(bt_tempo);
            Controls.Add(bt_editar);
            Controls.Add(label2);
            Controls.Add(tx_obs_acoes);
            Controls.Add(label1);
            Controls.Add(tx_nome_acoes);
            Name = "Acoes";
            Text = "acoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_nome_acoes;
        private Label label1;
        private TextBox tx_obs_acoes;
        private Label label2;
        private Button bt_editar;
        private Button bt_tempo;
    }
}