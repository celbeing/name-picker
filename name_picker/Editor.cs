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
    public partial class editor : Form
    {
        string[] name_default = "인디스쿨 전라남도교육지원청".Split();
        string[] who_default = "고양이가 강아지가 거북이가 토끼가 뱀이 사자가 호랑이가 표범이 치타가 하이에나가 기린이 코끼리가 코뿔소가 하마가 악어가 펭귄이 부엉이가 올빼미가 곰이 돼지가 닭이 소가 독수리가 타조가 고릴라가 오랑우탄이 침팬지가 원숭이가 코알라가 캥거루가 고래가 상어가 칠면조가 직박구리가 쥐가 청설모가 메추라기가 앵무새가 삵이 스라소니가 판다가 오소리가 오리가 거위가 백조가 두루미가 고슴도치가 두더지가 우파루파가 맹꽁이가 너구리가 개구리가 두꺼비가 카멜레온이 이구아나가 노루가 제비가 까치가 고라니가 수달이 당나귀가 순록이 염소가 공작이 바다표범이 들소가 박쥐가 참새가 물개가 바다사자가 살모사가 구렁이가 얼룩말이 산양이 멧돼지가 카피바라가 바다코끼리가 도롱뇽이 북극곰이 퓨마가 미어캣이 코요테가 라마가 딱따구리가 기러기가 비둘기가 스컹크가 아르마딜로가 돌고래가 까마귀가 매가 낙타가 여우가 사슴이 늑대가 재규어가 알파카가 양이 다람쥐가 담비가".Split();
        string[] status_default = "".Split();

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
    }
}
