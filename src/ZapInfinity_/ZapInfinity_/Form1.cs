using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZapInfinity_
{
    public partial class Form1 : Form
    {
        public Point mouseLocation;
        private WhatsAppSendMessage WhatsAppSendMessage;

        public Form1()
        {
            InitializeComponent();
            WhatsAppSendMessage = new WhatsAppSendMessage(listView1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WhatsAppSendMessage.Verificar();
            listView1.Columns.Add("Telefone", 100);
            listView1.Columns.Add("Nome", 70);
            listView1.Columns.Add("Status", 70);
            maskedTextBox1.Mask = "(99) 9999-9999";

        }

        private void MessageOne_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
        }

        private void MessageTwo_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
        }

        private void AddName_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Text += "{nome}";
            }
            else
            {
                richTextBox2.Text += "{nome}";
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ImportCSV(string filePath)
        {
            // Lê todas as linhas do arquivo CSV
            List<string> lines = File.ReadAllLines(filePath).ToList();

            // Limpa a ListView
            listView1.Items.Clear();

            // Adiciona colunas se não existirem
            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Telefone", 100);
                listView1.Columns.Add("Nome", 60);
            }

            foreach (string line in lines)
            {
                // Divide a linha do CSV em campos
                string[] fields = line.Split(',');

                // Certifique-se de que há pelo menos 2 campos (Telefone e Nome)
                if (fields.Length >= 2)
                {
                    ListViewItem item = new ListViewItem(fields[0]);
                    item.SubItems.Add(fields[1]);
                    listView1.Items.Add(item);
                }
            }
        }

        private void ExportToCSV()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Salvar arquivo CSV",
                FileName = "exported_data.csv",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {

                    // Escreve os dados da ListView no arquivo CSV
                    foreach (ListViewItem item in listView1.Items)
                    {
                        string telefone = item.SubItems[0].Text;
                        string nome = item.SubItems[1].Text;
                        writer.WriteLine($"{telefone}, {nome}");
                    }
                }

                MessageBox.Show("Dados exportados com sucesso para arquivo CSV!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse CSV File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "CSV files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                try
                {
                    ImportCSV(filePath);
                    button7.Text = "Números WhatsApp(" + listView1.Items.Count + ")";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao importar o arquivo CSV: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Nenhum Telefone encontrado");
            }
            else
            {
                ExportToCSV();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mask = "(99) 9999-9999";
            string input = maskedTextBox1.Text;

            // Remova todos os caracteres não numéricos da entrada
            string numericInput = new string(input.Where(char.IsDigit).ToArray());

            // Verifique se o número de dígitos na entrada é igual ao número de dígitos na máscara
            bool isFilledWithNumbers = numericInput.Length == mask.Count(c => c == '9');

            if (isFilledWithNumbers)
            {
                ListViewItem newcontato = new ListViewItem(maskedTextBox1.Text);
                listView1.Items.Add(newcontato);
                newcontato.SubItems.Add(textBox1.Text);
                maskedTextBox1.Text = "";
                textBox1.Text = "";
                // O MaskedTextBox está preenchido com números.
                button7.Text = "Números WhatsApp("+listView1.Items.Count + ")";

            }
            else
            {
                // O MaskedTextBox não está preenchido com números.
                MessageBox.Show("O MaskedTextBox não está preenchido com números.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (richTextBox1.Text.Length == 0 && richTextBox2.Text.Length == 0)
            {
                MessageBox.Show("Mensagem tem que ter algum valor");
            }
            else if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Nenhum Telefone encontrado");
            }
            else
            {
                List<string> telefone = new List<string>();
                List<string> nome = new List<string>();
                List<string> mensagem = new List<string>();
                int Tempo = Convert.ToInt32(textBox2.Text);

                if (richTextBox1.Text != "")
                {
                    mensagem.Add(richTextBox1.Text);
                }

                if (richTextBox2.Text != "")
                {
                    mensagem.Add(richTextBox2.Text);
                }
                
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    telefone.Add(listView1.Items[i].Text);
                    nome.Add(listView1.Items[i].SubItems[1].Text);
                }


                button3.Text = "Enviando...";
                WhatsAppSendMessage.SendMessage(mensagem, telefone, nome,listView1, Tempo, button3);


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            button7.Text = "Números WhatsApp(" + listView1.Items.Count + ")";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            button7.Text = "Números WhatsApp(" + listView1.Items.Count + ")";
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Browse CSV File",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "csv",
                    Filter = "CSV files (*.csv)|*.csv",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true,
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    try
                    {
                        ImportCSV(filePath);
                        button7.Text = "Números WhatsApp(" + listView1.Items.Count + ")";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao importar o arquivo CSV: {ex.Message}");
                    }
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            this.button8.BackColor = Color.Red;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            this.button8.BackColor = Color.ForestGreen;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Nenhum Telefone encontrado");
            }
            else
            {
                ExportToCSV();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifique se a tecla pressionada não é um número ou teclas de controle.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Se não for um número ou tecla de controle, ignore a entrada do usuário.
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
