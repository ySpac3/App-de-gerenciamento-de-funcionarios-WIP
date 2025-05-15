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
using CsvHelper;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;

namespace App_Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Lendo o Arquivo csv
            _ = LoadSellsFromHttp();

        }
        private async Task LoadSellsFromHttp()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = "http://127.0.0.1:5000";   
                string json = await client.GetStringAsync(url);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<Sell> sells = JsonSerializer.Deserialize<List<Sell>>(json, options);
                int y = 0;
                foreach(var sold in sells)
                {
                    y = Sell.Sold(sold.Seller, sold.Buyer, sold.Kit, sold.Date, sold.Value.ToString(), sold.Comission.ToString(), sold.Profit.ToString(), 6, y, PnSellCommits);

                }

            }
            catch (Exception ex) 
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
                
            
        }   

        private void PnSellCommits_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
