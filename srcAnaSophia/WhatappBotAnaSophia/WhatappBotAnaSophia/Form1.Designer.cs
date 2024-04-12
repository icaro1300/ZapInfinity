namespace WhatappBotAnaSophia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addnome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_contatos = new System.Windows.Forms.ListView();
            this.btnMenssag1 = new System.Windows.Forms.Button();
            this.btnMenssag2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(427, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "enviar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(218, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 236);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(425, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nome.Location = new System.Drawing.Point(429, 61);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(149, 20);
            this.tb_nome.TabIndex = 4;
            this.tb_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(509, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "negrito";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ImageKey = "(nenhum/a)";
            this.button3.Location = new System.Drawing.Point(428, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "italico";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addnome
            // 
            this.addnome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addnome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addnome.Location = new System.Drawing.Point(427, 166);
            this.addnome.Name = "addnome";
            this.addnome.Size = new System.Drawing.Size(75, 23);
            this.addnome.TabIndex = 7;
            this.addnome.Text = "add nome";
            this.addnome.UseVisualStyleBackColor = false;
            this.addnome.Click += new System.EventHandler(this.addnome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "contatos";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.LightYellow;
            this.button4.Location = new System.Drawing.Point(489, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "add contato";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_deletar
            // 
            this.bt_deletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deletar.BackColor = System.Drawing.Color.LightYellow;
            this.bt_deletar.Location = new System.Drawing.Point(509, 166);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(69, 23);
            this.bt_deletar.TabIndex = 11;
            this.bt_deletar.Text = "deletar";
            this.bt_deletar.UseVisualStyleBackColor = false;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // col_id
            // 
            this.col_id.Text = "Nome";
            this.col_id.Width = 160;
            // 
            // lv_contatos
            // 
            this.lv_contatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_contatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id});
            this.lv_contatos.HideSelection = false;
            this.lv_contatos.Location = new System.Drawing.Point(12, 43);
            this.lv_contatos.Name = "lv_contatos";
            this.lv_contatos.Size = new System.Drawing.Size(159, 243);
            this.lv_contatos.TabIndex = 8;
            this.lv_contatos.UseCompatibleStateImageBehavior = false;
            this.lv_contatos.View = System.Windows.Forms.View.Details;
            // 
            // btnMenssag1
            // 
            this.btnMenssag1.BackColor = System.Drawing.Color.LightYellow;
            this.btnMenssag1.Location = new System.Drawing.Point(218, 25);
            this.btnMenssag1.Name = "btnMenssag1";
            this.btnMenssag1.Size = new System.Drawing.Size(89, 23);
            this.btnMenssag1.TabIndex = 12;
            this.btnMenssag1.Text = "Menssagem 1";
            this.btnMenssag1.UseVisualStyleBackColor = false;
            this.btnMenssag1.UseWaitCursor = true;
            this.btnMenssag1.Click += new System.EventHandler(this.btnMenssag1_Click);
            // 
            // btnMenssag2
            // 
            this.btnMenssag2.BackColor = System.Drawing.Color.LightYellow;
            this.btnMenssag2.Location = new System.Drawing.Point(302, 25);
            this.btnMenssag2.Name = "btnMenssag2";
            this.btnMenssag2.Size = new System.Drawing.Size(89, 23);
            this.btnMenssag2.TabIndex = 13;
            this.btnMenssag2.Text = "Menssagem 2";
            this.btnMenssag2.UseVisualStyleBackColor = false;
            this.btnMenssag2.UseWaitCursor = true;
            this.btnMenssag2.Click += new System.EventHandler(this.btnMenssag2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(218, 43);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(173, 236);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(590, 313);
            this.Controls.Add(this.btnMenssag2);
            this.Controls.Add(this.btnMenssag1);
            this.Controls.Add(this.bt_deletar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lv_contatos);
            this.Controls.Add(this.addnome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WhatApp Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_deletar;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ListView lv_contatos;
        private System.Windows.Forms.Button btnMenssag1;
        private System.Windows.Forms.Button btnMenssag2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

