using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Dashboard
{
    internal class SellerStatus
    {
        public string name { get; set; }
        public string status { get; set; }
        public int cdg { get; set; }

        public static int State(string Seller, string Status, int x, int y, Panel painel)
        {
            
            List<string> names = new List<string> { Seller, Status };
            int counter = 0;
            Color cor = Color.Gray;
            foreach (string name in names)
            {

                System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                label.Text = name;

                label.Font = new Font(label.Font.FontFamily, 18);
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
