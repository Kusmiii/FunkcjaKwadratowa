namespace funkcjakrwadratowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(abox.Text);
            float b = Convert.ToSingle(bbox.Text);
            float c = Convert.ToSingle(cbox.Text);
            float d = (b * b) - (4 * a * c);

            this.d.Text = d.ToString();
            float ub = b * -1;

            float x1 = (float)(ub - Math.Sqrt(d)) / (2 * a);
            float x2 = (float)(ub + Math.Sqrt(d)) / (2 * a);

            x1Box.Text = x1.ToString();
            x2Box.Text = x2.ToString();

            if (d > 0)
            {
                napis.Text = "Delta jest Dodatnia";
            }
            else if (d < 0)
            {
                napis.Text = "Delta jest Ujemna";
            }
            else if (d == 0)
            {
                napis.Text = "Delta jest 0";
            }
        }
    }
}