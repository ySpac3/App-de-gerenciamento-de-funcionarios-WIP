using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Diagnostics;


namespace App_Dashboard
{
    public class Sell
    {
        public string Seller { get; set; }
        public string Buyer { get; set; }
        public string Kit { get; set; }
        public string Date { get; set; }
        public float Comission { get; set; }
        public float Value { get; set; }
        public float Profit { get; set; }

        public static int Sold(string Seller, string Buyer, string Kit, string Date, string Value, string Comission, string Profit, int x, int y, Panel painel)
        {
            List<string> names = new List<string> { Seller, Buyer, Kit, Date, Value, Comission, Profit};
            int counter = 0;
            Color cor = Color.Gray;
            foreach (string name in names)
            {
                
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Text = name;
                
                label.Font = new Font(label.Font.FontFamily,18);
                label.ForeColor = Color.White;
                label.BackColor = cor;
                label.AutoSize = true;
                painel.Controls.Add(label);
                label.Location = new Point(x, y);
                x += label.PreferredWidth + 2;
                if (counter == 6)
                {
                    y += label.PreferredHeight + 5;
                    counter = 0;
                }
                counter++;
                if (cor == Color.Gray)
                {
                    cor = Color.Black;
                }
                else
                {
                    cor = Color.Gray;
                }
            }
            return y;
            
            painel.Refresh();
        }

    }
}
