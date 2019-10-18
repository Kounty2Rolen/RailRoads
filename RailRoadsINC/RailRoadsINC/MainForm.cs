using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace RailRoadsINC
{
    public partial class MainForm : Form
    {
        internal string connectionstring;
        internal SqlConnection sqlC = new SqlConnection();
        internal SqlDataAdapter sqlA;
        internal DataSet sqlS;
        public MainForm()
        {
            InitializeComponent();


            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + @"\Data\Configs\cfg.xml");
            var xml1 = xml.GetElementsByTagName("path");
            if (xml1[0].Attributes["path"].Value != "")
                dataGridView1.DataSource = dbload(xml1[0].Attributes["path"].Value.ToString(), "Tickets").Tables[0].DefaultView;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Interface.AdminPanel admin = new Interface.AdminPanel();
            Interface.UnlockForm unlock = new Interface.UnlockForm();
            unlock.ShowDialog();
            admin.ShowDialog();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            LOCKBOX.Dock = DockStyle.Fill;
            LOCKBOX.Visible = true;
            Interface.UnlockForm unlock = new Interface.UnlockForm();
            unlock.ShowDialog();
            LOCKBOX.Visible = false;
        }

        private DataSet dbload(string path, string table)
        {
            connectionstring = $@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {Application.StartupPath}{path}; Integrated Security = True";
            sqlC = new SqlConnection(connectionstring);
            sqlC.Open();
            sqlA = new SqlDataAdapter($"Select * from {table}", connectionstring);
            sqlS = new DataSet();
            sqlA.Fill(sqlS, table);
            return sqlS;
        }

        static internal bool addReg(in SqlConnection sqlC, Dictionary<string, string> user)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + @"\Data\Configs\cfg.xml");
            var xml1 = xml.GetElementsByTagName("ThisCity");
            var sqlCom = sqlC.CreateCommand();
            sqlCom.CommandText = $"insert into Tickets values({user["Train"]},{user["Passport"]},'{user["FIO"]}',{user["SeatNumber"]});";
            sqlCom.ExecuteNonQuery();
            return true;
        }
        private void RegButton_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + @"\Data\Configs\cfg.xml");
            var xml1 = xml.GetElementsByTagName("path");
            DataSet sqls = null;
            if (xml1[0].Attributes["path"].Value != "")
                sqls = dbload(xml1[0].Attributes["path"].Value, "Train");
            Interface.RegTickets regTickets = new Interface.RegTickets(ref sqls, in sqlC);
            regTickets.ShowDialog();


        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + @"\Data\Configs\cfg.xml");
            var xml1 = xml.GetElementsByTagName("path");
            if (xml1[0].Attributes["path"].Value != "")
                dataGridView1.DataSource = dbload(xml1[0].Attributes["path"].Value.ToString(), "Tickets").Tables[0].DefaultView;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var delCommand = sqlC.CreateCommand();
            delCommand.CommandText = $"delete from Tickets where id={dataGridView1.SelectedRows[0].Cells[0].Value}";
            delCommand.ExecuteNonQuery();
            ButtonRefresh_Click(this,e);
        }
    }
}
