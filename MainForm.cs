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
            this.path = null;
        }

        private void カスタマイズCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///TODO:DELETE THIS OPTION.
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
            if(this.path == null)
            {
                CreateFile();
            }
            else
            {
                SaveFile();
            }
        }

        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            String link = e.LinkText;
            WebForm Form = new WebForm(link);
            Form.Show();
        }

        private new void TextChanged(object sender, EventArgs e)
        {
            this.Text = "SimpleIDE" + "（未保存）" + this.path;
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
            if (this.path == null || Rich_TextBox.Text == null)
            {
                CreateFile();
                return;
            }
            String Filedata = Rich_TextBox.Text;
            using (StreamWriter writer = new StreamWriter(this.path))
            {
                writer.Write(Filedata);
                this.Text = "SimpleIDE" + "   " + this.path;
                Rich_TextBox.Modified = false;
            }
        }

        /// <summary>
        /// ファイルを新規作成します。
        /// </summary>
        public void CreateFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "ABP(*.abp)|*.abp" +
                "|ActionScript(*.as)|*.as" +
                "|C(*.c)|*.c" +
                "|C++(*.cpp)|*.cpp" +
                "|COBOL(*.cobol)|*.cobol" +
                "|CoffeeScript(*.coffee)|*.coffee" +
                "|C#(*.cs)|*.cs" +
                "|CSS(*.css)|*.css" +
                "|Clojure(*.clj)|*.clj" +
                "|D(*.d)|*.d" +
                "|Dart(*.dart)|*.dart" +
                "|Erlang(*.erl)|*.erl" +
                "|Forth(*.forth)|*.forth" +
                "|Go(*.go)|*.go" +
                "|Groovy(*.grooby)|*.groovy" +
                "|haskell(*.hs;*.lhs)|*.hs;*.lhs" +
                "|Haxe(*.hx)|*.hx" +
                "|HTML(*.html;*.htm)|*.html;*.htm" +
                "|XHTML(*.xhtml)|*.xhtml" +
                "|Java(*.java)|*.java" +
                "|JavaScript(*.js)|*.js" +
                "|jsx(*.jsx)|*.jsx" +
                "|Lisp(*lisp)|*.lisp" +
                "|LSL(*.lsl)|*.lsl" +
                "|Lua(*.lua)|*.lua" +
                "|MATLAB(*.mat)|*.mat" +
                "|SQL(*.sql)|*.sql" +
                "|Objective-C(*.m)|*.m" +
                "|OCaml(*.ocml)|*.ocml" +
                "|Pascal(*.pas)|*.pas" +
                "|Perl(*.pl)|*.pl" +
                "|PHP(*.php)|*.php" +
                "|Prolog(*.pro)|*.pro" +
                "|Python(*.py)|*.py" +
                "|R(*.r)|*.r" +
                "|Ruby(*.ruby)|*.rb" +
                "|Rust(*.rs)|*.rs" +
                "|Scala(*.scala)|*.scala" +
                "|Scheme(*.scm)|*.scm" +
                "|ShellScript(*.sh)|*.sh" +
                "|TypeScript(*.ts)|*.ts" +
                "|VBScript(*.vbs)|*.vbs" +
                "|Verilog(*.v)|*.v" +
                "|assembly_x86(*.asm)|*.asm" +
                "|XML(*.xml)|*.xml" +
                "|XQuery(*.xquery)|*.xquery";
            sfd.RestoreDirectory = true;
            sfd.Title = "保存先とファイル名を選択してください。";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var filepath = sfd.FileName;
                using (FileStream fs = File.Create(filepath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(Rich_TextBox.Text);
                    fs.Write(info, 0, info.Length);
                    this.Text = "SimpleIDE" + "   " + filepath;
                    this.path = filepath;
                }
            }
        }

    }
}
