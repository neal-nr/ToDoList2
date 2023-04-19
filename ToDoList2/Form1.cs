using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList2
{
    public partial class Form1 : Form
    {
        List<string> todolist = new List<string>();
        List<string> completedlist = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //ADD
        {
            todolist.Add(textBox1.Text);
            richTextBox1.AppendText("• " + textBox1.Text + "\n");
            textBox1.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < todolist.Count; i++)
            {
                richTextBox1.AppendText(todolist[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // DELETE
        {
            completedlist.Add(textBox2.Text);
            todolist.Remove(textBox2.Text);
            richTextBox2.AppendText("• " + textBox2.Text + "\n");
            textBox2.Text = "";
            richTextBox1.Clear();
            for (int i = 0; i < todolist.Count; i++)
            {
                richTextBox1.AppendText("• " + todolist[i] + "\n");
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < completedlist.Count; i++)
            {
                richTextBox2.AppendText(completedlist[i]);
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
