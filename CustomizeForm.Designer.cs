
namespace SimpleMDE
{
    partial class CustomizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Setting_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Setting_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting_tab
            // 
            this.Setting_tab.Controls.Add(this.tabPage1);
            this.Setting_tab.Controls.Add(this.tabPage2);
            this.Setting_tab.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Setting_tab.Location = new System.Drawing.Point(13, 13);
            this.Setting_tab.Multiline = true;
            this.Setting_tab.Name = "Setting_tab";
            this.Setting_tab.SelectedIndex = 0;
            this.Setting_tab.Size = new System.Drawing.Size(775, 425);
            this.Setting_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "エディタ設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CustomizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Setting_tab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizeForm";
            this.Text = "設定画面";
            this.Setting_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Setting_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}