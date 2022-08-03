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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Parent to child 3 qayda
            //Form melumat oturme qaydasi
            // 1.Send data by constructor

            //2.By property

            //3. ShowDialog

        }

       Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2(textBox1.Text);


            form2.Text = textBox1.Text;
            form2.Show();
            //var result=form2.ShowDialog();

            //if(result == DialogResult.OK)
            //{
            //    textBox1.Text = form2.DataForParent;
            //}
          // form2.Show();


            //var user = new User
            //{
            //    Name = "Elvin",
            //    Surname = "Camalzade",
            //    Id = 1
            //};


            //Form2 form = new Form2();



            //this.Hide();
            //DialogResult a = form.ShowDialog(user);
            //if (a == DialogResult.Cancel)
            //{
            //    this.Show();
            //}



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = form2.DataForParent;
        }
    }
}
