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
using static System.Net.WebRequestMethods;

namespace App_Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Lendo o Arquivo csv
            _ = LoadSellsFromHttp();
            _ = RunStatusLoopAsync();
                
                

        }
        private async Task RunStatusLoopAsync()
        {
            while (true)
            {
                PnSellerStatus.Controls.Clear();
                await LoadSellersStatusFromHttp();
                await Task.Delay(60*1000);  
            }
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
                    y = Sell.Sold(sold.Seller, sold.Buyer, sold.Kit, sold.Date, sold.Value.ToString("F2"), sold.Comission.ToString("F2"), sold.Profit.ToString("F2"), 6, y, PnSellCommits);

                }

            }
            catch (Exception ex) 
            {

            }
        }
        private async Task LoadSellersStatusFromHttp()
        {
            HttpClient client = new HttpClient();
            string url = "http://127.0.0.1:5000/status";
            string json = await client.GetStringAsync(url);
            List<SellerStatus> status = JsonSerializer.Deserialize<List<SellerStatus>>(json);
            
            int y = 0;
            foreach(var seller in status)
            {
                y = SellerStatus.State(seller.name, seller.status,6,y,PnSellerStatus);
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
