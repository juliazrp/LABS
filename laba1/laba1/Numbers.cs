using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba1
{
    class Numbers
    {
       public static int[] numMas = new int[10];
        public static void SortNum()
        {
            numMas[0] = 2; numMas[1] = 5; numMas[2] = 4;
            numMas[3] = 8; numMas[4] = 0; numMas[5] = 1; numMas[6] = -1;
            for (int i = 7; i < 26; i++)
            {
                numMas[i] = 0;
            }
        }
      /*  public bool LoadNums(string filename)
        {
            if (!File.Exists(filename))
            {
                System.Console.WriteLine("Ошибка при загрузке значений: файл отсутствует!");
                return false;
            }
            try
            {
                using (StreamReader reader = File.OpenText(filename))
                {for(int i=0;i<10;i++)
                    {   string text = reader.ReadLine();
                        string[] elems = text.Split('\n');
                        int temp = int.Parse(elems[0]);
                        numMas[i] = temp;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Ошибка при чтении описания сенсора!");
                System.Console.WriteLine(e);
                return false;
            }
        }
     /*   public static void LiningSortNum(int n)
        {
            int i, k;
            for (i = 1; i < n - 1; i++)
            {
                if (Numbers.numMas[i - 1] > mas[i])
                {
                    k = mas[i - 1];
                    mas[i - 1] = mas[i];
                    mas[i] = k;
                }
            }
        }*/
    }

}
