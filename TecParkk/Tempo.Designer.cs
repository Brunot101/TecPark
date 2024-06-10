namespace TecParkk
{
    partial class Tempo
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
            tx_temporest = new TextBox();
            label1 = new Label();
            tx_acrescimo15 = new TextBox();
            tx_acrescimo30 = new TextBox();
            tx_acrescimo45 = new TextBox();
            tx_acrescimo60 = new TextBox();
            bt_savetempo = new Button();
            bt_menos15 = new Button();
            bt_mais15 = new Button();
            bt_menos30 = new Button();
            bt_mais30 = new Button();
            bt_menos45 = new Button();
            bt_mais45 = new Button();
            bt_menos60 = new Button();
            bt_mais60 = new Button();
            SuspendLayout();
            // 
            // tx_temporest
            // 
            tx_temporest.Location = new Point(208, 46);
            tx_temporest.Multiline = true;
            tx_temporest.Name = "tx_temporest";
            tx_temporest.ReadOnly = true;
            tx_temporest.Size = new Size(146, 71);
            tx_temporest.TabIndex = 0;
            tx_temporest.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 28);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Tempo restante";
            label1.Click += label1_Click;
            // 
            // tx_acrescimo15
            // 
            tx_acrescimo15.Location = new Point(229, 209);
            tx_acrescimo15.Multiline = true;
            tx_acrescimo15.Name = "tx_acrescimo15";
            tx_acrescimo15.ReadOnly = true;
            tx_acrescimo15.Size = new Size(100, 60);
            tx_acrescimo15.TabIndex = 2;
            // 
            // tx_acrescimo30
            // 
            tx_acrescimo30.Location = new Point(229, 305);
            tx_acrescimo30.Multiline = true;
            tx_acrescimo30.Name = "tx_acrescimo30";
            tx_acrescimo30.ReadOnly = true;
            tx_acrescimo30.Size = new Size(100, 60);
            tx_acrescimo30.TabIndex = 3;
            tx_acrescimo30.TextChanged += textBox2_TextChanged;
            // 
            // tx_acrescimo45
            // 
            tx_acrescimo45.Location = new Point(229, 395);
            tx_acrescimo45.Multiline = true;
            tx_acrescimo45.Name = "tx_acrescimo45";
            tx_acrescimo45.ReadOnly = true;
            tx_acrescimo45.Size = new Size(100, 60);
            tx_acrescimo45.TabIndex = 4;
            // 
            // tx_acrescimo60
            // 
            tx_acrescimo60.Location = new Point(229, 488);
            tx_acrescimo60.Multiline = true;
            tx_acrescimo60.Name = "tx_acrescimo60";
            tx_acrescimo60.ReadOnly = true;
            tx_acrescimo60.Size = new Size(100, 60);
            tx_acrescimo60.TabIndex = 5;
            // 
            // bt_savetempo
            // 
            bt_savetempo.Location = new Point(426, 585);
            bt_savetempo.Name = "bt_savetempo";
            bt_savetempo.Size = new Size(75, 23);
            bt_savetempo.TabIndex = 6;
            bt_savetempo.Text = "Salvar";
            bt_savetempo.UseVisualStyleBackColor = true;
            bt_savetempo.Click += bt_savetempo_Click;
            // 
            // bt_menos15
            // 
            bt_menos15.Location = new Point(123, 232);
            bt_menos15.Name = "bt_menos15";
            bt_menos15.Size = new Size(75, 23);
            bt_menos15.TabIndex = 7;
            bt_menos15.Text = "-";
            bt_menos15.UseVisualStyleBackColor = true;
            bt_menos15.Click += bt_menos15_Click;
            // 
            // bt_mais15
            // 
            bt_mais15.Location = new Point(358, 232);
            bt_mais15.Name = "bt_mais15";
            bt_mais15.Size = new Size(75, 23);
            bt_mais15.TabIndex = 8;
            bt_mais15.Text = "+";
            bt_mais15.UseVisualStyleBackColor = true;
            bt_mais15.Click += bt_acrescimo15;
            // 
            // bt_menos30
            // 
            bt_menos30.Location = new Point(123, 326);
            bt_menos30.Name = "bt_menos30";
            bt_menos30.Size = new Size(75, 23);
            bt_menos30.TabIndex = 9;
            bt_menos30.Text = "-";
            bt_menos30.UseVisualStyleBackColor = true;
            bt_menos30.Click += bt_menos30_Click;
            // 
            // bt_mais30
            // 
            bt_mais30.Location = new Point(358, 326);
            bt_mais30.Name = "bt_mais30";
            bt_mais30.Size = new Size(75, 23);
            bt_mais30.TabIndex = 10;
            bt_mais30.Text = "+";
            bt_mais30.UseVisualStyleBackColor = true;
            bt_mais30.Click += bt_acrescimo30;
            // 
            // bt_menos45
            // 
            bt_menos45.Location = new Point(123, 422);
            bt_menos45.Name = "bt_menos45";
            bt_menos45.Size = new Size(75, 23);
            bt_menos45.TabIndex = 11;
            bt_menos45.Text = "-";
            bt_menos45.UseVisualStyleBackColor = true;
            bt_menos45.Click += bt_menos45_Click;
            // 
            // bt_mais45
            // 
            bt_mais45.Location = new Point(358, 422);
            bt_mais45.Name = "bt_mais45";
            bt_mais45.Size = new Size(75, 23);
            bt_mais45.TabIndex = 12;
            bt_mais45.Text = "+";
            bt_mais45.UseVisualStyleBackColor = true;
            bt_mais45.Click += bt_acrescimo45;
            // 
            // bt_menos60
            // 
            bt_menos60.Location = new Point(123, 512);
            bt_menos60.Name = "bt_menos60";
            bt_menos60.Size = new Size(75, 23);
            bt_menos60.TabIndex = 13;
            bt_menos60.Text = "-";
            bt_menos60.UseVisualStyleBackColor = true;
            bt_menos60.Click += bt_menos60_Click;
            // 
            // bt_mais60
            // 
            bt_mais60.Location = new Point(358, 512);
            bt_mais60.Name = "bt_mais60";
            bt_mais60.Size = new Size(75, 23);
            bt_mais60.TabIndex = 14;
            bt_mais60.Text = "+";
            bt_mais60.UseVisualStyleBackColor = true;
            bt_mais60.Click += bt_acrescimo60;
            // 
            // Tempo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 638);
            Controls.Add(bt_mais60);
            Controls.Add(bt_menos60);
            Controls.Add(bt_mais45);
            Controls.Add(bt_menos45);
            Controls.Add(bt_mais30);
            Controls.Add(bt_menos30);
            Controls.Add(bt_mais15);
            Controls.Add(bt_menos15);
            Controls.Add(bt_savetempo);
            Controls.Add(tx_acrescimo60);
            Controls.Add(tx_acrescimo45);
            Controls.Add(tx_acrescimo30);
            Controls.Add(tx_acrescimo15);
            Controls.Add(label1);
            Controls.Add(tx_temporest);
            Name = "Tempo";
            Text = "Tempo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_temporest;
        private Label label1;
        private TextBox tx_acrescimo15;
        private TextBox tx_acrescimo30;
        private TextBox tx_acrescimo45;
        private TextBox tx_acrescimo60;
        private Button bt_savetempo;
        private Button bt_menos15;
        private Button bt_mais15;
        private Button bt_menos30;
        private Button bt_mais30;
        private Button bt_menos45;
        private Button bt_mais45;
        private Button bt_menos60;
        private Button bt_mais60;
    }
}