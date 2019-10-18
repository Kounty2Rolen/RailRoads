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


namespace RailRoadsINC.Interface
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + @"\Data\Configs\cfg.xml");
            var xml1 = xml.GetElementsByTagName("passwordhash");
            if (textBox1.Text != null)
            {
                xml1[0].Attributes["hash"].Value = textBox1.Text.GetHashCode().ToString();

            }
            xml.Save(Application.StartupPath + @"\Data\Configs\cfg.xml");

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Contains(".mdf"))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(Application.StartupPath + @"\Data\Configs\cfg.xml");
                var xml1 = xml.GetElementsByTagName("path");
                xml1[0].Attributes["path"].Value = openFileDialog1.FileName.ToString();
                xml.Save(Application.StartupPath + @"\Data\Configs\cfg.xml");

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + @"\Data\Configs\cfg.xml");
            var xml1 = xml.GetElementsByTagName("passwordhash");
            if (textBox3.Text != null)
            {
                xml1[0].Attributes["hash"].Value = textBox1.Text.GetHashCode().ToString();

            }
            xml.Save(Application.StartupPath + @"\Data\Configs\cfg.xml");
        }
    }
}
