using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class temperatura : Form
    {
        public temperatura()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double val1, res = 0;

            val1 = double.Parse(txt_Temp.Text);

            if (rdb_CpF.Checked) {
                res = (val1 * 9/5) + 32;
                txt_convert.Text = res.ToString();
            }
            else if (rdb_FpC.Checked) {
                res = (val1 - 32) * 5/9;
                txt_convert.Text = res.ToString();
            }
            else if (rdb_CpK.Checked) {
                res = val1 + 273.15;
                txt_convert.Text = res.ToString();
            }
            else if (rdb_KpC.Checked) {
                res = val1 - 273.15;
                txt_convert.Text = res.ToString();
            }
        }
    }
}
