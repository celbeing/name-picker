
namespace name_picker
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_book = new System.Windows.Forms.PictureBox();
            this.label_who = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_finding = new System.Windows.Forms.Label();
            this.label_whois = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_last = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_book
            // 
            this.pic_book.Location = new System.Drawing.Point(252, 194);
            this.pic_book.Margin = new System.Windows.Forms.Padding(0);
            this.pic_book.MaximumSize = new System.Drawing.Size(296, 256);
            this.pic_book.MinimumSize = new System.Drawing.Size(296, 256);
            this.pic_book.Name = "pic_book";
            this.pic_book.Size = new System.Drawing.Size(296, 256);
            this.pic_book.TabIndex = 0;
            this.pic_book.TabStop = false;
            this.pic_book.Click += new System.EventHandler(this.pic_book_Click);
            // 
            // label_who
            // 
            this.label_who.AutoSize = true;
            this.label_who.Font = new System.Drawing.Font("DOSMyungjo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_who.Location = new System.Drawing.Point(247, 87);
            this.label_who.Name = "label_who";
            this.label_who.Size = new System.Drawing.Size(162, 27);
            this.label_who.TabIndex = 1;
            this.label_who.Text = "누군가가...";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("DOSMyungjo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_status.Location = new System.Drawing.Point(248, 49);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(80, 21);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "어떤...";
            // 
            // label_finding
            // 
            this.label_finding.AutoSize = true;
            this.label_finding.Font = new System.Drawing.Font("DOSMyungjo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_finding.Location = new System.Drawing.Point(248, 132);
            this.label_finding.Name = "label_finding";
            this.label_finding.Size = new System.Drawing.Size(250, 21);
            this.label_finding.TabIndex = 3;
            this.label_finding.Text = "누군가를 찾고있습니다...";
            // 
            // label_whois
            // 
            this.label_whois.AutoSize = true;
            this.label_whois.Font = new System.Drawing.Font("DOSMyungjo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_whois.Location = new System.Drawing.Point(247, 167);
            this.label_whois.Name = "label_whois";
            this.label_whois.Size = new System.Drawing.Size(176, 27);
            this.label_whois.TabIndex = 4;
            this.label_whois.Text = "그는 바로...";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("DOSMyungjo", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(278, 219);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(97, 40);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "이름";
            // 
            // label_last
            // 
            this.label_last.AutoSize = true;
            this.label_last.BackColor = System.Drawing.Color.Transparent;
            this.label_last.Font = new System.Drawing.Font("DOSMyungjo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_last.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_last.Location = new System.Drawing.Point(347, 270);
            this.label_last.Name = "label_last";
            this.label_last.Size = new System.Drawing.Size(161, 27);
            this.label_last.TabIndex = 6;
            this.label_last.Text = "마지막 이름";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(13, 415);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = "edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label_last);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_whois);
            this.Controls.Add(this.label_finding);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_who);
            this.Controls.Add(this.pic_book);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "main";
            this.Text = "이름뽑기";
            this.ClientSizeChanged += new System.EventHandler(this.Main_Client_Size_Changed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_book;
        private System.Windows.Forms.Label label_who;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_finding;
        private System.Windows.Forms.Label label_whois;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_last;
        private System.Windows.Forms.Button button_edit;
    }
}

