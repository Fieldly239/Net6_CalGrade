using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1
{
    public class CalcGrade
    {
        private int Score { get; set; }

        //constructure
        public CalcGrade(int score)
        {
            this.Score = score;
        }

        public string Excute()
        {
            var response = "";
            if (Score > 100)
            {
                response = "Invaild";
            }
            else if (Score >= 80)
            {
                response = "A";
            }
            else if (Score >= 70)
            {
                response = "B";
            }
            else if (Score >= 60)
            {
                response = "C";
            }
            else if (Score >= 50)
            {
                response = "D";
            }
            else if (Score < 0)
            {
                response = "Invaild";
            }
            else
            {
                response = "F";
            }
            return response;
        }
    }
}
