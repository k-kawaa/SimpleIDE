using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMDE
{
    public partial class WebForm : Form
    {
        private String link;
        public WebForm(String link)
        {
            InitializeComponent();
            this.link = link;
            webView.Url = link;
        }

        private void WebForm_Load(object sender, EventArgs e)
        {

        }
    }
}
