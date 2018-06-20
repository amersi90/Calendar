using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        //Connection string to database
        private readonly string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                           @"C:\Users\isrema\Documents\Development\Visual Studio\Windows Forms Applications\Calendar\Calendar\Calendar.mdf;" +
                            "Integrated Security = True";

        string user = "user";

        int isAdmin = 0;
        int month;
        int selectedYear = DateTime.Now.Year;

        ToolStripItem toolStripItem;
        ContextMenuStrip contextMenuStrip;
        Control sourceControl;
        DateTime selectedDate = DateTime.Now;
        List<Panel> panelList = new List<Panel>();

        
        //Removes flickering problem (www.stackoverflow.com/questions/2612487/how-to-fix-the-flickering-in-user-controls)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public Form1()
        {
            
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tableLayoutPanel1.Controls.Clear();
            lblSelectedMonth.Text = DateTime.Now.ToString("MMM");
            month = Convert.ToInt32(DateTime.Now.ToString("MM"));
           
            lblSelectedYear.Text = selectedYear.ToString();
            MonthView(selectedYear, Convert.ToInt32(selectedDate.Date.ToString("MM")));
            InsertDataFromDB(conString);
        }

        

        List<SaveDataBaseInformation> SaveInfoFromCalenderTable(string connectionString, string username, int year, int month)
        {

            List<SaveDataBaseInformation> listOfDataBaseInformation = new List<SaveDataBaseInformation>();
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Calendar WHERE Bruker='"+username+"' AND Aar="+year+" And Mnd="+month+";", cnn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    listOfDataBaseInformation.Add(new SaveDataBaseInformation((int)reader["Aar"], (int)reader["Mnd"], (int)reader["Dag"],
                               (string)reader["Bruker"], (string)reader["Beskrivelse"], (string)reader["Farge"], (int)reader["AdminP"]));
                }
            }
            cnn.Close();
            return listOfDataBaseInformation;

        }

        public void InsertDataFromDB(string connectionString)
        {
            List<SaveDataBaseInformation> listOfDataBaseInformation = SaveInfoFromCalenderTable(conString,user,selectedYear,month);

            foreach (var c in listOfDataBaseInformation)
            {
                Button but = new Button();
                but.MouseEnter += new EventHandler(MouseHoverToolTip);
                but.ContextMenuStrip = ContextMenuForNonEmptyBoxes();
                but.Text = c.description;
                but.BackColor = Color.FromName(c.color);
                but.Location = new Point(0, Convert.ToInt32(tableLayoutPanel1.Controls[Convert.ToString(c.day)].Height * 0.25));
                but.Width = tableLayoutPanel1.Controls[Convert.ToString(c.day)].Width;
                but.Height = tableLayoutPanel1.Controls[Convert.ToString(c.day)].Height / 2;
                
                
                tableLayoutPanel1.Controls[Convert.ToString(c.day)].Controls.Add(but);

            }
        }

        void MouseHoverToolTip(Object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Control ctr = (Control)sender;

            toolTip1.SetToolTip(ctr, ctr.Text);
        }
        public void MonthView(int year, int month)
        {
            
            tableLayoutPanel1.Controls.Add(new Label() { Text = DayOfWeek.Monday.ToString() }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = DayOfWeek.Tuesday.ToString() }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = DayOfWeek.Wednesday.ToString() }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = DayOfWeek.Thursday.ToString() }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = DayOfWeek.Friday.ToString() }, 4, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = DayOfWeek.Saturday.ToString() }, 5, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = DayOfWeek.Sunday.ToString() }, 6, 0);

            CalendarClass cL = new CalendarClass(year, month);
            List<DateTime> dT = cL.GetDaysForMonth();
            bool startDay = true;
            int i = 0;
            int j = 1;
            foreach (var v in dT)
            {
               
                DayOfWeek day = v.Date.DayOfWeek;
                
                if (startDay)
                {
                    
                    switch (day)
                    {
                        case DayOfWeek.Monday:
                            i = 0;
                            break;
                        case DayOfWeek.Tuesday:
                            i = 1;
                            break;
                        case DayOfWeek.Wednesday:
                            i = 2;
                            break;
                        case DayOfWeek.Thursday:
                            i = 3;
                            break;
                        case DayOfWeek.Friday:
                            i = 4;
                            break;
                        case DayOfWeek.Saturday:
                            i = 5;
                            break;
                        case DayOfWeek.Sunday:
                            i = 6;
                            break;

                    }
                    startDay = false;
                }
                if (i > 6)
                {
                    j++;
                    i = 0;
                }
                Panel p = new Panel();
                p.Controls.Add(new Label() { Text = v.Date.ToString("dd")});
                
                p.Name = v.Date.ToString("%d");
                p.Size = tableLayoutPanel1.Size;

                if ((Convert.ToInt32(p.Name) < Convert.ToInt32(DateTime.Now.Date.ToString("%d")) && ((month <= Convert.ToInt32(DateTime.Now.Date.ToString("MM"))) && (selectedYear <= DateTime.Now.Year)))
                                        || (((month < Convert.ToInt32(DateTime.Now.Date.ToString("MM"))) && (selectedYear <= DateTime.Now.Year))) 
                                        || (selectedYear < DateTime.Now.Year))
                {
                    p.BorderStyle = BorderStyle.None;
                    p.BackColor = Color.Gray;
                }
                    
                else
                {
                    p.ContextMenuStrip = ContextMenuForEmptyBoxes();
                    p.BackColor = Color.LightGray;
                }
                tableLayoutPanel1.Controls.Add(p, i, j);
                i++;
                
            }
            

        }
        private void YearAndMonthControl(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            tableLayoutPanel1.Controls.Clear();
            switch(ctr.Name)
            {
                case "btnPrevYear":
                    selectedYear -= 1;
                    lblSelectedYear.Text = selectedYear.ToString();
                    break;
                case "btnNextYear":
                    selectedYear += 1;
                    lblSelectedYear.Text = selectedYear.ToString();
                    break;
                case "btnPrevMonth":
                    selectedDate = selectedDate.AddMonths(-1);
                    lblSelectedMonth.Text = selectedDate.Date.ToString("MMM");
                    month = Convert.ToInt32(selectedDate.Date.ToString("MM"));
                    break;
                case "btnNextMonth":
                    selectedDate = selectedDate.AddMonths(1);
                    lblSelectedMonth.Text = selectedDate.Date.ToString("MMM");
                    month = Convert.ToInt32(selectedDate.Date.ToString("MM"));
                    break;
                default:
                    break;
            }
            
            MonthView(selectedYear, Convert.ToInt32(selectedDate.ToString("MM")));
            InsertDataFromDB(conString);

        }

        public ContextMenuStrip ContextMenuForEmptyBoxes()
        {
            
            ContextMenuStrip cm = new ContextMenuStrip();
            
            cm.Items.Add("Add event");
            cm.ItemClicked += new ToolStripItemClickedEventHandler(ContextMenuForEmptyBoxes_ItemClicked);
           
            return cm;

        }
        void ContextMenuForEmptyBoxes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            new SaveInformation(user);
            toolStripItem = e.ClickedItem;
            contextMenuStrip = toolStripItem.Owner as ContextMenuStrip;
            if (contextMenuStrip != null)
                sourceControl = contextMenuStrip.SourceControl;

            DataBetweenForms.dateTime = new DateTime(selectedYear, month, Convert.ToInt32(sourceControl.Name));
            Form f2 = new Form2();
            f2.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            f2.Show();
            

        }
        
        public ContextMenuStrip ContextMenuForNonEmptyBoxes()
        {
            ContextMenuStrip cm = new ContextMenuStrip();
            cm.Items.Add("Remove event");
            cm.ItemClicked += new ToolStripItemClickedEventHandler(ContextMenuForNonEmptyBoxes_buttonClicked);
            return cm;
        }
        void ContextMenuForNonEmptyBoxes_buttonClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            ContextMenuStrip cms = item.Owner as ContextMenuStrip;
            if (cms != null)
            {
               
                Control c = cms.SourceControl;
                
                if (c is Button)
                {
                   
                    sourceControl = cms.SourceControl.Parent;
                    sourceControl.Controls.Remove(c);
                    DeleteEntrysFromDatabase(conString, user, sourceControl.Name);

                    tableLayoutPanel1.Controls.Clear();
                    MonthView(selectedYear, Convert.ToInt32(selectedDate.Date.ToString("MM")));
                    InsertDataFromDB(conString);
                }
            }

        }
        
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(DataBetweenForms.isClicked)
                ExecuteTest();
        }
        void ExecuteTest()
        {
            int day = Convert.ToInt32(sourceControl.Name);
            
            int endDate = Convert.ToInt32(SaveInformation.getEndDate().Date.ToString("%d"));
            for (int i = day; i <= endDate; i++)
            {
                InsertIntoCalendarTable(conString, new SaveDataBaseInformation(selectedYear, month, i, SaveInformation.getName(),
                SaveInformation.getInfo(), SaveInformation.getColor().ToKnownColor().ToString(), isAdmin));

            }

            tableLayoutPanel1.Controls.Clear();
            MonthView(selectedYear, Convert.ToInt32(selectedDate.Date.ToString("MM")));
            InsertDataFromDB(conString);
        }

        public void InsertIntoCalendarTable(string connectionString, SaveDataBaseInformation info)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("INSERT INTO Calendar(Aar,Mnd,Dag,Bruker,Beskrivelse,Farge,AdminP) " +
                      "VALUES(" + info.year + "," + info.month + "," + info.day + ",'" + info.user + "','" + info.description + "','" + info.color + "'," + info.adminPri + ");", cnn);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        public void DeleteEntrysFromDatabase(string connectionString, string user, string day)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd;
            try
            {
                if(isAdmin==0)
                    cmd = new SqlCommand("DELETE FROM Calendar WHERE Bruker='" + user + "' AND Dag=" + Convert.ToInt32(day) + " AND Mnd=" +
                                      month + " AND Aar=" + selectedYear + " AND AdminP=0;", cnn);
                else
                    cmd = new SqlCommand("DELETE FROM Calendar WHERE Bruker='" + user + "' AND Dag=" + Convert.ToInt32(day) + " AND Mnd=" +
                                      month + " AND Aar=" + selectedYear + ";", cnn);
                cnn.Open();
                int i=cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("Need admin privileges");
                }
                    
                
                cmd.Dispose();
                cnn.Close();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        private void BtnSelectUser_Click(object sender, EventArgs e)
        {
            isAdmin = 0;
            if (chkBoxAdmin.Checked)
                isAdmin = 1;
            user = txtUsername.Text;
            tableLayoutPanel1.Controls.Clear();
            MonthView(selectedYear, Convert.ToInt32(selectedDate.Date.ToString("MM")));
            InsertDataFromDB(conString);
            SaveInformation.isAdmin = isAdmin;

        }
    }
}
