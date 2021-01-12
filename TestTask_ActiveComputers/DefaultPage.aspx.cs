using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestTask_ActiveComputers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region First task
        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            var Inputstring = TextBoxFirstTaskInputMassive.Text;
            string[] massive = Inputstring.Split(' ');
            var Trim = massive.Select(x => x.Trim());
            var WhereInt = Trim.Where(x => int.TryParse(x, out int f));
            var SelectInt = WhereInt.Select(x => int.Parse(x));
            var WhereIsNotEven = SelectInt.Where(x => (x % 2) != 0);
            bool IsSecond = false;
            var EverySecond = WhereIsNotEven.Where(x => { IsSecond = !IsSecond; return !IsSecond; });
            var Abs = EverySecond.Select(x => Math.Abs(x)); // Разными коллекциями для наглядности и дебага.
            int Result = Abs.Sum();
            TextBoxFirstTaskOutputResult.Text = Result + "";
        }
        #endregion First task

        #region Second task
        protected void ButtonSecondTask1_Click(object sender, EventArgs e)
        {
            var Inputstring = TextBoxSecondTaskInputMassive.Text;
            string[] massive = Inputstring.Split(' ');

            if (massive.Length == 2)
            {
                string FirstNumber_string = massive[0];
                string SecondNumber_string = massive[1];

                if (int.TryParse(FirstNumber_string, out int I1) & int.TryParse(SecondNumber_string, out int I2))
                {
                    LinkedList<int> FirstNumber = new LinkedList<int>();

                    foreach (var Symbol in FirstNumber_string)
                        FirstNumber.AddFirst(int.Parse(Symbol + ""));

                    LinkedList<int> SecondNumber = new LinkedList<int>();

                    foreach (var Symbol in SecondNumber_string)
                        SecondNumber.AddFirst(int.Parse(Symbol + ""));

                    LinkedList<int> Result = GetSum(FirstNumber, SecondNumber);
                    string Result_string = string.Join("", Result.Reverse().Select(x => x + "").ToArray());
                    TextBoxSecondTaskOutputResult.Text = Result_string;
                }
            }
        }
        public static LinkedList<int> GetSum(LinkedList<int> FirstNumber, LinkedList<int> SecondNumber)
        {
            LinkedList<int> ResultNumber = new LinkedList<int>();
            FirstNumber = FirstNumber is null ? new LinkedList<int>() : FirstNumber;
            SecondNumber = SecondNumber is null ? new LinkedList<int>() : SecondNumber;

            var FirstCicle = FirstNumber.Count > SecondNumber.Count ? FirstNumber : SecondNumber;
            var SecondCicle = FirstNumber.Count > SecondNumber.Count ? SecondNumber : FirstNumber;
            var FirstItem = FirstCicle.First;
            var SecondItem = SecondCicle.First;
            int Temp = 0;

            for (int i = 0; i <= FirstCicle.Count; i++)
            {
                var SummItem = (FirstItem is null ? 0 : FirstItem.Value) + (SecondItem is null ? 0 : SecondItem.Value) + Temp;
                Temp = 0;

                if (SummItem > 9)
                {
                    SummItem -= 10;
                    Temp = 1;
                }

                ResultNumber.AddLast(SummItem);

                FirstItem = FirstItem is null ? null : FirstItem.Next;
                SecondItem = SecondItem is null ? null : SecondItem.Next;
            }

            if (ResultNumber.Last.Value == 0)
                ResultNumber.RemoveLast();

            return ResultNumber;
        }
        #endregion

        #region Third Task
        protected void ButtonThirdTaskSend_Click(object sender, EventArgs e)
        {
            string Input = TextBoxThirdTaskInputMassive.Text;
            TextBoxThirdTaskOutputResult.Text = IsPalindrom(Input) + "";
        }
        public static bool IsPalindrom(string str)
        {
            if (!(str is null))
            {
                str = str.Replace(" ", "").ToUpper();

                return IsPalindromInternal(str);
            }
            else
                return false;
        }
        private static bool IsPalindromInternal(string str) // рекурсия
        {
            if (str.Length == 1 || string.IsNullOrEmpty(str)) 
                return true;
            else if (!str[0].Equals(str[str.Length - 1]))
                return false;

            return IsPalindromInternal(str.Substring(1, str.Length - 2));
        }
        #endregion
    }
}