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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void カスタマイズCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void オプションOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomizeForm Form = new CustomizeForm(this);
            Form.Show();
        }
        /// <summary>
        /// editorフォント変更メソッド
        /// </summary>
        /// <param name="Font"></param>
        public void ChangeFont(Font Font)
        {
            Rich_TextBox.Font = Font;
        }
    }
}
