namespace TecParkk
{
    partial class Precos
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
            label1 = new Label();
            tx_preco15min_precos = new TextBox();
            tx_preco30min_precos = new TextBox();
            tx_preco45min_precos = new TextBox();
            tx_preco60min_precos = new TextBox();
            bt_salvar_precos = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(248, 24);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 0;
            label1.Text = "Tabela de Preços";
            // 
            // tx_preco15min_precos
            // 
            tx_preco15min_precos.Location = new Point(313, 138);
            tx_preco15min_precos.Name = "tx_preco15min_precos";
            tx_preco15min_precos.Size = new Size(100, 23);
            tx_preco15min_precos.TabIndex = 1;
            // 
            // tx_preco30min_precos
            // 
            tx_preco30min_precos.Location = new Point(313, 180);
            tx_preco30min_precos.Name = "tx_preco30min_precos";
            tx_preco30min_precos.Size = new Size(100, 23);
            tx_preco30min_precos.TabIndex = 2;
            // 
            // tx_preco45min_precos
            // 
            tx_preco45min_precos.Location = new Point(313, 220);
            tx_preco45min_precos.Name = "tx_preco45min_precos";
            tx_preco45min_precos.Size = new Size(100, 23);
            tx_preco45min_precos.TabIndex = 3;
            // 
            // tx_preco60min_precos
            // 
            tx_preco60min_precos.Location = new Point(313, 261);
            tx_preco60min_precos.Name = "tx_preco60min_precos";
            tx_preco60min_precos.Size = new Size(100, 23);
            tx_preco60min_precos.TabIndex = 4;
            // 
            // bt_salvar_precos
            // 
            bt_salvar_precos.Location = new Point(556, 411);
            bt_salvar_precos.Name = "bt_salvar_precos";
            bt_salvar_precos.Size = new Size(75, 23);
            bt_salvar_precos.TabIndex = 5;
            bt_salvar_precos.Text = "Salvar";
            bt_salvar_precos.UseVisualStyleBackColor = true;
            bt_salvar_precos.Click += bt_salvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 141);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "15 min";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 183);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "30 min";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 223);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "45 min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 264);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 9;
            label5.Text = "60 min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 264);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 10;
            label6.Text = "R$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 141);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 11;
            label7.Text = "R$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 223);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 12;
            label8.Text = "R$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(287, 183);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 13;
            label9.Text = "R$";
            // 
            // Precos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bt_salvar_precos);
            Controls.Add(tx_preco60min_precos);
            Controls.Add(tx_preco45min_precos);
            Controls.Add(tx_preco30min_precos);
            Controls.Add(tx_preco15min_precos);
            Controls.Add(label1);
            Name = "Precos";
            Text = "Precos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx_preco15min_precos;
        private TextBox tx_preco30min_precos;
        private TextBox tx_preco45min_precos;
        private TextBox tx_preco60min_precos;
        private Button bt_salvar_precos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}