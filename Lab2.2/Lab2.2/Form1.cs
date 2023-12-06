using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2._2
{
    public partial class Form1 : Form
    {
        int arr_index = 0;

        string[] all_id = new string[1000];
        string[] all_name = new string[1000];
        int[] all_score = new int[1000];

        int[] cp_arrscore = new int[1];
        int start = 0, stop, sub_arr_length;
        int max_idx, max_value, min_value, min_idx;

        float[] every_grade = new float[8];

        int[] n_of_grade = new int[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            all_id[arr_index] = tbInPutID.Text;
            all_name[arr_index] = tbInPutName.Text;
            all_score[arr_index] = int.Parse(tbInPutScore.Text);

            arr_index++;
            tbInPutID.Text = "";
            tbInPutName.Text = "";
            tbInPutScore.Text = "";

            max_value = all_score.Max();
            max_idx = all_score.ToList().IndexOf(max_value);

            tbMaxID.Text = $"{all_id[max_idx]}";
            tbNameMax.Text = $"{all_name[max_idx]}";
            tbMaxScore.Text = $"{all_score[max_idx]}";

            cp_arrscore = new int[arr_index];
            stop = arr_index;
            sub_arr_length = stop;
            Array.Copy(all_score, start, cp_arrscore, 0, sub_arr_length);
            min_value = cp_arrscore.Min();

            min_idx = all_score.ToList().IndexOf(min_value);

            tbMinID.Text = $"{all_id[min_idx]}";
            tbNameMin.Text = $"{all_name[min_idx]}";
            tbMinScore.Text = $"{all_score[min_idx]}";

            GPA.Text = $"{(double)all_score.Sum() / (double)arr_index:0.00}";

            int point = all_score[arr_index - 1];
            if (point >= 80 && point <= 100)
            {
                
                n_of_grade[0] += 1;
                A.Text = n_of_grade[0].ToString();
                every_grade[0] = n_of_grade[0] * 4;

            }
            else if (point >= 75 && point <= 79)
            {
                // n of B+
                n_of_grade[1] += 1;
                B_plus.Text = n_of_grade[1].ToString();
                every_grade[1] = n_of_grade[1] * 3.5f;
            }
            else if (point >= 70 && point <= 74)
            {
                // n of B
                n_of_grade[2] += 1;
                B.Text = n_of_grade[2].ToString();
                every_grade[2] = n_of_grade[2] * 3.0f;

            }
            else if (point >= 65 && point <= 69)
            {
                // C+
                n_of_grade[3] += 1;
                C_Plus.Text = n_of_grade[3].ToString();
                every_grade[3] = n_of_grade[3] * 2.5f;
            }
            else if (point >= 60 && point <= 64)
            {
                // C
                n_of_grade[4] += 1;
                C.Text = n_of_grade[4].ToString();
                every_grade[4] = n_of_grade[4] * 2.0f;
            }
            else if (point >= 55 && point <= 59)
            {
                // D+
                n_of_grade[5] += 1;
                D_Plus.Text = n_of_grade[5].ToString();
                every_grade[5] = n_of_grade[5] * 1.5f;
            }
            else if (point >= 50 && point <= 54)
            {
                //D
                n_of_grade[6] += 1;
                D.Text = n_of_grade[6].ToString();
                every_grade[6] = n_of_grade[6] * 1.0f;
            }
            else
            {
                //F
                n_of_grade[7] += 1;
                AVG.Text = n_of_grade[7].ToString();
            }

            AVG.Text = $"{(double)every_grade.Sum() / (double)arr_index:0.00}";

        }
    }
}
