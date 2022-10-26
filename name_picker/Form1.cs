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
            List<Bitmap> book = new List<Bitmap>();
            // book 프레임 이미지 생성
            {
                book.Add(new Bitmap(name_picker.Properties.Resources.book1));
                book.Add(new Bitmap(name_picker.Properties.Resources.book2));
                book.Add(new Bitmap(name_picker.Properties.Resources.book3));
                book.Add(new Bitmap(name_picker.Properties.Resources.book4));
                book.Add(new Bitmap(name_picker.Properties.Resources.book5));
                book.Add(new Bitmap(name_picker.Properties.Resources.book6));
                book.Add(new Bitmap(name_picker.Properties.Resources.book7));
                book.Add(new Bitmap(name_picker.Properties.Resources.book8));
                book.Add(new Bitmap(name_picker.Properties.Resources.book9));
                book.Add(new Bitmap(name_picker.Properties.Resources.book10));
                book.Add(new Bitmap(name_picker.Properties.Resources.book11));
                book.Add(new Bitmap(name_picker.Properties.Resources.book12));
                book.Add(new Bitmap(name_picker.Properties.Resources.book13));
                book.Add(new Bitmap(name_picker.Properties.Resources.book14));
                book.Add(new Bitmap(name_picker.Properties.Resources.book15));
                book.Add(new Bitmap(name_picker.Properties.Resources.book16));
                book.Add(new Bitmap(name_picker.Properties.Resources.book17));
                book.Add(new Bitmap(name_picker.Properties.Resources.book18));
                book.Add(new Bitmap(name_picker.Properties.Resources.book19));
                book.Add(new Bitmap(name_picker.Properties.Resources.book20));
                book.Add(new Bitmap(name_picker.Properties.Resources.book21));
                book.Add(new Bitmap(name_picker.Properties.Resources.book22));
                book.Add(new Bitmap(name_picker.Properties.Resources.book23));
                book.Add(new Bitmap(name_picker.Properties.Resources.book24));
                book.Add(new Bitmap(name_picker.Properties.Resources.book25));
                book.Add(new Bitmap(name_picker.Properties.Resources.book26));
                book.Add(new Bitmap(name_picker.Properties.Resources.book27));
                book.Add(new Bitmap(name_picker.Properties.Resources.book28));
                book.Add(new Bitmap(name_picker.Properties.Resources.book29));
                book.Add(new Bitmap(name_picker.Properties.Resources.book30));
                book.Add(new Bitmap(name_picker.Properties.Resources.book31));
                book.Add(new Bitmap(name_picker.Properties.Resources.book32));
                book.Add(new Bitmap(name_picker.Properties.Resources.book33));
                book.Add(new Bitmap(name_picker.Properties.Resources.book34));
                book.Add(new Bitmap(name_picker.Properties.Resources.book35));
                book.Add(new Bitmap(name_picker.Properties.Resources.book36));
                book.Add(new Bitmap(name_picker.Properties.Resources.book37));
                book.Add(new Bitmap(name_picker.Properties.Resources.book38));
                book.Add(new Bitmap(name_picker.Properties.Resources.book39));
                book.Add(new Bitmap(name_picker.Properties.Resources.book40));
                book.Add(new Bitmap(name_picker.Properties.Resources.book41));
            }
            
        }

        static void Animate_Image(PictureBox pic, List<Bitmap> frames, int ms)
        {
            for (int i = 0; i < frames.Count; i++)
            {
                pic.Image = frames[i];
                Delay(ms);
            }
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

        private void pic_book_Click(object sender, EventArgs e)
        {

        }
    }
}
