using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
namespace lab2
{
    public partial class Form1 : Form
    {
        struct Price
        {
            public string prodName;
            public string shopName;
            public int price;
            public Price(string prodName, string shopName, int price)
            {
                this.prodName = prodName;
                this.shopName = shopName;
                this.price = price;
            }
        }

        public Form1()
        {
            InitializeComponent();
            typeBox.Items.Add("Массив записей");
            typeBox.Items.Add("Массив чисел");
            qntBox.Items.Add("5");
            qntBox.Items.Add("10");
            qntBox.Items.Add("25");
            qntBox.Items.Add("100");
            qntBox.Items.Add("1000");
            qntBox.Items.Add("10000");
            sortBox.Items.Add("Прямое слияние");
            sortBox.Items.Add("Естественное слияние");
            sortBox.Items.Add("Сбалансированное двухпоточное слияние");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoForm f = new lab2.InfoForm();
            f.Hide();
            f.Show();
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void runBtn_Click(object sender, EventArgs e)
        {

            Stopwatch watch = new Stopwatch();
            int iSort, iMas, iNum;
            int i, k, n = 0;
            iSort = sortBox.SelectedIndex;
            iMas = typeBox.SelectedIndex;
            iNum = qntBox.SelectedIndex;
            if (iNum == 0) n = 5;
            if (iNum == 1) n = 10;
            if (iNum == 2) n = 25;
            if (iNum == 3) n = 100;
            if (iNum == 4) n = 1000;
            if (iNum == 5) n = 10000;
            dataGridView1.Rows[0].Cells[0].Value = sortBox.SelectedItem;
            dataGridView1.Rows[0].Cells[1].Value = typeBox.SelectedItem;
            dataGridView1.Rows[0].Cells[2].Value = qntBox.SelectedItem;
            if (iMas == 0)
            {//массив записей

                if (!File.Exists("C:\\USPTU\\тпр\\LABS\\lab2\\lab2\\bin\\Price.txt"))
                {
                    listBox1.Items.Add("Ошибка при загрузке записей каталога: файл отсутствует!");
                }
                Price[] st = new Price[n];
                using (StreamReader reader = File.OpenText("C:\\USPTU\\тпр\\LABS\\lab2\\lab2\\bin\\Price.txt"))
                {
                    for (i = 0; i < n; i++)
                    {
                        string text = reader.ReadLine();
                        string[] elems = text.Split(';');
                        string a = (elems[0]);
                        string b = (elems[1]);
                        int s = int.Parse(elems[2]);
                        st[i].prodName = a;
                        st[i].shopName = b;
                        st[i].price = s;
                        listBox1.Items.Add("_____");
                        int g = i + 1;
                        listBox1.Items.Add("№" + g);
                        listBox1.Items.Add(st[i].prodName);
                        listBox1.Items.Add(st[i].shopName);
                        listBox1.Items.Add(st[i].price);
                    }
                }
                using (StreamWriter p1 = new StreamWriter("C://USPTU//тпр//LABS//lab2//lab2//bin//p1.txt"))
                {
                    for (i = 0; i < n; i++)
                    {
                        p1.Write(st[i].prodName);
                        p1.Write(";");
                        p1.Write(st[i].shopName);
                        p1.Write(";");
                        p1.Write(st[i].price);
                        p1.Write(";");
                        p1.WriteLine();
                    }
                }

                using (StreamWriter p2 = new StreamWriter("C://USPTU//тпр//LABS//lab2//lab2//bin//p2.txt"))
                {
                    for (i = 0; i < n; i++)
                    {
                        p2.Write(st[i].prodName);
                        p2.Write(";");
                        p2.Write(st[i].shopName);
                        p2.Write(";");
                        p2.Write(st[i].price);
                        p2.Write(";");
                        p2.WriteLine();
                    }
                }
                if (iSort == 0)
                {//Прямое
                    watch.Start();
                    ////////////////////////////////////////////////
                    watch.Stop();
                    TimeSpan tSpan;
                    tSpan = watch.Elapsed;
                    dataGridView1.Rows[0].Cells[3].Value = tSpan.ToString();
                }
                if (iSort == 1)
                {//Естественное
                    watch.Start();
                    ///////////////////
                    watch.Stop();
                    TimeSpan tSpan;
                    tSpan = watch.Elapsed;
                    dataGridView1.Rows[0].Cells[3].Value = tSpan.ToString();
                }
                if (iSort == 2)
                {//Сбалансированное
                    watch.Start();
                    /////////////////
                    watch.Stop();
                    TimeSpan tSpan;
                    tSpan = watch.Elapsed;
                    dataGridView1.Rows[0].Cells[3].Value = tSpan.ToString();
                }

            }
            if (iMas == 1)
            {//массив чисел
                int[] numMas = new int[n];
                if (!File.Exists("...\\num2.txt"))
                {
                    listBox1.Items.Add("Ошибка при загрузке: файл c числами отсутствует!");
                }
                using (StreamReader reader1 = File.OpenText("...\\num2.txt"))
                {
                    for (i = 0; i < n; i++)
                    {
                        numMas[i] = Convert.ToInt32(reader1.ReadLine());
                    }
                }
                using (StreamWriter w1 = new StreamWriter("...\\n1.txt"))
                {
                    for (i = 0; i < n; i++)
                    {
                        w1.Write(numMas[i]);
                    }
                }
                using (StreamWriter w2 = new StreamWriter("...\\n2.txt"))
                {
                    for (i = 0; i < n; i++)
                    {
                        w2.WriteLine(numMas[i]);
                    }
                }
                listBox1.DataSource = numMas;
                if (iSort == 0)
                {//Прямое
                    int a1 = 0, a2 = 0, j = 0, kol, tmp, n1;
                    kol = n; k = 1;
                    watch.Start();
                    ////////////////////////////////////////////////////////
                    using (StreamReader r1 = File.OpenText("...\\n1.txt"))
                    using (StreamReader r2 = File.OpenText("...\\n2.txt"))
                    using (StreamWriter wr = new StreamWriter("C://USPTU//тпр//LABS//lab2//lab2//bin//num2.txt"))
                    {
                        {
                            {
                                if (r1.Peek() > -1)
                                {
                                    a1 = Convert.ToInt32(r1.ReadLine());
                                }
                                if (r2.Peek() > -1)
                                {
                                    a2 = Convert.ToInt32(r2.ReadLine());
                                  
                                }

                                while ((r1.Peek() > -1) && (r2.Peek() > -1))
                                {
                                    i = 0;
                                    j = 0;
                                    while (i < k && j < k && (r1.Peek() > -1) && (r2.Peek() > -1))
                                    {
                                        if (a1 < a2)
                                        {
                                            wr.WriteLine(Convert.ToString(a1));
                                            a1 = Convert.ToInt32(r1.ReadLine());
                                            i++;
                                        }
                                        else
                                        {
                                            wr.WriteLine(Convert.ToString(a2));
                                            a2 = Convert.ToInt32(r2.ReadLine());
                                            j++;
                                        }
                                    }
                                    while (i < k && (r1.Peek() > -1))
                                    {
                                        wr.WriteLine(Convert.ToString(a1));
                                        a1 = Convert.ToInt32(r1.ReadLine());
                                        i++;
                                    }
                                    while (j < k && (r2.Peek() > -1))
                                    {
                                         wr.WriteLine(Convert.ToString(a2));
                                            a2 = Convert.ToInt32(r2.ReadLine());
                                            j++;
                                    }
                                }
                                while (r1.Peek() > -1)
                                {
                                    wr.WriteLine(Convert.ToString(a1));
                                    a1 = Convert.ToInt32(r1.ReadLine());
                                }
                                while (r2.Peek() > -1)
                                {
                                    wr.WriteLine(Convert.ToString(a2));
                                    a2 = Convert.ToInt32(r2.ReadLine());
                                }

                                k *= 2;
                            }
                        }
                    }
                }
                        ////////////////////////////////////////////////////////
                        watch.Stop();
                        TimeSpan tSpan;
                        tSpan = watch.Elapsed;
                        dataGridView1.Rows[0].Cells[3].Value = tSpan.ToString();
                    }
                    if (iSort == 1)
                    {//Естественное
                /*Assembly a = Assembly.Load("C://USPTU//тпр//LABS//lab2//lab2//bin//s1.dll");
                Object o = a.CreateInstance("vscode");
                Type t = a.GetType("vscode");
                MethodInfo mi = t.GetMethod("SimpleMerSort");
                object[] paramaters = { "...//num2.txt"};
                mi.Invoke(o, paramaters);*/
                watch.Start();
                        ///////////////////////////////////////////
                        watch.Stop();
                        TimeSpan tSpan;
                        tSpan = watch.Elapsed;
                        dataGridView1.Rows[0].Cells[3].Value = tSpan.ToString();
                    }
                    if (iSort == 2)
                    { //Сбалансированное
                        watch.Start();
                        ////////////////////////////////////
                        watch.Stop();
                        TimeSpan tSpan;
                        tSpan = watch.Elapsed;
                        dataGridView1.Rows[0].Cells[3].Value = tSpan.ToString();
                    }
                    using (StreamWriter sw = new StreamWriter("outNumbers.txt", true, Encoding.UTF8))
                    {
                        for (i = 0; i < n; i++)
                        {
                          /*  sw.Write(numMas[i]);
                            sw.Write(";");
                            sw.WriteLine();*/
                        }
                    }
                    using (StreamReader reader2 = File.OpenText("outNumbers.txt"))
                    {
                        for (i = 0; i < n; i++)
                        {
                            /*string text = reader2.ReadLine();
                            string[] elems = text.Split(';');
                            listBox2.Items.Add(int.Parse(elems[0]));*/
                        }
                    }
                }
            }



        }
