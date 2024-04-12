using System.Windows.Forms;

namespace ZapInfinityAnaSophia
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
            WhatsAppEnvioMessagem w = new WhatsAppEnvioMessagem();
            var misisge = richTextBox1.Text;
            var nome = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "*/";
            
        }
    }
}