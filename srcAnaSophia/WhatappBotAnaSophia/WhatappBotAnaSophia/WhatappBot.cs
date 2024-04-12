using EasyAutomationFramework;
using org.bouncycastle.asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatappBotAnaSophia
{
    public class WhatappBot : Web
    {
        public async void SendMessage(string message1 , string message2 ,List<string> nome)
        {
            string messagemnova = "";
            int i = 0;
            StartBrowser(TypeDriver.GoogleChorme);
            
            Navigate("https://web.whatsapp.com/");
            WaitForLoad();

            foreach (var item in nome)
            {
                if (message1 == "")
                {
                    messagemnova = message2;
                }
                else if (message2 == "")
                {
                    messagemnova = message1;
                }
                else 
                {
                    if ( i % 2  == 0 )
                    {
                        messagemnova = message1;
                    }
                    else { messagemnova = message2; }
                }
                messagemnova = message1.Replace("{nome}", item);

                Thread.Sleep(TimeSpan.FromSeconds(20));

                var elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", item, 5);

                while (elemenSearch.Sucesso == false)
                {
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", item, 5);
                }

                elemenSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

                var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", messagemnova);

                elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                i++;
            }

           
            

        }
    }
}
