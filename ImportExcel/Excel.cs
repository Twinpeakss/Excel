using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ImportExcel
{
    class Excel
    {      
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int sheet)
        {
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }


        public string[,] ReadRange(int startI, int startY, int endI, int endY)
        {
            Range range = (Range)ws.Range[ws.Cells[startI, startY], ws.Cells[endI, endY]];
            object[,] holder = range.Value2;
            string[,] returnString = new string[endI - startI , endY - startY];

            for (int p = 1; p <= endI - startI ; p++)
            {
                for (int q = 1; q <= endY - startY; q++)
                {
                    if (holder[p, q] == null)
                        continue;

                    else
                        returnString[p - 1, q - 1] = holder[p, q].ToString();


                }
            }

            return returnString;
        }


        public void Close() 
        {
            wb.Close();        
        }

    }
}
