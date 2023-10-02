namespace bobuxgenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = "Your Bobux Code is: " + rnd.Next(10000, 99999).ToString() + '-' + rnd.Next(10000, 99999).ToString();
        }
    }
}