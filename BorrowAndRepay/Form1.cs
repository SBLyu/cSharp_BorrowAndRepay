using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person i, f;


        public Form1()
        {
            InitializeComponent();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            i.borrow(f, 1000);
            updateMoney();
        }

        private void repayBtn_Click(object sender, EventArgs e)
        {
            i.repay(f, 1000);
            updateMoney();
        }

        private void updateMoney()
        {
            label6.Text = Convert.ToString(i.money);
            label10.Text = Convert.ToString(f.money);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            i = new Person(textBox1.Text, int.Parse(label6.Text));
            f = new Person(textBox2.Text, int.Parse(label10.Text));

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            submitBtn.Enabled = false;

            borrowBtn.Text = "跟 "+f.name+" 借款1000元";
            repayBtn.Text = "還款1000元，給 " + f.name;

            borrowBtn.Enabled = true;
            repayBtn.Enabled = true;

            label5.Text = i.name;
            label9.Text = f.name;
        }
    }
}
