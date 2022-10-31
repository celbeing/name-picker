
namespace name_picker
{
    partial class editor
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
            this.editor_tab = new System.Windows.Forms.TabControl();
            this.tab_name = new System.Windows.Forms.TabPage();
            this.tab_status = new System.Windows.Forms.TabPage();
            this.tab_who = new System.Windows.Forms.TabPage();
            this.editor_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // editor_tab
            // 
            this.editor_tab.Controls.Add(this.tab_name);
            this.editor_tab.Controls.Add(this.tab_status);
            this.editor_tab.Controls.Add(this.tab_who);
            this.editor_tab.Location = new System.Drawing.Point(12, 12);
            this.editor_tab.MinimumSize = new System.Drawing.Size(308, 266);
            this.editor_tab.Name = "editor_tab";
            this.editor_tab.SelectedIndex = 0;
            this.editor_tab.Size = new System.Drawing.Size(308, 266);
            this.editor_tab.TabIndex = 0;
            // 
            // tab_name
            // 
            this.tab_name.Location = new System.Drawing.Point(4, 22);
            this.tab_name.Name = "tab_name";
            this.tab_name.Padding = new System.Windows.Forms.Padding(3);
            this.tab_name.Size = new System.Drawing.Size(300, 240);
            this.tab_name.TabIndex = 0;
            this.tab_name.Text = "이름";
            this.tab_name.UseVisualStyleBackColor = true;
            // 
            // tab_status
            // 
            this.tab_status.Location = new System.Drawing.Point(4, 22);
            this.tab_status.Name = "tab_status";
            this.tab_status.Padding = new System.Windows.Forms.Padding(3);
            this.tab_status.Size = new System.Drawing.Size(425, 257);
            this.tab_status.TabIndex = 1;
            this.tab_status.Text = "수식어";
            this.tab_status.UseVisualStyleBackColor = true;
            // 
            // tab_who
            // 
            this.tab_who.Location = new System.Drawing.Point(4, 22);
            this.tab_who.Name = "tab_who";
            this.tab_who.Padding = new System.Windows.Forms.Padding(3);
            this.tab_who.Size = new System.Drawing.Size(425, 257);
            this.tab_who.TabIndex = 2;
            this.tab_who.Text = "누가";
            this.tab_who.UseVisualStyleBackColor = true;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 290);
            this.Controls.Add(this.editor_tab);
            this.MinimumSize = new System.Drawing.Size(348, 329);
            this.Name = "Editor";
            this.Text = "이름뽑기 편집기";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.editor_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.SizeChanged += new System.EventHandler(this.Editor_Size_Changed);
        }

        #endregion

        private System.Windows.Forms.TabControl editor_tab;
        private System.Windows.Forms.TabPage tab_name;
        private System.Windows.Forms.TabPage tab_status;
        private System.Windows.Forms.TabPage tab_who;
    }
}