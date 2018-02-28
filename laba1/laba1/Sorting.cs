using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Sorting
    {public static void LiningSortNum(int n,int[]mas)
        { int i,k;
            for (i = 1; i < n - 1; i++)
            {
                if (mas[i - 1] > mas[i])
                {
                    k = mas[i - 1];
                    mas[i - 1] = mas[i];
                    mas[i] = k;
                }
            }
            for (i = 0; i < n - 1; i++)
            {
                object obj = mas[i];
               // Form1.listBox2.Items[1]=obj;
            }
        }
     public static void LiningSortNote(int n)
        { }
    }
}
