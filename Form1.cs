namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totalRev_Click(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            { ClassAnum.Text = " "; ClassAnum.Refresh(); }
            { ClassBnum.Text = " "; ClassAnum.Refresh(); }
            { ClassCnum.Text = " "; ClassAnum.Refresh(); }

            { ClassArev.Text = " "; ClassArev.Refresh(); }
            { ClassBrev.Text = " "; ClassBnum.Refresh(); }
            { ClassCrev.Text = " "; ClassCnum.Refresh(); }

            { totalRev.Text = " "; totalRev.Refresh(); }
        }

        private void CalcRevbtn_Click(object sender, EventArgs e)
        {
            int numa = int.Parse(ClassAnum.Text);
            int numb = int.Parse(ClassBnum.Text);
            int numc = int.Parse(ClassCnum.Text);
            ClassArev.Text = (numa * 15).ToString() + '$';
            ClassBrev.Text = (numb * 12).ToString() + '$';
            ClassCrev.Text = (numc * 9).ToString() + '$';

            totalRev.Text = ((numa *15) + (numb *12) + (numc*9)).ToString() + '$';
        }
    }
}
