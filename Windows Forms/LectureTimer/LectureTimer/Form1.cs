namespace LectureTimer
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (DateTime.Now.Minute > 45)
                lbTime.ForeColor = Color.Red;
            else
                lbTime.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = Screen.PrimaryScreen.WorkingArea.Width - Width - 10;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void lbTime_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            else
                this.FormBorderStyle = FormBorderStyle.None;
        }

        private void lbDate_Click(object sender, EventArgs e)
        {
            lbTime_Click(sender, e);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lbTime_Click(sender, e);
        }
    }
}
