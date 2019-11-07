using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApplication2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int num = 1;
            WebService1 ws = new WebService1();
            List<sport> sp = ws.HienThiMonTT();
            lvTT.Items.Clear();
            foreach (sport s in sp)
            {
                
                ListViewItem lvi = new ListViewItem("" + num);
                lvi.SubItems.Add(s.MaMonTT);
                lvi.SubItems.Add(s.TenMonTT);

                lvTT.Items.Add(lvi);
                num++;
            }

        }
    }
}
