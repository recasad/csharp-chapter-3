using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateRev_Click(object sender, EventArgs e)
        {
            int Tickets = 25;
            int RevenueAmount;
            int Current;
            int Past;
            Current = Convert.ToInt32(CurrentContestants.Text);
            Past = Convert.ToInt32(PreviousContestants.Text);
            RevenueAmount = Current * Tickets;
            Revenue.Text = "Aproximatly " + RevenueAmount.ToString("c");

            if (Current > Past)
                MoreOrLess.Text = "The income this year will be larger than the last.";
            else if (Past > Current)
                MoreOrLess.Text = "The income this year will be less than the last.";
            else 
                MoreOrLess.Text = "The income will be equal to the last years";
        }
    }
}
