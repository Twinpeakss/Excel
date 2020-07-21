using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImportExcel
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;

        List<string> codes_to_delete = new List<string>();


        /// <summary>
        /// The ID(kod kreskowy) always the last parameter int the row (3).
        /// </summary>
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
                    commodity_list = ex.ReadRange(5, 7, 714, 11);
                    ex.Close();
                   
                    MessageBox.Show("Zaimportowano!");
                }

            }
        }


    



        /*public class Commodity
        {
            public string Nazwa { get; set; }
            public string Opis { get; set; }
            public string OpakowanieZbiorcze { get; set; }
            public int Id { get; set; }

            public override string ToString()
            {
                return Nazwa;
            }
        }*/


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
            int count = 0;
            for (int i = 0, j = 3; i < commodity_list.GetLength(0); i++)
            {
                if (codes_to_delete.Contains(commodity_list[i, j]))
                {
                    commodity_list[i, 0] = null;
                    commodity_list[i, 1] = null;
                    commodity_list[i, 2] = null;
                    commodity_list[i, 3] = null;
                    count++;
                }
            }

            MessageBox.Show("Usunięto obiektów z listy: " + count.ToString(),"Usuwanie z listy");
        }
    }
}
