using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapBot_icaro;

namespace ZapInfinty_scrIcaro
{
    public partial class ZapInfinity : Form
    {
        public ZapInfinity()
        {
            InitializeComponent();
            listView1.View = View.Details; // Define o modo de exibição para detalhes
            listView1.Columns.Add("Nome", 70);
            listView1.Columns.Add("Número", 80);
            listView1.Columns.Add("Status", 100);
        }

        private void InitializeListView()
        {
          
        }

        private void ZapInfinity_Load(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            string nome = textBox_nome.Text;
            string numero = textBox_numero.Text;

            // Verificar se os campos não estão vazios e se Status não é nulo ou vazio
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(numero))
            {
                ListViewItem newItem = new ListViewItem(nome);
                newItem.SubItems.Add(numero);
                listView1.Items.Add(newItem);
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_DeletarTudo_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário se ele realmente deseja excluir todos os itens
            DialogResult result = MessageBox.Show("Tem certeza que deseja deletar todos os itens?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Deletar todos os itens da lista
                listView1.Items.Clear();
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            // Certifique-se de que há um item selecionado na lista
            if (listView1.SelectedItems.Count > 0)
            {
                // Pergunte ao usuário se ele realmente deseja excluir o item selecionado
                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remova o item selecionado da lista
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            string msg = richTextBox1.Text;
            string nome = textBox_nome.Text;
            bool envioBemSucedido = EnviarMensagem(msg, nome);

            // Chame o método apropriado de WhatsAppEnvioMessagem para enviar a mensagem
            // WhatsAppEnvioMessagem w = new WhatsAppEnvioMessagem();
            // w.SendMessage(msg, nome);
            // w.SendMessageWithImage(msg, "C:\\Caminho\\Para\\SuaImagem.jpg", nome);
            // w.SendMessageWithEmoji(msg, new List<string> { "carro" }, nome);

            ListViewItem newItem = new ListViewItem(nome);
            newItem.SubItems.Add(textBox_numero.Text);
            newItem.SubItems.Add(envioBemSucedido ? "Sucesso" : "Falha"); // Status de envio
            listView1.Items.Add(newItem);

            // Limpe os campos após enviar a mensagem
            LimparCampos();
        }

        private bool EnviarMensagem(string mensagem, string nome)
        {
            // Lógica para enviar a mensagem.
            // Retorne true se o envio for bem-sucedido e false em caso de falha.

            // Exemplo de lógica de envio (substitua pelo seu código real)
            bool envioBemSucedido = true; // Supondo que o envio é bem-sucedido

            // Implemente a lógica real para enviar a mensagem e atualize envioBemSucedido de acordo

            return envioBemSucedido;
        }

        private void LimparCampos()
        {
            // Lógica para limpar os campos de entrada, se necessário
            richTextBox1.Text = "";
            textBox_nome.Text = "";
            textBox_numero.Text = "";
        }

        private void label_nome_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_numero_Click(object sender, EventArgs e)
        {

        }

        private void textBox_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    PictureBox.ImageLocation = imagePath;
                }
                catch (Exception ex)
                {
                    // Lidar com qualquer exceção que possa ocorrer ao definir o caminho da imagem
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Lidar com casos onde o caminho da imagem é nulo ou vazio
                MessageBox.Show("Caminho da imagem inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void btn_AdicionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = openFileDialog.FileName;
                PictureBox_Click (caminhoDaImagem);
                richTextBox1.Text += $"[Imagem: {caminhoDaImagem}]\n";
            }
        }

        private void label_mensagem_Click(object sender, EventArgs e)
        {

        }

        private void label_imagem_Click(object sender, EventArgs e)
        {

        }
    }
}
