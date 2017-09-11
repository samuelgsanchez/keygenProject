using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;

namespace KeyGen
{
    public class PasswordStregthManager
    {
        private static PasswordStregthManager instance = null;

        public static PasswordStregthManager Instance
        {
            get
            {
                if (instance == null)
                    PasswordStregthManager.instance = new PasswordStregthManager();

                return PasswordStregthManager.instance;
            }
        }

        public string GetPasswordStrength(string username, string password)
        {
            return GetStengthText(GetPasswordScore(username, password));
        }

        public Color GetPasswordColor(string username, string password)
        {
            int result = GetPasswordScore(username, password);
            if (result == 0)
            {
                return Color.Red;
            }
            else if (result < 2)
            {
                return Color.Red;
            }
            else if (result < 45)
            {
                return Color.Orange;
            }
            else if (result < 75)
            {
                return Color.YellowGreen;
            }
            else
            {
                return Color.Green;
            }
        }

        #region Utility Methods

        public int GetPasswordScore(string username, string password)
        {
            int score = 0;

            if (password.Length < 1)
            {
                return 1;
            }
            if (password.ToLower().Equals(username.ToLower()))
                return 2;

            score += password.Length * 4;
            score += (CheckRepetition(1, password).Length - password.Length);
            score += (CheckRepetition(2, password).Length - password.Length);
            score += (CheckRepetition(3, password).Length - password.Length);
            score += (CheckRepetition(4, password).Length - password.Length);


            Regex pattern = new Regex(@"(.*[\d].*[\d].*)");
            if (pattern.IsMatch(password))
                score += 5;
            pattern = new Regex(@"(.*[\W].*[\W].*)");
            if (pattern.IsMatch(password))
                score += 5;

            pattern = new Regex("(.*[a-z].*[A-Z].*)|(.*[A-Z].*[a-z].*)");
            if (pattern.IsMatch(password))
                score += 10;

            bool conditionOne = false;
            bool conditionTwo = false;

            pattern = new Regex(".*[a-zA-Z].*");
            conditionOne = pattern.IsMatch(password);

            pattern = new Regex(".*[0-9].*");
            conditionTwo = pattern.IsMatch(password);

            if (conditionTwo && conditionOne)
                score += 10;


            pattern = new Regex(@".*[\W].*");
            conditionOne = pattern.IsMatch(password);

            if (conditionTwo && conditionOne)
                score += 10;

            pattern = new Regex("(.*[a-zA-Z].*)");
            conditionTwo = pattern.IsMatch(password);

            if (conditionTwo && conditionOne)
                score += 10;

            pattern = new Regex("[0-9]*");
            conditionOne = pattern.IsMatch(password);
            if (conditionOne || conditionTwo)
                score -= 10;

            if (password.IndexOf(username) >= 0)
                score -= 10;

            if (score < 1) score = 1;
            if (score > 100) score = 100;

            return score;
        }


        private static string CheckRepetition(int pLen, string str)
        {
            string res = "";
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                bool repeated = true;
                for (j = 0; j < pLen && (j + i + pLen) < str.Length; j++)
                {
                    repeated = repeated && (str[j + i] == str[j + i + pLen]);
                }
                if (j < pLen) repeated = false;
                if (repeated)
                {
                    i += pLen - 1;
                    repeated = false;
                }
                else
                {
                    res += str[i];
                }
            }
            return res;
        }

        private string GetStengthText(int result)
        {
            if (result == 0)
            {
                return "";
            }
            else if (result < 2)
            {
                return "Bajo";
            }
            else if (result < 45)
            {
                return "Medio";
            }
            else if (result < 75)
            {
                return "Alto";
            }
            else
            {
                return "Muy Alto";
            }
        }

        #endregion
    }
}
