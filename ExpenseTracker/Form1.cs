using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.tb_income.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_rm.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_electric.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_hvi.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_water.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_ct.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_mr.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_pc.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_cs.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_parking.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_fuel.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_food.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_entertainment.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_sr.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_travel.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_gifts.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_other.TextChanged += new EventHandler(tb_total_TextChanged);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_total_TextChanged(object sender, EventArgs e)
        {
            this.tb_income.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_rm.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_electric.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_hvi.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_water.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_ct.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_mr.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_pc.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_cs.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_parking.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_fuel.TextChanged += new EventHandler(tb_total_TextChanged);
            this.tb_food.TextChanged += new EventHandler(tb_total_TextChanged);
            //this.tb_entertainment.TextChanged += new EventHandler(tb_total_TextChanged);
            //this.tb_sr.TextChanged += new EventHandler(tb_total_TextChanged);

            String A = tb_travel.Text;
            String B = tb_gifts.Text;
            String C = tb_other.Text;
            String D = tb_sr.Text;
            String E = tb_entertainment.Text;
            String F = tb_food.Text;
            String G = tb_fuel.Text;
            String H = tb_parking.Text;
            String I = tb_cs.Text;
            String J = tb_pc.Text;
            String K = tb_mr.Text;
            String L = tb_ct.Text;
            String M = tb_water.Text;
            String N = tb_hvi.Text;
            String O = tb_electric.Text;
            String P = tb_rm.Text;
            String Q = tb_income.Text;

            int AA = Int32.Parse(A);
            int BB = Int32.Parse(B);
            int CC = Int32.Parse(C);
            int DD = Int32.Parse(D);
            int EE = Int32.Parse(E);
            int FF = Int32.Parse(F);
            int GG = Int32.Parse(G);
            int HH = Int32.Parse(H);
            int II = Int32.Parse(I);
            int JJ = Int32.Parse(J);
            int KK = Int32.Parse(K);
            int LL = Int32.Parse(L);
            int MM = Int32.Parse(M);
            int NN = Int32.Parse(N);
            int OO = Int32.Parse(O);
            int PP = Int32.Parse(P);
            int QQ = Int32.Parse(Q);

            String AdditionTotal = (AA + BB + CC + DD + EE + FF + GG + HH + II + JJ + KK + LL + MM + NN + OO + PP + QQ).ToString();

            tb_total.Text = AdditionTotal;
        }

        private void tb_sr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
