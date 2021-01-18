using ConsoleApp19;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static List<string> TodosLoad = new List<string>();
        public static List<string> TodosSave = new List<string>();
        private static List<string> dates = new List<string>();

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm tt";
            foreach (string line in Read.read())
            {
                TodosLoad.Add(line);
                checkedListBox1.Items.Add(Crypting.decrypt());
            }
            foreach (string line in File.ReadAllLines("dates.tds"))
            {
                dates.Add(line);
                listBox1.Items.Add(line);
            }
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (string line in File.ReadAllLines("dates.tds"))
            {
                string s1 = DateTime.Now.ToString();
                string s2 = line;
                if (s2 == s1)
                {
                    Console.WriteLine("Todo steht an");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; --i)
            {
                int[] indexes = checkedListBox1.CheckedIndices.Cast<int>().ToArray();
                int l;

                if (Int32.TryParse(string.Join("", indexes), out l))
                {
                    checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[i]);
                    dates.RemoveAt(l);
                    listBox1.Items.RemoveAt(l);
                    File.WriteAllLines("dates.tds", dates);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1) { }
            else
            {
                string NewEntry = textBox1.Text;
                checkedListBox1.Items.Add(NewEntry);
                DateTime date = dateTimePicker1.Value;
                date = date.AddSeconds(-date.Second);
                dates.Add(Convert.ToString(date));
                listBox1.Items.Add(date);
                File.WriteAllLines("dates.tds", dates);
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBox1.Items)
            {
                TodosSave.Add(item);
            }
            Crypting.encrypt();
            TodosSave.Clear();
        }
    }
}
