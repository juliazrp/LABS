using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
namespace laba1
{
    public class Notes
    {
        struct Katalog
        {
            public string authorName;
            public int year;
            public string bookName;
            public int str;
            public Katalog(string authorName, int year, string bookName, int str)
            {
                this.authorName = authorName;
                this.year = year;
                this.bookName = bookName;
                this.str = str;
            }
        }
        public bool LoadStruct(string filename)
        {
            if (!File.Exists(filename))
            {
                System.Console.WriteLine("Ошибка при загрузке записей каталога: файл отсутствует!");
                return false;
            }
            List<Katalog> myList = new List<Katalog>();
            using (StreamReader reader = File.OpenText(filename))
            {
                while (!reader.EndOfStream)
                {
                    string text = reader.ReadLine();
                    string[] elems = text.Split(';');
                    string a = (elems[0]);
                    int y = int.Parse(elems[1]);
                    string b = (elems[2]);
                    int s = int.Parse(elems[3]);
                    myList.Add(new Katalog(a,y,b,s));
                }
            }
            return true;
        }
    }
}
