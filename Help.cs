using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurityProgram
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            var uri = new Uri(Application.StartupPath + "/qwe.htm");

            webBrowser1.Navigate(uri);
        }
    }
}
