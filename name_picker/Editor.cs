using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace name_picker
{
    class CenterWinDialog : IDisposable
    {
        private int mTries = 0;
        private Form mOwner;
        public CenterWinDialog(Form owner)
        {
            mOwner = owner;
            owner.BeginInvoke(new MethodInvoker(findDialog));
        }
        private void findDialog()
        {
            // Enumerate windows to find the message box
            if (mTries < 0) return;
            EnumThreadWndProc callback = new EnumThreadWndProc(checkWindow);
            if (EnumThreadWindows(GetCurrentThreadId(), callback, IntPtr.Zero))
            {
                if (++mTries < 10) mOwner.BeginInvoke(new MethodInvoker(findDialog));
            }
        }

        private bool checkWindow(IntPtr hWnd, IntPtr lp)
        {
            // Checks if <hWnd> is a dialog
            StringBuilder sb = new StringBuilder(260);
            GetClassName(hWnd, sb, sb.Capacity);
            if (sb.ToString() != "#32770") return true;

            // Got it
            Rectangle frmRect = new Rectangle(mOwner.Location, mOwner.Size);
            RECT dlgRect;
            GetWindowRect(hWnd, out dlgRect);
            MoveWindow(hWnd,
                frmRect.Left + (frmRect.Width - dlgRect.Right + dlgRect.Left) / 2,
                frmRect.Top + (frmRect.Height - dlgRect.Bottom + dlgRect.Top) / 2,
                dlgRect.Right - dlgRect.Left,
                dlgRect.Bottom - dlgRect.Top, true);
            return false;
        }
        public void Dispose()
        {
            mTries = -1;
        }
        // P/Invoke declarations
        private delegate bool EnumThreadWndProc(IntPtr hWnd, IntPtr lp);
        [DllImport("user32.dll")]
        private static extern bool EnumThreadWindows(int tid, EnumThreadWndProc callback, IntPtr lp);
        [DllImport("kernel32.dll")]
        private static extern int GetCurrentThreadId();
        [DllImport("user32.dll")]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder buffer, int buflen);
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT rc);
        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int w, int h, bool repaint);
        private struct RECT { public int Left; public int Top; public int Right; public int Bottom; }
    }
    public partial class editor : Form
    {
        List<string> name = new List<string>();
        List<string> who = new List<string>();
        List<string> status = new List<string>();
        string[] name_default = "인디스쿨 전라남도교육지원청".Split();
        string[] who_default = "고양이가 강아지가 거북이가 토끼가 뱀이 사자가 호랑이가 표범이 치타가 하이에나가 기린이 코끼리가 코뿔소가 하마가 악어가 펭귄이 부엉이가 올빼미가 곰이 돼지가 닭이 소가 독수리가 타조가 고릴라가 오랑우탄이 침팬지가 원숭이가 코알라가 캥거루가 고래가 상어가 칠면조가 직박구리가 쥐가 청설모가 메추라기가 앵무새가 삵이 스라소니가 판다가 오소리가 오리가 거위가 백조가 두루미가 고슴도치가 두더지가 우파루파가 맹꽁이가 너구리가 개구리가 두꺼비가 카멜레온이 이구아나가 노루가 제비가 까치가 고라니가 수달이 당나귀가 순록이 염소가 공작이 바다표범이 들소가 박쥐가 참새가 물개가 바다사자가 살모사가 구렁이가 얼룩말이 산양이 멧돼지가 카피바라가 바다코끼리가 도롱뇽이 북극곰이 퓨마가 미어캣이 코요테가 라마가 딱따구리가 기러기가 비둘기가 스컹크가 아르마딜로가 돌고래가 까마귀가 매가 낙타가 여우가 사슴이 늑대가 재규어가 알파카가 양이 다람쥐가 담비가".Split();
        string[] status_default = "심심한,재미없는,감기 걸린,느려터진,눈이 침침한,기억을 잃은,잠자는,음치인,하품하는,잠이 덜 깬,생각이 너무 많은,달리기 할 줄 모르는,바빠서 시간이 없는,심심해서 죽을 것 같은,땀을 뻘뻘 흘리는,아무 생각이 없는,아무것도 모르는,추위에 떨고있는,눈가가 촉촉한,아침밥을 너무 많이 먹은,용돈이 다 떨어진,오늘 아침 굶은,엄마한테 혼난,왕자병 걸린,공주병 걸린,엄청 빠른,노래를 잘 부르는,말을 할 줄 아는,투명한,세상에서 제일 귀여운,지금 제일 잘 나가는,화성에 착륙한,달에 착륙한,하늘을 나는,모든 것을 다 아는,100만 구독자를 가진,에베레스트 정상에 오른,세계 최강의".Split(',');

        public editor()
        {
            InitializeComponent();
            

        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void Editor_Size_Changed(object sender, EventArgs e)
        {
            editor_tab.Size = new Size(this.Size.Width - 40, this.Size.Height - 63);
            textBox_name.Size = new Size(editor_tab.Size.Width - 24, editor_tab.Size.Height - 40);
            textBox_status.Size = new Size(editor_tab.Size.Width - 24, editor_tab.Size.Height - 40);
            textBox_who.Size = new Size(editor_tab.Size.Width - 24, editor_tab.Size.Height - 40);
        }

        private void button_initialize_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            foreach (string names in name_default)
            {
                textBox_name.Text += names;
                textBox_name.Text += Environment.NewLine;
            }
            
            textBox_status.Clear();
            foreach (string stats in status_default)
            {
                textBox_status.Text += stats;
                textBox_status.Text += Environment.NewLine;
            }

            textBox_who.Clear();
            foreach (string who in who_default)
            {
                textBox_who.Text += who;
                textBox_who.Text += Environment.NewLine;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (new CenterWinDialog(this))
            {
                DialogResult confirm = MessageBox.Show("저장하시겠습니까? 입력하신 정보를 기존 데이터에 덮어씁니다.", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirm == DialogResult.OK)
                {
                    // 파일 생성하고 저장
                    var newList = new StringBuilder();
                    
                    using (new CenterWinDialog(this))
                        MessageBox.Show("저장되었습니다.");
                    Close();
                }
                else
                {

                }
            }
        }
    }
}
