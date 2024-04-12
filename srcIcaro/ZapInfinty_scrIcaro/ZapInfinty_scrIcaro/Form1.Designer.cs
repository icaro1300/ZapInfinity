namespace ZapInfinty_scrIcaro
{
    partial class ZapInfinity
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_DeletarTudo = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_numero = new System.Windows.Forms.Label();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.label_mensagem = new System.Windows.Forms.Label();
            this.label_imagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(454, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(313, 145);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.Location = new System.Drawing.Point(9, 137);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(144, 29);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_DeletarTudo
            // 
            this.btn_DeletarTudo.BackColor = System.Drawing.SystemColors.Window;
            this.btn_DeletarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeletarTudo.Location = new System.Drawing.Point(454, 171);
            this.btn_DeletarTudo.Name = "btn_DeletarTudo";
            this.btn_DeletarTudo.Size = new System.Drawing.Size(136, 36);
            this.btn_DeletarTudo.TabIndex = 2;
            this.btn_DeletarTudo.Text = "Deletar Tudo";
            this.btn_DeletarTudo.UseVisualStyleBackColor = false;
            this.btn_DeletarTudo.Click += new System.EventHandler(this.btn_DeletarTudo_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.Location = new System.Drawing.Point(596, 174);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(84, 33);
            this.btn_Deletar.TabIndex = 3;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Enviar.Location = new System.Drawing.Point(692, 172);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 37);
            this.btn_Enviar.TabIndex = 4;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(25, 21);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(53, 18);
            this.label_nome.TabIndex = 5;
            this.label_nome.Text = "Nome";
            this.label_nome.Click += new System.EventHandler(this.label_nome_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(28, 42);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(100, 22);
            this.textBox_nome.TabIndex = 6;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox_nome_TextChanged);
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.Location = new System.Drawing.Point(25, 79);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(68, 18);
            this.label_numero.TabIndex = 7;
            this.label_numero.Text = "Número";
            this.label_numero.Click += new System.EventHandler(this.label_numero_Click);
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(28, 100);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(100, 22);
            this.textBox_numero.TabIndex = 8;
            this.textBox_numero.TextChanged += new System.EventHandler(this.textBox_numero_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(204, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(189, 98);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.PictureBox.Location = new System.Drawing.Point(220, 169);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(134, 49);
            this.PictureBox.TabIndex = 10;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // label_mensagem
            // 
            this.label_mensagem.AutoSize = true;
            this.label_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensagem.Location = new System.Drawing.Point(251, 21);
            this.label_mensagem.Name = "label_mensagem";
            this.label_mensagem.Size = new System.Drawing.Size(90, 18);
            this.label_mensagem.TabIndex = 11;
            this.label_mensagem.Text = "Mensagem";
            this.label_mensagem.Click += new System.EventHandler(this.label_mensagem_Click);
            // 
            // label_imagem
            // 
            this.label_imagem.AutoSize = true;
            this.label_imagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imagem.Location = new System.Drawing.Point(251, 148);
            this.label_imagem.Name = "label_imagem";
            this.label_imagem.Size = new System.Drawing.Size(67, 18);
            this.label_imagem.TabIndex = 12;
            this.label_imagem.Text = "Imagem";
            this.label_imagem.Click += new System.EventHandler(this.label_imagem_Click);
            // 
            // ZapInfinity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(787, 290);
            this.Controls.Add(this.label_imagem);
            this.Controls.Add(this.label_mensagem);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_DeletarTudo);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.listView1);
            this.Name = "ZapInfinity";
            this.Text = "ZapInfinity";
            this.Load += new System.EventHandler(this.ZapInfinity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_DeletarTudo;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label_mensagem;
        private System.Windows.Forms.Label label_imagem;
    }
}

