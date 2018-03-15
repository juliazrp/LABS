using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public class Part : IEquatable<Part>
        {
            public int age { get; set; }
            public string gen { get; set; }
            public string edu { get; set; }
            public int Id { get; set; }
            public string a1 { get; set; }
            public bool Equals(Part other)
            {
                if (other == null) return false;
                return (this.Id.Equals(other.Id));
            }
        }
        Part[] parts = new Part[5];
        int index = 1;
        RichTextBox dsc = new RichTextBox();
        public Form1()
        {

            parts[1] = (new Part() { age = 23, gen = "МУЖ", edu = "Начальное", a1 = "да", Id = index });
            parts[2] = (new Part() { age = 40, gen = "МУЖ", edu = "Высшее", a1 = "да", Id = index });
            parts[3] = (new Part() { age = 18, gen = "ЖЕН", edu = "Высшее", a1 = "нет", Id = index });
            parts[4] = (new Part() { age = 74, gen = "МУЖ", edu = "Высшее", a1 = "да", Id = index });

            InitializeComponent();
            genderBox.Items.Add("МУЖ");
            genderBox.Items.Add("ЖЕН");
            eduBox.Items.Add("Начальное");
            eduBox.Items.Add("Среднее");
            eduBox.Items.Add("Высшее");
            panel1.Controls.Add(dsc);
            dsc.Location = new Point(00, 50);
            dsc.Size = new Size(300, 100);
            dsc.Text="Пожалуйста, при заполнении возраста используйте только цифры, а на вопрос анкеты отвечайте только да или нет ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Label quest = new Label();
        TextBox ansBox = new TextBox();
        Button next = new Button();
        private void button1_Click(object sender, EventArgs e)
        { int temp = 0;
           
            panel1.Controls.Clear();
          
                double num = 0.0;
                if (double.TryParse(textBox1.Text, out num))
                {
                    int age = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    textBox1.Text = "error!";

                }
                if (textBox1.Text == "error!")
                { temp++; }
                else temp = 0;
           
            ansBox.Location = new Point(100, 55);
                quest.Size = new Size(300, 25);
                quest.Location = new Point(90, 25);
                ansBox.Size = new Size(100, 20);
                quest.Text = "Вы проживаете в России?";
                next.Location = new Point(100, 90);
                next.Size = new Size(100, 25);
                next.Text = "Ответить";
                next.Click += new EventHandler(next_Click);
                panel1.Controls.Add(quest);
                panel1.Controls.Add(ansBox);
                panel1.Controls.Add(next);
                    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int i = 0;
        Button f = new Button();
        Label l = new Label();
        ListBox lb1 = new ListBox();
        Button analize = new Button();
        private void next_Click(object sender, EventArgs e)
        { string a = ansBox.Text;
   parts[0] = (new Part() { age = Convert.ToInt32(textBox1.Text), gen = Convert.ToString(genderBox.SelectedItem), edu = Convert.ToString(eduBox.SelectedItem), a1 = a,  Id = index++ });
                panel1.Controls.Clear();
                panel1.Controls.Add(f);
                panel1.Controls.Add(l);
                l.Location = new Point(120, 55);
                f.Location = new Point(90, 91);
                f.Size = new Size(149, 25);
                l.Size = new Size(130, 20);
                f.Text = "Посмотреть все анкеты";
                l.Text = "Опрос окончен";
                f.Click += new EventHandler(f_Click);

        }
        private void f_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(lb1);
            panel1.Controls.Add(analize);
            lb1.Location = new Point(3, 0);
            analize.Size = new Size(100, 25);
            analize.Location = new Point(100, 180);
            analize.Text = "Анализ";
            analize.Click += new EventHandler(analize_Click);

            lb1.Size = new Size(299, 157);
            int k = 1;
            for (i = 0; i <= 4; i++)
            {
                lb1.Items.Add("№" + k);
                lb1.Items.Add(parts[i].age);
                lb1.Items.Add(parts[i].gen);
                lb1.Items.Add(parts[i].edu);
                lb1.Items.Add(parts[i].a1);
                lb1.Items.Add(" ");
                k++;
            }
        }
        private void analize_Click(object sender, EventArgs e)
        {
           analize.Visible=false;
            int q1=0, q2=0, q3=0;
            lb1.Items.Clear();
            for (i = 0; i < 5; i++)
            {if ((parts[i].age >= 40) && (parts[i].edu == "Высшее") && (parts[i].gen == "МУЖ") && ((parts[i].a1 == "да") || (parts[i].a1 == "Да") || (parts[i].a1 == "ДА")))
                    q1++;
                if ((parts[i].age < 30)&& (parts[i].edu == "Начальное") && (parts[i].gen == "ЖЕН") && ((parts[i].a1 == "нет") || (parts[i].a1 == "Нет") || (parts[i].a1 == "НЕТ")))
                    q2++;
                if ((parts[i].age < 24) && (parts[i].edu == "Начальное") && (parts[i].gen == "МУЖ") && ((parts[i].a1 == "да") || (parts[i].a1 == "Да") || (parts[i].a1 == "ДА")))
                    q3++;
                    }
            lb1.Items.Add(q1+ " мужчин старше 40 лет, имеющих высшее");
            lb1.Items.Add("образование, ответили ДА на вопрос анкеты");
            lb1.Items.Add("");
            lb1.Items.Add(q2 + " женщин моложе 30 лет, имеющих начальное");
            lb1.Items.Add("образование, ответили НЕТ на вопрос анкеты");
            lb1.Items.Add("");
            lb1.Items.Add(q3 + " мужчин моложе 24 лет, имеющих начальное");
            lb1.Items.Add("образование, ответили ДА на вопрос анкеты");

            lb1.Items.Add("");

        }
    }
}
