namespace tpmod03_103022300058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Submit_Click(object sender, EventArgs e)
        {
            label1Output.Text = "Hallo, " + textBox1Form.Text;
        }
    }
}
