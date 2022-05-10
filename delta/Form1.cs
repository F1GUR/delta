namespace delta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(abox.Text);
            float b = Convert.ToSingle(bbox.Text);
            float c = Convert.ToSingle(cbox.Text);
            float d = (b * b) - (4 * a * c);

            wynik.Text = d.ToString();
            float ub = b * -1;

            float x1 =(float)(ub - Math.Sqrt(d)) / (2 * a);
            float x2 = (float)(ub + Math.Sqrt(d)) / (2 * a);

            x1Box.Text = x1.ToString();
            x2Box.Text = x2.ToString();

            if (d > 0)
            {
                doduj.Text = "Delta jest Dodatnia";
            }
            else if (d < 0)
            {
                doduj.Text = "Delta jest Ujemna";
            }
            else if (d == 0)
            {
                doduj.Text = "Delta jest 0";
            }
        }
    }
}