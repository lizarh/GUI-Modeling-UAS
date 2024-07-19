namespace UjianAkhirSemesterGenap
{
    public partial class Form1 : Form
    {
        private int biayaSewa;
        private int banyak;
        private int jumlah;
        private int diskon;

        private int total;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.biayaSewa = Convert.ToInt32(this.textBox2.Text);
            this.banyak = Convert.ToInt32(this.textBox3.Text);
            this.jumlah = Convert.ToInt32(this.textBox4.Text);


            Discount discount = new Discount(this.jumlah);

            this.diskon = discount.diskon();
            this.textBox5.Text = Convert.ToString("% " + this.diskon);

            this.total = (this.biayaSewa * this.jumlah);
            this.total -= this.diskon;
            this.textBox6.Text = Convert.ToString("Rp. " + this.total);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
