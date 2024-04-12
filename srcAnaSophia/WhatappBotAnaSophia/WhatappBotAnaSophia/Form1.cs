using com.sun.corba.se.impl.protocol.giopmsgheaders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatappBotAnaSophia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WhatappBot a = new WhatappBot();
            var mensagem1 = richTextBox1.Text;
            var mensagem2 = richTextBox2.Text;
           
            List<string> nome = new List<string>();

            for (int i = 0; i < lv_contatos.Items.Count; i++)
            {
                nome.Add(lv_contatos.Items[i].Text);
            }
            
            
            a.SendMessage(mensagem1 ,mensagem2, nome);
            
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var n = "*";
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text += "*";
                n = n + richTextBox1.Text;
                richTextBox1.Text = n;
            }
            else
            {
                richTextBox2.Text += "*";
                n = n + richTextBox2.Text;
                richTextBox2.Text = n;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var i = "/";
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text += "/";
                i = i + richTextBox1.Text;
                richTextBox1.Text = i;
            }
            else 
            {
                richTextBox2.Text += "/";
                i = i + richTextBox2.Text;
                richTextBox2.Text = i;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addnome_Click(object sender, EventArgs e)
        {
            var add = tb_nome.Text;
            if ( richTextBox1.Visible == true)
            {
                richTextBox1.Text += "{nome}";
            }
            else
            {
                richTextBox2.Text += "{nome}";
            }
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "")
            {
                MessageBox.Show("Digite um nome");
                tb_nome.Focus();
            }
            else
            {
                ListViewItem newcontato = new ListViewItem(tb_nome.Text);
                lv_contatos.Items.Add(newcontato);
                tb_nome.Clear();
            }


        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            if (lv_contatos.SelectedItems.Count > 0)
            {
                lv_contatos.Items.Clear();
            }


        }

        private void btnMenssag1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
        }

        private void btnMenssag2_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox1.Visible = false;
        }
    }
} 
