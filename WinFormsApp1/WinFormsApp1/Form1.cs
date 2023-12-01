namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int arrayindex = 0;

        
        string[] arrid = new string[1000];
        string[] arrname = new string[1000];
        int[] arrscore = new int[1000];

        string inputid;
        string inputname;
        string inputscore;
        
        int max_val , max_idx;
        int min_val , min_idx;

        private void button1_Click(object sender, EventArgs e)
        {
            inputid = textBoxid.Text;
            inputname = textBoxname.Text;
            inputscore = textBoxscore.Text;

            arrid[arrayindex] = inputid;
            arrname[arrayindex] = inputname;
            arrscore[arrayindex] = int.Parse(inputscore);
            arrayindex++;


            //get index max 
            max_val = arrscore.Max();
            max_idx = arrscore.ToList().IndexOf(max_val);

            // result Max output

            textBoxidMax.Text = arrid[max_idx];
            textBoxnameMAX.Text = arrname[max_idx];
            textBoxscoreMAX.Text = arrscore[max_idx].ToString() ;

            // get index min
           
            min_val = max_val;
            for (int i = 0; i < arrayindex; i++)
            {
                if (arrscore[i] < min_val) 
                {
                    min_val = arrscore[i];
                }
            }

            
            min_idx = arrscore.ToList().IndexOf(min_val);

            // result Max output

            textBoxMin.Text = arrid[min_idx];
            textBoxnamemin.Text = arrname[min_idx];
            textBox6.Text = arrscore[min_idx].ToString();


            //result average
            double average_grade =  max_val / arrayindex;
            textBox7.Text = average_grade.ToString();




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          

        }
    }
}
