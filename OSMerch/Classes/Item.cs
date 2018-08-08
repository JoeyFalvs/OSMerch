using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace OSMerch
{
    class Item
    {
        #region Fields
        private string _name = "";
        private Double _id = 0;
        private Double _average = 0;
        private Double _buyPrice = 0;
        private Double _sellPrice = 0;
        private Double _buyAmount = 0;
        private Double _sellAmount = 0;
        private Double[] _priceHistory = null;
        private Double[] _tradeHistory = null;
        private Double _profit = 0;
        private Double _profitRatio = 0;
        private double _tradeRatio = 0; //b/s
        private Image _icon = null;
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Average
        {
            get { return _average; }
            set { _average = value; }
        }

        public double BuyPrice
        {
            get { return _buyPrice; }
            set { _buyPrice = value; }
        }

        public double SellPrice
        {
            get { return _sellPrice; }
            set { _sellPrice = value; }
        }

        public double BuyAmount
        {
            get { return _buyAmount; }
            set { _buyAmount = value; }
        }

        public double SellAmount
        {
            get { return _sellAmount; }
            set { _sellAmount = value; }
        }

        public double Profit
        {
            get
            {
                return _buyPrice - _sellPrice;
            }
        }

        public double ProfitRatio
        {
            get
            {
                return _buyPrice / _sellPrice;
            }
        }

        public double TradeRatio
        {
            get
            {
                return _buyAmount / SellAmount;
            }
        }

        public double[] PriceHistory
        {
            get { return _priceHistory; }
            set { _priceHistory = value; }
        }

        public double[] TradeHistory
        {
            get { return _tradeHistory; }
            set { _tradeHistory = value; }
        }

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }
        #endregion

        #region Constuctors
        public Item()
        {
            _priceHistory = new double[1000];
            _tradeHistory = new double[1000];
        }
        #endregion

        #region Methods
        public void Load(string id)
        {
            try
            {
                _id = Convert.ToDouble(id);
                string path = Path.GetTempPath();
                string line;
                //Download item data
                
                    if (!File.Exists(@"ItemData\item." + id + ".atk"))
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(@"http://services.runescape.com/m=itemdb_oldschool/Saradomin_sword/Runescape/viewitem?obj=" + id, @"ItemData\item." + id+  ".atk");
                        Debug.WriteLine("Item: " + _id);
                        client.Dispose();
                    }
                
                

                //Read downloaded data
                StreamReader Stream = new StreamReader(@"ItemData\item." + id + ".atk");
                string[] lines = Stream.ReadToEnd().Split(new char[] { '\n' });
                int e = 0;
                for (int i = 335; i <= 693; i++)
                {
                    if (i % 2 == 0)
                    {

                    }
                    else
                    {
                        //is odd
                        Debug.WriteLine(lines[i]);
                        string[] split = lines[i].Split(',');
                        try
                        {
                            string price = split[1];
                            price.TrimStart(' ');
                            Debug.WriteLine(split[1]);
                            PriceHistory[e] = Convert.ToDouble(price);
                            Debug.WriteLine(PriceHistory[e]);
                            e++;
                        }
                        catch
                        {

                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Spelled Item Wrong");
            }
            
        }
        
        public double GetId(string name)
        {
            this.Name = name;
            try
            {
                string temp = "";
                string[] json = File.ReadAllLines(@"ItemData\Items.json");
                for (int i = 0; i < json.Length; i++)
                {
                    if (json[i].Contains(name))
                    {
                        i--;
                        Debug.Write(name);
                        temp = json[i].Substring(3, json[i].Length - 3);
                        temp = temp.Substring(0, temp.Length - 4);
                        break;
                    }
                }
                this.Id = Convert.ToDouble(temp);
                return Convert.ToDouble(temp);
            }
            catch
            {
                Debug.Write(this.Id);
                MessageBox.Show("Item Not Found", "Error");
                return 2;
            }
        }
        #endregion
    }
}