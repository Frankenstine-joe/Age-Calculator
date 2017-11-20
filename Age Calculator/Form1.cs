using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NodaTime;

namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        //DOB Statics
        public static int DYear { get; set; }
        public static int DMonths { get; set; }
        public static int DDays { get; set; }

        //NOW Statics
        public static int NYear { get; set; }
        public static int NMonths { get; set; }
        public static int NDays { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Setting starting today values

            NowDay.Value = DateTime.Now.Day;
            NowMonth.Value = DateTime.Now.Month;
            NowYear.Value = DateTime.Now.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Conversions from decimal to ints

            DYear = Convert.ToInt32(DobYear.Value);
            DMonths = Convert.ToInt32(DobMonths.Value);
            DDays = Convert.ToInt32(DobDays.Value);

            NYear = Convert.ToInt32(NowYear.Value);
            NMonths = Convert.ToInt32(NowMonth.Value);
            NDays = Convert.ToInt32(NowDay.Value);


            //JON SKEET NODATIME CODE

            LocalDate start = new LocalDate(DYear, DMonths, DDays);
            LocalDate end = new LocalDate(NYear, NMonths, NDays);
            Period period = Period.Between(start, end, PeriodUnits.Years | PeriodUnits.Months | PeriodUnits.Days);

            textBox1.Text = period.Years.ToString() + " Years " + period.Months + " Months " + period.Days + " Days ";
        }
    }
}
