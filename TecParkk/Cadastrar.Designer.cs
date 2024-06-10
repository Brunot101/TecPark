namespace TecParkk
{
    partial class Cadastrar
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
            tb_base = new TextBox();
            label1 = new Label();
            bt_base = new Button();
            SuspendLayout();
            // 
            // tb_base
            // 
            tb_base.Location = new Point(254, 214);
            tb_base.Name = "tb_base";
            tb_base.Size = new Size(100, 23);
            tb_base.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 217);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // bt_base
            // 
            bt_base.Location = new Point(237, 323);
            bt_base.Name = "bt_base";
            bt_base.Size = new Size(117, 23);
            bt_base.TabIndex = 2;
            bt_base.Text = "Salvar";
            bt_base.UseVisualStyleBackColor = true;
            bt_base.Click += this.bt_base_Click;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(bt_base);
            Controls.Add(label1);
            Controls.Add(tb_base);
            Name = "Cadastrar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_base;
        private Label label1;
        private Button bt_base;
    }
}