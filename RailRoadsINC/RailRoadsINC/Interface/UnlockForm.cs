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
    public partial class UnlockForm : Form
    {
        public UnlockForm()
        {
            InitializeComponent();

        }
        private bool hashcheck(int hash)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + @"\Data\Configs\cfg.xml");
            var xml1 = xml.GetElementsByTagName("passwordhash");
            if (xml1[0].Attributes.GetNamedItem("hash").Value == "")
                return true;
            if (hash.ToString() == xml1[0].Attributes.GetNamedItem("hash").Value)
                return true;
            return false;
        }


        private void UnlockButton_Click(object sender, EventArgs e)
        {

            if (hashcheck(passwordBox.Text.GetHashCode()))
                this.Close();

        }
    }
}

