using EasyAutomationFramework;
using java.lang;
using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace ZapInfinity_
{
    public class WhatsAppSendMessage : Web
    {
        private ListView listView;

        public WhatsAppSendMessage(ListView listView)
        {
            this.listView = listView;
        }

        public void EnterSite()
        {
            //StartBrowser(TypeDriver.GoogleChorme);

            //Navigate("https://web.whatsapp.com/");

            //WaitForLoad();
        }
        public async Task SendMessage(List<string> message, List<string> to, List<string> nome, ListView list, int Tempo, Button btn)
        {
            await Task.Run(async () =>
            {
                StartBrowser(TypeDriver.GoogleChorme);

                Navigate("https://web.whatsapp.com/");

                WaitForLoad();

                var i = 0;

                string mensagemcustomizada = null;

                foreach (var item in to)
                {
                    try
                    {
                        await Task.Delay(TimeSpan.FromSeconds(Tempo));

                        var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", item);

                        while (elementSearch.Sucesso == false)
                        {
                            await Task.Delay(TimeSpan.FromSeconds(10));

                            elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", item);
                        }

                        elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

                        for (int z = 0; z < 14; z++)
                        {
                            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Backspace);
                        }

                        if (message.Count > 1)
                        {
                            if (i % 2 == 0)
                            {
                                mensagemcustomizada = message[0].Replace("{nome}", nome[i]);
                            }
                            else
                            {
                                mensagemcustomizada = message[1].Replace("{nome}", nome[i]);
                            }
                        }
                        else
                        {
                            mensagemcustomizada = message[0].Replace("{nome}", nome[i]);
                        }
                        var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]", mensagemcustomizada);

                        ListViewItem newcontato = new ListViewItem();

                        if (elementMessage.Sucesso == false)
                        {
                            list.Invoke(new Action(() =>
                            {

                                list.Items[i].SubItems.Add("Erro").ForeColor = Color.Red;
                                btn.Text = "Enviar";

                            }));
                        }
                        else
                        {
                            elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);

                            list.Invoke(new Action(() =>
                            {

                                list.Items[i].SubItems.Add("Sucesso").ForeColor = Color.Green;
                                btn.Text = "Enviar";

                            }));

                            var element = driver.FindElement(By.XPath("//*[@id=\"main\"]/header/div[3]/div/div[2]/div/div/span"));

                            element.Click();

                            await Task.Delay(TimeSpan.FromSeconds(2));

                            var elements = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/span[4]/div/ul/div/div/li[3]"));

                            elements.Click();
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Erro");
                    }
                    i++;
                }

                CloseBrowser();
            });
        }

        public void Verificar()
        {
            // Caminho do registro onde as informações do Google Chrome são armazenadas
            string registryPath = @"Software\Google\Chrome\BLBeacon";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Obtém a versão do Google Chrome
                        string chromeVersion = key.GetValue("version")?.ToString();

                        if (!string.IsNullOrEmpty(chromeVersion))
                        {
                            MessageBox.Show($"Versão do Google Chrome: {chromeVersion}", "Versão do Chrome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Obtenha a versão da biblioteca OpenQA.Selenium.Chrome
                            string chromeDriverVersion = typeof(ChromeDriver).Assembly.GetName().Version.ToString();

                            MessageBox.Show($"A versão da biblioteca OpenQA.Selenium.Chrome é: {chromeDriverVersion}");
                        }
                        else
                        {
                            MessageBox.Show("O Google Chrome não está instalado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    }
    

