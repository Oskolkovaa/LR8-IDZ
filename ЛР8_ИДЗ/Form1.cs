namespace ЛР8_ИДЗ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);
                int n = Convert.ToInt32(textBoxN.Text);
                int r = Convert.ToInt32(textBoxR.Text);
                textBoxResult.Text = Уравнение.УР1(x, y, n, r).ToString();
            }
            else
            {
                int n = Convert.ToInt32(textBoxN.Text);
                int r = Convert.ToInt32(textBoxR.Text);
                int a = Convert.ToInt32(textBoxA.Text);
                int b = Convert.ToInt32(textBoxB.Text);
                int c = Convert.ToInt32(textBoxC.Text);
                textBoxResult.Text = Уравнение.УР2(n, r,a,b,c).ToString();
            }
        }

    }
}