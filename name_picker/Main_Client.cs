using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace name_picker
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            pic_book.Image = name_picker.Properties.Resources.book_x2_100ms;
            label_last.Parent = this;
        }
        static void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }
        private void Main_Client_Size_Changed(object sender, EventArgs e)
        {
            // pic_book size = 296*256
            pic_book.Location = new Point((this.ClientSize.Width) / 2 - 148, this.ClientSize.Height-256);
        }

        private void pic_book_Click(object sender, EventArgs e)
        {
            // 수식어, 이름 뽑기
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            editor editClient = new editor();
            editClient.ShowDialog();
        }
    }
}
