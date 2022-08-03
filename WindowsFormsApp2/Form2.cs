using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        //public string Data { get; set; }
        //public Form2(string text)
        //{
        //    InitializeComponent();
        //    this.Data = text;  
        //    label1.Text = Data;
        //}


        private string text;

        public string Text
        {
            get { return text; }
            set { text = value;label1.Text = text; }
        }


        //public string Text { get; set;}
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Text;
        }


        public DialogResult ShowDialog(User user)
        {
            label1.Text = $"ID : {user.Id}  Name : {user.Name} Surname : {user.Surname}";
            return ShowDialog();
        }
        public string DataForParent { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.DialogResult= DialogResult.OK;
            DataForParent = textBox1.Text;
        }
    }
}
