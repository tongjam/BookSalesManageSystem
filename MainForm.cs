using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//download by http://down.liehuo.net
namespace 书店零售系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookForm myBookForm = new BookForm();
            myBookForm.Show();
        }

        private void btnHuiyuan_Click(object sender, EventArgs e)
        {
            CustomerForm myCusotmerForm = new CustomerForm();
            myCusotmerForm.Show();
        }

        private void btnShouyin_Click(object sender, EventArgs e)
        {
            SellForm mySellForm = new SellForm();//5~1+a+s+p+x
            mySellForm.Show();
        }

        private void btnTongji_Click(object sender, EventArgs e)
        {
            ReportForm myReportForm = new ReportForm();
            myReportForm.Show();
        }
    }
}
