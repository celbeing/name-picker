﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_book
            // 
            this.pic_book.Location = new System.Drawing.Point(326, 322);
            this.pic_book.Margin = new System.Windows.Forms.Padding(0);
            this.pic_book.MaximumSize = new System.Drawing.Size(296, 256);
            this.pic_book.Name = "pic_book";
            this.pic_book.Size = new System.Drawing.Size(148, 128);
            this.pic_book.TabIndex = 0;
            this.pic_book.TabStop = false;
            this.pic_book.Click += new System.EventHandler(this.pic_book_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_book);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "main";
            this.Text = "이름뽑기";
            this.ClientSizeChanged += new System.EventHandler(this.sizeChange);
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_book;
    }
}

