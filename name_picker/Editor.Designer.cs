
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.tab_status = new System.Windows.Forms.TabPage();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.tab_who = new System.Windows.Forms.TabPage();
            this.textBox_who = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_initialize = new System.Windows.Forms.Button();
            this.editor_tab.SuspendLayout();
            this.tab_name.SuspendLayout();
            this.tab_status.SuspendLayout();
            this.tab_who.SuspendLayout();
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
            this.tab_name.Controls.Add(this.textBox_name);
            this.tab_name.Location = new System.Drawing.Point(4, 22);
            this.tab_name.Name = "tab_name";
            this.tab_name.Padding = new System.Windows.Forms.Padding(3);
            this.tab_name.Size = new System.Drawing.Size(300, 240);
            this.tab_name.TabIndex = 0;
            this.tab_name.Text = "이름";
            this.tab_name.UseVisualStyleBackColor = true;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(7, 7);
            this.textBox_name.MinimumSize = new System.Drawing.Size(286, 226);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_name.Size = new System.Drawing.Size(286, 226);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.WordWrap = false;
            // 
            // tab_status
            // 
            this.tab_status.Controls.Add(this.textBox_status);
            this.tab_status.Location = new System.Drawing.Point(4, 22);
            this.tab_status.Name = "tab_status";
            this.tab_status.Padding = new System.Windows.Forms.Padding(3);
            this.tab_status.Size = new System.Drawing.Size(300, 240);
            this.tab_status.TabIndex = 1;
            this.tab_status.Text = "수식어";
            this.tab_status.UseVisualStyleBackColor = true;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(7, 7);
            this.textBox_status.MinimumSize = new System.Drawing.Size(286, 226);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_status.Size = new System.Drawing.Size(286, 226);
            this.textBox_status.TabIndex = 1;
            this.textBox_status.WordWrap = false;
            // 
            // tab_who
            // 
            this.tab_who.Controls.Add(this.textBox_who);
            this.tab_who.Location = new System.Drawing.Point(4, 22);
            this.tab_who.Name = "tab_who";
            this.tab_who.Padding = new System.Windows.Forms.Padding(3);
            this.tab_who.Size = new System.Drawing.Size(300, 240);
            this.tab_who.TabIndex = 2;
            this.tab_who.Text = "누가";
            this.tab_who.UseVisualStyleBackColor = true;
            // 
            // textBox_who
            // 
            this.textBox_who.Location = new System.Drawing.Point(7, 7);
            this.textBox_who.MinimumSize = new System.Drawing.Size(286, 226);
            this.textBox_who.Multiline = true;
            this.textBox_who.Name = "textBox_who";
            this.textBox_who.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_who.Size = new System.Drawing.Size(286, 226);
            this.textBox_who.TabIndex = 1;
            this.textBox_who.WordWrap = false;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(276, 10);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(41, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "저장";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(213, 10);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(61, 23);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "불러오기";
            this.button_load.UseVisualStyleBackColor = true;
            // 
            // button_initialize
            // 
            this.button_initialize.Location = new System.Drawing.Point(162, 10);
            this.button_initialize.Name = "button_initialize";
            this.button_initialize.Size = new System.Drawing.Size(49, 23);
            this.button_initialize.TabIndex = 3;
            this.button_initialize.Text = "초기화";
            this.button_initialize.UseVisualStyleBackColor = true;
            this.button_initialize.Click += new System.EventHandler(this.button_initialize_Click);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 290);
            this.Controls.Add(this.button_initialize);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.editor_tab);
            this.MinimumSize = new System.Drawing.Size(348, 329);
            this.Name = "editor";
            this.Text = "이름뽑기 편집기";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.SizeChanged += new System.EventHandler(this.Editor_Size_Changed);
            this.editor_tab.ResumeLayout(false);
            this.tab_name.ResumeLayout(false);
            this.tab_name.PerformLayout();
            this.tab_status.ResumeLayout(false);
            this.tab_status.PerformLayout();
            this.tab_who.ResumeLayout(false);
            this.tab_who.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl editor_tab;
        private System.Windows.Forms.TabPage tab_name;
        private System.Windows.Forms.TabPage tab_status;
        private System.Windows.Forms.TabPage tab_who;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.TextBox textBox_who;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_initialize;
    }
}