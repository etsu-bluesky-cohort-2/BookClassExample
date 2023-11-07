using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClassExample
{
    public class Page
    {
        private string words;


        public string GetWords()
        {
            return words;
        }

        public void SetWords(string words) 
        {
            if(words is null)
            {
                words = "No words on this page unintentionally";
            }
            else if(words == "Left Blank")
            {
                words = "No words on this page intentionally";
            }
            else
            {
                this.words = words;
            }
            
        }
    }
}
