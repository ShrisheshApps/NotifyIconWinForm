using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIconWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ShowNotifyIcon();
        }

        private void ShowNotifyIcon()
        {
            notifyIcon1.Visible = true;
            //other properties are set in properties pane
            notifyIcon1.ShowBalloonTip(1000);
        }
    }
}
