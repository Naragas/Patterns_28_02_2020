using System;

namespace DefaultNamespace
{
    internal class ScoreInterpretator
    {
        
        
        public string GetScore(long number)
        {
            string result = String.Empty;
            if (number < 1)
            {
                result = "0";
                
            }else if (number >= 10000000)
            {
                result =  (number / 10000000) + "M";
            }
            else if (number >= 1000)
            {
                result =  number / 1000 + "K";
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }
        
    }
}