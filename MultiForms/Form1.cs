namespace MultiForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void About_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About me...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = DataHandler.zvoleneDatum.ToString();
        }
    }
}