namespace Hafıza_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private System.Windows.Forms.Timer timer;
        int renk = 0;
        List<Color> colors = new List<Color>();
        List<Color> colors2 = new List<Color>();
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 400;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)//İlk resim seçildiğinde 2. yi seçmek için
        {

            Kurabiye.ForeColor = colors[renk];
            button1.BackColor = colors2[renk];

            if (renk < colors.Count-1)
            {
                renk++;
            }
            else
            {
                renk = 0;

            }
        }
        public void RenkEkle()
        {
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Purple);
            colors.Add(Color.Chocolate);
            colors.Add(Color.Green);
            
            colors.Add(Color.White);
            colors.Add(Color.Coral);
            colors.Add(Color.CadetBlue);
            colors.Add(Color.Aqua);
            colors.Add(Color.Aquamarine);
            colors2.Add(Color.Blue);
            colors2.Add(Color.Aquamarine);
            colors2.Add(Color.Aqua);
            colors2.Add(Color.Purple);
            colors2.Add(Color.Green);
            
            colors2.Add(Color.White);
            colors2.Add(Color.Coral);
            colors2.Add(Color.Azure);
            colors2.Add(Color.PowderBlue);
            colors2.Add(Color.Pink);


        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            form2.FormClosed += (s, args) => { this.Show(); };

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenkEkle();
            timer.Start();
        }
    }
}