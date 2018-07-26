using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OSMerch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private bool mousedown = false;
        private Point start;
        private int selected = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            pnlTop.Width = this.Width - pnlNavigation.Width;
            pnlTop.Left = pnlNavigation.Width;
            pnlRight.Left = this.Width - pnlRight.Width;
            pnlRight.Height = this.Height - pnlTop.Height;
            pnlBottom.Left = pnlNavigation.Width;
            pnlBottom.Width = this.Width - pnlNavigation.Width - pnlRight.Width;
            pnlBottom.Top = this.Height - pnlBottom.Height;
            
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            start = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.start.X, point.Y - this.start.Y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
