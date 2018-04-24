using System;
using System.Collections.Generic;
namespace CsharpProject
{
    public class Exercise1
    {
        public Dictionary<char, int> GetCharacterCount(string name)
        {
            var result = new Dictionary<char, int>();
          
            foreach (char c in name.ToLower().ToCharArray())
            {
                if (c == ' ') continue;                
                if (result.ContainsKey(c))
                {
                    result[c] = (int)result[c] + 1;
                }
                else
                {
                    result.Add(c, 1);
                }
            }
            return result;
        }
    }
}
