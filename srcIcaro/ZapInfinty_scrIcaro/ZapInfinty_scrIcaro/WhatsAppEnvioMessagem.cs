using EasyAutomationFramework;
using org.bouncycastle.asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeElement = EasyAutomationFramework.TypeElement;

namespace ZapBot_icaro
{
    public class WhatsAppEnvioMessagem : EasyAutomationFramework.Web
    {
        public void SendMessage(string msg, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme);

            Navigate("https://web.whatsapp.com");

            WaitForLoad();

            Thread.Sleep(2000);

            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            while (elementSearch.Sucesso == false)
            {
                Thread.Sleep(2000);

                elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            }

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", msg);

            elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            CloseBrowser();
        }


        public void SendMessageWithImage(string msg, string pathImage, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme);

            Navigate("https://web.whatsapp.com");

            WaitForLoad();

            Thread.Sleep(2000);

            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            while (elementSearch.Sucesso == false)
            {
                Thread.Sleep(2000);

                elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            }

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);


            //click no btn de CLIP
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div/div/div/div/span");

            //add imagem
            AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div/div/span/div/ul/div/div[2]/li/div/input", pathImage);

            //add msg na imagem
            var elementInput = AssignValue(TypeElement.Xpath, "//*[@id=\"app\"]/div/div/div[3]/div[2]/span/div/span/div/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[1]/p", msg);
            elementInput.element.SendKeys(OpenQA.Selenium.Keys.Enter);

        }
        public void SendMessageWithEmoji(string msg, List<string> emojis, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme);

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(2000);

            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div[1]/p", to);

            while (elementSearch.Sucesso == false)
            {
                Thread.Sleep(2000);

                elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            }

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            var elementInput = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[2]/div[1]/p", msg);


            foreach (var emoji in emojis)
            {
                AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[2]/div[1]/p", ":");
                var element = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[2]/div[1]/p", emoji);
                element.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                element.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            }
        }

        private void SetPictureBoxImageLocation(PictureBox pictureBox, string imagePath)
        {
            if (pictureBox != null && !string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    pictureBox.ImageLocation = imagePath;
                }
                catch (Exception ex)
                {
                    // Lidar com qualquer exceção que possa ocorrer ao definir o caminho da imagem
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Lidar com casos onde o PictureBox ou o caminho da imagem é nulo ou vazio
                MessageBox.Show("PictureBox ou caminho da imagem inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}