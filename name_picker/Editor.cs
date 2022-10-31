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
        }
    }
}
