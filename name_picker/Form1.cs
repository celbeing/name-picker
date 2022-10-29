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
            pic_book.Image = name_picker.Properties.Resources.book;
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
        private void sizeChange(object sender, EventArgs e)
        {
            // pic_book size = 148*128
            pic_book.Location = new System.Drawing.Point((this.ClientSize.Width) / 2 - 74, this.ClientSize.Height-128);
        }

        private void pic_book_Click(object sender, EventArgs e)
        {

        }
    }
}
