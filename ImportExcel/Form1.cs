using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImportExcel
{
    /// <summary>
    /// 1. 9 pól(Linia, nazwa, kolor, ean, dł., szer. , wys. , pak., waga)
    /// 2. Możliwość usunięcia po indeksie 
    /// </summary>
    public partial class Form1 : Form
    {
        string filePath = string.Empty;

        List<string> codes_to_delete = new List<string>();

        string[,] Lnk;

        string[,] Ean = new string[999,0];

        List<Commodity>  products = new List<Commodity>();

        string[,] arr_products = new string[953,9];

        string[,] commodity_list;

        public Form1()
        {
            InitializeComponent();
        }

        
        //Import choosen file
        private void btnPick_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {           
                op.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                op.FilterIndex = 1;
                op.RestoreDirectory = true;

                if (op.ShowDialog() == DialogResult.OK)
                {
                    filePath = op.FileName;
                    txtBoxPath.Text = filePath;


                    Excel ex = new Excel(filePath,1);

                    Lnk = ex.ReadRange(5, 1, 958, 4);//gets the name, linia, kolor
                    
                    /////////////////////////
                    Ean = ex.ReadRange(5, 6, 958, 7);// gets the Ean
                    
                    //////////////////////////
                    commodity_list = ex.ReadRange(5, 8, 958, 13);// gets other parameters (waga,wymiary i t.d)

                    

                    for (int i = 0; i < commodity_list.GetLength(0); i++)
                    {
                        if (Ean[i, 0] != null && commodity_list[i, 0] != null && commodity_list[i, 1] != null &&
                            commodity_list[i, 2] != null && commodity_list[i, 3] != null && commodity_list[i, 4] != null &&
                            Lnk[i, 0] != null && Lnk[i, 1] != null && Lnk[i, 2] != null)
                        {
                            //products.Add(new Commodity(Lnk[i, 0], Lnk[i, 1], Lnk[i, 2], Ean[i, 0],
                            //    Int32.Parse(commodity_list[i, 0]), Int32.Parse(commodity_list[i, 1]),
                            //    Int32.Parse(commodity_list[i, 2]), Int32.Parse(commodity_list[i, 3]),
                            //    float.Parse(commodity_list[i, 4])));


                            arr_products[i, 0] = Lnk[i, 0];
                            arr_products[i, 1] = Lnk[i, 1];
                            arr_products[i, 2] = Lnk[i, 2];

                            arr_products[i, 3] = Ean[i, 0];

                            arr_products[i, 4] = commodity_list[i, 0];
                            arr_products[i, 5] = commodity_list[i, 1];
                            arr_products[i, 6] = commodity_list[i, 2];
                            arr_products[i, 7] = commodity_list[i, 3];
                            arr_products[i, 8] = commodity_list[i, 4];
                            
                        }
                        
                    }
                    
                 

                    ex.Close();                 
                    MessageBox.Show("Zaimportowano!");
                    DeleteNulls();
                }

            }
        }

        public void DeleteNulls() 
        {
            for (int i = 0; i < 943; i++)
            {
                if(arr_products[i, 0] != null)                         
                {
                    products.Add(new Commodity(arr_products[i, 0], arr_products[i, 1], arr_products[i, 2], arr_products[i, 3],
                        arr_products[i, 4], arr_products[i, 5],arr_products[i, 6], arr_products[i, 7],arr_products[i, 8]));

                }

            }


        }





        public class Commodity
        {         
            public string Linia { get; set; }

            public string Nazwa { get; set; }

            public string Kolor { get; set; }

            public string Ean { get; set; }

            public string Dlugosc { get; set; }

            public string Szerokosc { get; set; }

            public string Wysokosc { get; set; }

            public string Pakowanie { get; set; }

            public string Waga { get; set; }

            public Commodity(string linia, string nazwa, string kolor, string ean, 
                string dlugosc, string szerokosc, string wysokosc, string pakowanie, string waga) 
            {
                Linia = linia;
                Nazwa = nazwa;
                Kolor = kolor;
                Ean = ean;
                Dlugosc = dlugosc;
                Szerokosc = szerokosc;
                Wysokosc = wysokosc;
                Pakowanie = pakowanie;
                Waga = waga;
            }

            public override string ToString()
            {
                return Nazwa;
            }
        }


        ///Add EAN codes to deleting list
        private void button1_Click(object sender, EventArgs e)
        {
            var  code = String.Empty;
            if (!String.IsNullOrEmpty(txtbox_codeEAN.Text))
            {
                code = txtbox_codeEAN.Text;
                codes_to_delete.Add(code);
                ListBox.Items.Add(code);
            }
            else 
            {
                MessageBox.Show("Pole jest puste");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteObjectsFromCommodityList();
        }


        //Overrides objects in the commodity list to null values
        public void DeleteObjectsFromCommodityList() 
        {
            int counter = 0;
            foreach (var item in codes_to_delete)
            {
                products.RemoveAll(x => x.Ean == item);
                counter++;
            }
            MessageBox.Show("Usunięto obiektów z listy: " + counter.ToString(),"Usuwanie z listy");
        }
    }
}
