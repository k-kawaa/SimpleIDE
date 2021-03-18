using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SimpleMDE
{
    public partial class MainForm : Form
    {
        private String path;

        public MainForm()
        {
            InitializeComponent();
            this.path = null;
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

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void 上書き保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            String link = e.LinkText;
            WebForm Form = new WebForm(link);
            Form.Show();
        }

        /// <summary>
        /// ファイルを開きます。
        /// </summary>
        private void open()
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filepath = openFileDialog.FileName;
                var FileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(FileStream))
                {
                    string fileContent = reader.ReadToEnd();
                    Rich_TextBox.Text = fileContent;
                }
                this.Text = "SimpleIDE" + "   " + filepath;
                this.path = filepath;
            }
        }

        /// <summary>
        /// エディタのフォントを変更します。
        /// </summary>
        /// <param name="Font"></param>
        public void ChangeFont(Font Font)
        {
            Rich_TextBox.Font = Font;
        }

        /// <summary>
        /// エディタの背景色を変更します。
        /// </summary>
        /// <param name="type"></param>
        public void ChangeEditorColor(int type)
        {
            switch (type)
            {
                case 1:
                    Rich_TextBox.BackColor = Color.Black;
                    break;
                case 2:
                    Rich_TextBox.BackColor = Color.White;
                    break;
                default:
                    MessageBox.Show("色が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /// <summary>
        /// ファイルを保存します。
        /// </summary>
        public void SaveFile()
        {
            String Filedata = Rich_TextBox.Text;
            using (StreamWriter writer = new StreamWriter(this.path))
            {
                writer.Write(Filedata);
            }
        }

    }
}
