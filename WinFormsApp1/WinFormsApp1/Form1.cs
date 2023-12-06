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

        int max_val, max_idx;
        int min_val, min_idx;

        int na, nbplus, nb, ncplus, nc, ndplus, nd;

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
            textBoxscoreMAX.Text = arrscore[max_idx].ToString();

            // get index min

            min_val = arrscore[0];
            min_idx = 0;
            for (int i = 1; i < arrayindex; i++)
            {
                if (arrscore[i] < min_val)
                {
                    min_val = arrscore[i];
                    min_idx = i;
                }


                // result Min output
                textBoxMin.Text = arrid[min_idx];
                textBoxnamemin.Text = arrname[min_idx];
                textBox6.Text = arrscore[min_idx].ToString();

                //result average
                double gpa = arrscore.Take(arrayindex).Average();
                textBox7.Text = gpa.ToString("0.00");
            }


            {

                // กำหนดค่าน้ำหนักของเกรดแต่ละตัว
                double weightA = 4.0;
                double weightBplus = 3.5;
                double weightB = 3.0;
                double weightCplus = 2.5;
                double weightC = 2.0;
                double weightDplus = 1.5;
                double weightD = 1.0;




                na = nbplus = nb = ncplus = nc = ndplus = nd = 0;
                for (int i = 0; i < arrayindex; i++)
                {
                    if (arrscore[i] >= 80)
                    {
                        na++;
                    }
                    else if (arrscore[i] >= 75)
                    {
                        nbplus++;
                    }
                    else if (arrscore[i] >= 70)
                    {
                        nb++;
                    }
                    else if (arrscore[i] >= 65)
                    {
                        ncplus++;
                    }
                    else if (arrscore[i] >= 60)
                    {
                        nc++;
                    }
                    else if (arrscore[i] >= 55)
                    {
                        ndplus++;
                    }
                    else
                    {
                        nd++;
                    }
                }


                // คำนวณ GPA
                double gpa = (na * weightA + nbplus * weightBplus + nb * weightB +
                              ncplus * weightCplus + nc * weightC + ndplus * weightDplus +
                              nd * weightD) / arrayindex;
                // แสดงผลลัพธ์
                textBox7.Text = gpa.ToString("0.00");
                UpdateGradeCount();
            }
        }

        private void UpdateGradeCount()
        {
            // แสดงจำนวนนักศึกษาที่ได้รับเกรด A, B+, B, C+, C, D+, D
            textBoxA.Text = na.ToString();
            textBoxBPLUS.Text = nbplus.ToString();
            textBoxB.Text = nb.ToString();
            textBoxCPLUS.Text = ncplus.ToString();
            textBoxC.Text = nc.ToString();
            textBoxDPLUS.Text = ndplus.ToString();
            textBoxD.Text = nd.ToString();
        }
    }
}
        

    

