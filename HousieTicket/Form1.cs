using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousieTicket
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Generate_Click(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();

            List<Numbers> numbers = new List<Numbers>();
            Stack<int> TwinNumbers = new Stack<int>(UniqueRandomNoList(0, 7, 8));
            
            
            
            //////////////Step 1 ////////////////////
            
            ////////////First Col ////////////////////////
            Stack<int> FirstColNums = new Stack<int>(UniqueRandomNoList(1, 9, 9));
            
            for (int i = 0; i < 6; i++)
            {
                int j = UniqueRandomNoList(1, 3, 1,i).FirstOrDefault();
                Numbers n = new Numbers();
                n.col = 1;
                n.row = (i * 3) + j;
                n.value = FirstColNums.Pop();
                numbers.Add(n);
            }

            //////////// Second Col ///////////////////
           
            Stack<int> SecondColNums = new Stack<int>(UniqueRandomNoList(10, 19, 10,removeTwin: true));
        
            for (int i = 0; i < 6; i++)
            {
                int j = UniqueRandomNoList(1, 3, 1, i+1).FirstOrDefault();
                Numbers n = new Numbers();
                n.col = 2;
                n.row = (i * 3) + j;
               
                n.value = TwinNumbers.Peek() % 6 == i ? 11 : SecondColNums.Pop();


                numbers.Add(n);
            }
            TwinNumbers.Pop();
            ////////// Third Col ///////////////
            Stack<int> ThirdColNums = new Stack<int>(UniqueRandomNoList(20, 29, 10, 3,true));
            for (int i = 0; i < 6; i++)
            {
                bool rowNum = true;
                int j = 0 ;
                while (rowNum)
                {
                    j = UniqueRandomNoList(1, 3, 1, i + 631).FirstOrDefault();
                    int count = numbers.Where(num => num.row == (i * 3) + j && (num.col == 1 || num.col == 2)).ToList().Count;
                    if (count != 2)
                    {
                        rowNum = false;
                    }
                }
                Numbers n = new Numbers();
                n.col = 3;
                n.row = (i * 3) + j;
                n.value = TwinNumbers.Peek() % 6 == i ?  22 : ThirdColNums.Pop();
                numbers.Add(n);
            }
            TwinNumbers.Pop();
            //////// Fourth Column ///////////////
            Stack<int> FourthColNums = new Stack<int>(UniqueRandomNoList(30, 39, 10, 47,true));
            for (int i = 0; i < 6; i++)
            {
                bool rowNum = true;
                int j = 0;
                while (rowNum)
                {
                    j = UniqueRandomNoList(1, 3, 1, i + 274).FirstOrDefault();
                    int count = numbers.Where(num => num.row == (i * 3) + j && (num.col == 2 || num.col == 3)).ToList().Count;
                    if (count != 2)
                    {
                        rowNum = false;
                    }
                }
                Numbers n = new Numbers();
                n.col = 4;
                n.row = (i * 3) + j;
                n.value = TwinNumbers.Peek() % 6 == i ? 33 : FourthColNums.Pop();
                numbers.Add(n);
            }
            TwinNumbers.Pop();

            //////// Fifth Column ///////////////
            Stack<int> FifthColNums = new Stack<int>(UniqueRandomNoList(40, 49, 10, 5, true));
            for (int i = 0; i < 6; i++)
            {
                bool rowNum = true;
                int j = 0;
                while (rowNum)
                {
                    j = UniqueRandomNoList(1, 3, 1, i + 365).FirstOrDefault();
                    int count = numbers.Where(num => num.row == (i * 3) + j && (num.col == 3 || num.col == 4)).ToList().Count;
                    if (count != 2)
                    {
                        rowNum = false;
                    }
                }
                Numbers n = new Numbers();
                n.col = 5;
                n.row = (i * 3) + j;
                n.value = TwinNumbers.Peek() % 6 == i ? 44 : FifthColNums.Pop();
                numbers.Add(n);
            }
            TwinNumbers.Pop();


            //////// Sixth Column ///////////////
            Stack<int> SixthColNums = new Stack<int>(UniqueRandomNoList(50, 59, 10, 5, true));
            for (int i = 0; i < 6; i++)
            {
                bool rowNum = true;
                int j = 0;
                while (rowNum)
                {
                    j = UniqueRandomNoList(1, 3, 1, i + 3193).FirstOrDefault();
                    int count = numbers.Where(num => num.row == (i * 3) + j && (num.col == 4 || num.col == 5)).ToList().Count;
                    if (count != 2)
                    {
                        rowNum = false;
                    }
                }
                Numbers n = new Numbers();
                n.col = 6;
                n.row = (i * 3) + j;
                n.value = TwinNumbers.Peek() % 6 == i ? 55 : SixthColNums.Pop();
                numbers.Add(n);
            }
            TwinNumbers.Pop();


            //////// Seventh Column ///////////////
            Stack<int> SeventhColNums = new Stack<int>(UniqueRandomNoList(60, 69, 10, 45, true));
            for (int i = 0; i < 6; i++)
            {
                bool rowNum = true;
                int j = 0;
                while (rowNum)
                {
                    j = UniqueRandomNoList(1, 3, 1, i + 454).FirstOrDefault();
                    int count = numbers.Where(num => num.row == (i * 3) + j && (num.col == 5 || num.col == 6)).ToList().Count;
                    if (count != 2)
                    {
                        rowNum = false;
                    }
                }
                Numbers n = new Numbers();
                n.col = 7;
                n.row = (i * 3) + j;
                n.value = TwinNumbers.Peek() % 6 == i ? 66 : SeventhColNums.Pop();
                numbers.Add(n);
            }
            TwinNumbers.Pop();


            //////// Eighth Column ///////////////
            Stack<int> EighthColNums = new Stack<int>(UniqueRandomNoList(70, 79, 10, 75, true));
            for (int i = 0; i < 6; i++)
            {
                bool rowNum = true;
                int j = 0;
                while (rowNum)
                {
                    j = UniqueRandomNoList(1, 3, 1, i + 724).FirstOrDefault();
                    int count = numbers.Where(num => num.row == (i * 3) + j && (num.col == 6 || num.col == 7)).ToList().Count;
                    int count2 = numbers.Where(num => num.row == (i * 3) + j).ToList().Count;
                    if (count != 2 || count2 >=5)
                    {
                        rowNum = false;
                    }
                }
                Numbers n = new Numbers();
                n.col = 8;
                n.row = (i * 3) + j;
                n.value = TwinNumbers.Peek() % 6 == i ? 77 : EighthColNums.Pop();
                numbers.Add(n);
            }
            TwinNumbers.Pop();

            //////// Ninth Column ///////////////
            Stack<int> NinthColNums = new Stack<int>(UniqueRandomNoList(80, 90, 11, 755, true));
            for (int i = 0; i < 6; i++)
            {
                bool rowNum = true;
                int j = 0;
                while (rowNum)
                {
                    j = UniqueRandomNoList(1, 3, 1, i + 984).FirstOrDefault();
                    int count = numbers.Where(num => num.row == (i * 3) + j && (num.col == 7 || num.col == 8)).ToList().Count;
                    int count2 = numbers.Where(num => num.row == (i * 3) + j).ToList().Count;
                    if (count != 2 || count2 >= 5)
                    {
                        rowNum = false;
                    }
                }
                Numbers n = new Numbers();
                n.col = 9;
                n.row = (i * 3) + j;
                n.value = TwinNumbers.Peek() % 6 == i ? 88 : NinthColNums.Pop();
                numbers.Add(n);
            }
            TwinNumbers.Pop();


            Dictionary<int, int> AvailRows = new Dictionary<int, int>();
            for (int i = 1; i <= 9; i++)
            {
                AvailRows.Add(i, 0);
            }

            //////// Second Iteration ///////////////
            /// One in each three times/////
            for (int x = 0; x < 3; x++)
            {
                bool lastColOneExtra = false;
                for (int i = 1; i <= 9; i++)
                {
                    AvailRows[i]= 0;
                }

                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= 18; j++)
                    {
                        int count = numbers.Where(num => num.col == i && num.row == j).ToList().Count;
                        int count2 = numbers.Where(num => num.row == j && (num.col == i + 1 || num.col == i + 2)).ToList().Count;
                        int count3 = numbers.Where(num => num.row == j && (num.col == i + 1 || num.col == i - 1)).ToList().Count;
                        int count4 = numbers.Where(num => num.row == j && (num.col == i - 1 || num.col == i - 2)).ToList().Count;
                        int count5 = numbers.Where(num => num.row == j).ToList().Count;
                        if (count == 0 && count2 != 2 && count3 != 2 && count4 != 2 && count5 < 5)
                        {
                            AvailRows[i]++;
                        }
                    }
                }

                var sortedDict = from entry in AvailRows orderby entry.Value ascending select entry;

                foreach (var item in sortedDict)
                {
                    int i = item.Key;
                    bool rowNum = true;
                    int j = 0;
                    while (rowNum)
                    {
                        j = UniqueRandomNoList(1, 18, 1, i + j + 6557).FirstOrDefault();
                        int count = numbers.Where(num => num.col == i && num.row == j).ToList().Count;
                        int count2 = numbers.Where(num => num.row == j && (num.col == i + 1 || num.col == i + 2)).ToList().Count;
                        int count3 = numbers.Where(num => num.row == j && (num.col == i + 1 || num.col == i - 1)).ToList().Count;
                        int count4 = numbers.Where(num => num.row == j && (num.col == i - 1 || num.col == i - 2)).ToList().Count;
                        int count5 = numbers.Where(num => num.row == j).ToList().Count;
                        if (count == 0 && count2 != 2 && count3 != 2 && count4 != 2 && count5 < 5)
                        {
                            rowNum = false;
                        }
                    }

                    Numbers n = new Numbers();
                    n.col = i;
                    n.row = j;
                    switch (i)
                    {
                        case 1:
                            n.value = FirstColNums.Pop();
                            break;
                        case 2:
                            n.value = SecondColNums.Pop();
                            break;
                        case 3:
                            n.value = ThirdColNums.Pop();
                            break;
                        case 4:
                            n.value = FourthColNums.Pop();
                            break;
                        case 5:
                            n.value = FifthColNums.Pop();
                            break;
                        case 6:
                            n.value = SixthColNums.Pop();
                            break;
                        case 7:
                            n.value = SeventhColNums.Pop();
                            break;
                        case 8:
                            n.value = EighthColNums.Pop();
                            break;
                        case 9:
                            n.value = NinthColNums.Pop();
                            break;

                    }

                    numbers.Add(n);
                    
                    if(!lastColOneExtra && i == 9 && x == 2)
                    {
                        lastColOneExtra = true;
                        i--;
                    }
                }
            }

            List<Numbers> avail = new List<Numbers>();
            Dictionary<int, int> AvailRows2 = new Dictionary<int, int>();
            for (int i = 2; i <= 9; i++)
            {
                AvailRows2.Add(i, 0);
            }

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 18; j++)
                {
                    int count = numbers.Where(num => num.col == i && num.row == j).ToList().Count;
                    int count2 = numbers.Where(num => num.row == j && (num.col == i + 1 || num.col == i + 2)).ToList().Count;
                    int count3 = numbers.Where(num => num.row == j && (num.col == i + 1 || num.col == i - 1)).ToList().Count;
                    int count4 = numbers.Where(num => num.row == j && (num.col == i - 1 || num.col == i - 2)).ToList().Count;
                    int count5 = numbers.Where(num => num.row == j).ToList().Count;
                    if (count == 0 && count2 != 2 && count3 != 2 && count4 != 2 && count5 < 5)
                    {
                        Numbers n = new Numbers();
                        n.col = i;
                        n.row = j;
                        n.value = -1;
                        avail.Add(n);
                        AvailRows2[i]++;
                    }
                }
            }
            


            /////////// General ////////////////
            for (int i = 0; i < 9; i++)
            {
                dataTable.Columns.Add((i+1).ToString(), typeof(Int32));
            }
            for (int i = 0; i < 18; i++)
            {
                dataTable.Rows.Add(0,0,0,0,0,0,0,0,0);
            }

            
            dataGridView1.DataSource = dataTable;

            foreach (Numbers num in numbers)
            {
                dataTable.Rows[num.row -1][num.col-1] = num.value;
                dataGridView1.Rows[num.row -1 ].Cells[num.col -1].Style.BackColor = Color.Red;
            }
            foreach (Numbers num in avail)
            {
               
                dataGridView1.Rows[num.row - 1].Cells[num.col - 1].Style.BackColor = Color.Blue;
            }

            var lastRow = dataTable.NewRow();
            var lastRow2 = dataTable.NewRow();
            for (int i = 1; i <= 9; i++)
            {
                lastRow[i.ToString()] = AvailRows[i];
                if(i > 1)
                {
                    lastRow2[i.ToString()] = AvailRows2[i];
                }
                
            }
            dataTable.Rows.Add(lastRow);
            dataTable.Rows.Add(lastRow2);

            dataGridView1.Refresh();

        }


        public static bool RowColCheck(int Num, int req, List<Numbers> positions, bool isRow)
        {
            int count = isRow ? positions.Where(p => p.row == Num).ToList().Count : positions.Where(p => p.col == Num).ToList().Count ;
            
            if (count == req)
            {
                return true;
            }
            return false;
        }

        public static List<int> UniqueRandomNoList(int minRange, int maxRange, int totalRandomnoCount, int seed = 2, bool removeTwin = false)
        {
            
            List<int> noList = new List<int>();
            int count = 0;
            Random r = new Random(minRange+maxRange+DateTime.Now.Millisecond+seed*22);
            List<int> listRange = new List<int>();
            for (int i = 0; i < totalRandomnoCount; i++)
            {
                listRange.Add(i);
            }
            
            while (listRange.Count > 0)
            {
                int item = r.Next(minRange, maxRange+1);// listRange[];    
                if (!noList.Contains(item) && listRange.Count > 0)
                {
                    noList.Add(item);
                    listRange.Remove(count);
                    count++;
                }
            }
            if (removeTwin)
            {
                noList.Remove((minRange / 10) * 11);
            }
            return noList;
        }

        
    }
}
