using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cemu_Graphic_Pack_Generator.UI
{
    public partial class TitleIDControl : UserControl
    {
        public event FormClosingEventHandler Closing;

        public string TitleID { get; set; }

        public TitleIDControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TitleID = textBox1.Text;
            Closing?.Invoke(this, new FormClosingEventArgs(CloseReason.ApplicationExitCall, false));
        }
    }
}
