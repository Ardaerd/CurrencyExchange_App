using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CurrencyExchange_App
{
    public partial class Form1 : Form
    {
        private string apiKey = "0d00d158cb84d5d43a642932";
        private string baseCurrency = null;
        private string targetCurrency = null;
        private double amount;
        private double price;
        private bool upDown;

        public Form1()
        {
            InitializeComponent();
        }

        public void getCurrency()
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://v6.exchangerate-api.com/v6/{0}/pair/{1}/{2}/{3}",apiKey,baseCurrency,targetCurrency,amount);
                Console.WriteLine(url);

                var json = web.DownloadString(url);
                CurrencyInfo.API_Obj currencyInfo = JsonConvert.DeserializeObject<CurrencyInfo.API_Obj>(json);

                price = currencyInfo.conversion_result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Currency_1.Items.Add("USD");
            comboBox_Currency_1.Items.Add("EUR");
            comboBox_Currency_1.Items.Add("TRY");
            comboBox_Currency_1.Items.Add("EGP");

            comboBox_Currency_2.Items.Add("USD");
            comboBox_Currency_2.Items.Add("EUR");
            comboBox_Currency_2.Items.Add("TRY");
            comboBox_Currency_2.Items.Add("EGP");

        }

        private void Currency_1_ValueChanged(object sender, EventArgs e)
        {
            baseCurrency = comboBox_Currency_1.Text;
            targetCurrency = comboBox_Currency_2.Text;
            amount = (double) Currency_1.Value;

            upDown = true;

        }

        private void Currency_2_ValueChanged(object sender, EventArgs e)
        {
            baseCurrency = comboBox_Currency_2.Text;
            targetCurrency = comboBox_Currency_1.Text;
            amount = (double) Currency_2.Value;

            upDown = false;

            }

        private void button1_Click(object sender, EventArgs e)
        {
            getCurrency();

            if (upDown)
            {
                Currency_2.Value = (decimal) price;
            }
            else
            {
                Currency_1.Value = (decimal)price;
            }

        }

        private void comboBox_Currency_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baseCurrency = comboBox_Currency_1.Text;
            targetCurrency = comboBox_Currency_2.Text;
            amount = (double)Currency_1.Value;

            upDown = true;
        }

        private void comboBox_Currency_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baseCurrency = comboBox_Currency_2.Text;
            targetCurrency = comboBox_Currency_1.Text;
            amount = (double)Currency_2.Value;

            upDown = false;
        }
    }
}
