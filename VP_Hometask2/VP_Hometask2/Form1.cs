namespace VP_Hometask2
{
    public partial class Form1 : Form
    {
        int costA = 15;
        int costB = 12;
        int costC = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int amountOfA;
            int amountOfB;
            int amountOfC;
            int total;

            try
            {
                amountOfA = int.Parse(textBox1.Text);
                amountOfB = int.Parse(textBox2.Text);
                amountOfC = int.Parse(textBox3.Text);

                total = (costA * amountOfA) + (costB * amountOfB) + (costC * amountOfC);

                label13.Text = (costA * amountOfA).ToString() + ".00€";
                label14.Text = (costB * amountOfB).ToString() + ".00€";
                label15.Text = (costC * amountOfC).ToString() + ".00€";
                label16.Text = total.ToString() + ".00€";
            }

            catch
            {
                MessageBox.Show("Error! Put here valid data.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label13.Text = null;
            label14.Text = null;
            label15.Text = null;
            label16.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}