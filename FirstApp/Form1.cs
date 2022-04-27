namespace FirstApp
{
    public partial class Form1 : Form
    {
        bool optBrb=false;
        double beraber = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblbrb.Text = "";
            optBrb = true;
            switch (opt)
            {
                case "+": txtbrb.Text = (beraber + double.Parse(txtbrb.Text)).ToString(); break;
                case "-": txtbrb.Text = (beraber - double.Parse(txtbrb.Text)).ToString(); break;
                case "*": txtbrb.Text = (beraber * double.Parse(txtbrb.Text)).ToString(); break;
                case "/": txtbrb.Text = (beraber / double.Parse(txtbrb.Text)).ToString(); break;

            }

            beraber = double.Parse(txtbrb.Text);
            txtbrb.Text = beraber.ToString();
            opt = "";

        }

        private void btnclick(object sender, EventArgs e)
        {
            if(txtbrb.Text == "0" || optBrb)
                txtbrb.Clear();

            optBrb = false;
            Button btn=(Button)sender;  
            txtbrb.Text += btn.Text;
        }

        private void OptHesab(object sender, EventArgs e)
        {
            optBrb=true;
            Button btn = (Button)sender;
            string yeniOpt=btn.Text;

            lblbrb.Text = lblbrb+" "+ txtbrb + " " + yeniOpt;
            
            switch (opt)
            {
                case "+": txtbrb.Text = (beraber + double.Parse(txtbrb.Text)).ToString(); break;
                case "-": txtbrb.Text = (beraber - double.Parse(txtbrb.Text)).ToString(); break;
                case "*": txtbrb.Text = (beraber * double.Parse(txtbrb.Text)).ToString(); break;
                case "/": txtbrb.Text = (beraber / double.Parse(txtbrb.Text)).ToString(); break;

            }

            beraber=double.Parse(txtbrb.Text);
            txtbrb.Text = beraber.ToString();
            opt = yeniOpt;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtbrb.Text = "0";
            lblbrb.Text = "";
            opt = "";
            beraber = 0;
            optBrb = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtbrb.Text = "0";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(txtbrb.Text == "0")
            {
                txtbrb.Text = "0";
                
            }
            else if(optBrb)
            {
                txtbrb.Text = "0";

            }
            if(!txtbrb.Text.Contains(","))
            {
                txtbrb.Text+=",";
            }
            optBrb=false;
        }
    }
}