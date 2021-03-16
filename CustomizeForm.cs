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
    public partial class CustomizeForm : Form
    {
        private MainForm Form;

        public CustomizeForm(MainForm Form)
        {
            InitializeComponent();
            this.Form = Form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == Font_dialog.ShowDialog())
            {
                this.Form.ChangeFont(Font_dialog.Font);
                MessageBox.Show("フォントを適用しました。", "info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Font_dialog_Apply(object sender, EventArgs e)
        {

        }

        private void CustomizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
