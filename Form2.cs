using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form2 : Form
    {
        Color c = Color.White;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataBetweenForms.isClicked = false;
            dateTimePicker1.MinDate = DataBetweenForms.dateTime;
            dateTimePicker1.MaxDate = (new DateTime(DataBetweenForms.dateTime.Year, DataBetweenForms.dateTime.Month, 1)).AddMonths(1).AddDays(-1);
            
            if (SaveInformation.isAdmin == 0)
            {
                txtWorker.Text = SaveInformation.getName();
                txtWorker.Enabled = false;
            }
            else
            {
                txtWorker.Text = SaveInformation.getName();
                txtWorker.Enabled = true;
            }
                
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            DataBetweenForms.isClicked = true;
            if(c!=Color.White)
            {
                SaveInformation sI = new SaveInformation(txtWorker.Text, txtInformation.Text, c,dateTimePicker1.Value);
            }
            else
            {
                SaveInformation sI = new SaveInformation(txtWorker.Text, txtInformation.Text,dateTimePicker1.Value);
            }
            
            this.Close();
        }

        private void BtnGetColor(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            c = ctr.BackColor;
            

        }
        public void SetDateForDateTimePicker(int year, int month)
        {
            dateTimePicker1.MinDate = new DateTime(year, month, 1);
            dateTimePicker1.MaxDate = (new DateTime(year, month, 1)).AddMonths(1).AddDays(-1);
            Console.WriteLine(year + " " + month);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
