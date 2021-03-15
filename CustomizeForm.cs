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
        public CustomizeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == Font_dialog.ShowDialog())
            {
                MainForm form = new MainForm();
                form.ChangeFont(Font_dialog.Font);
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
