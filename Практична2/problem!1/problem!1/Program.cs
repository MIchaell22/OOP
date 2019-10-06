using System;

namespace problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            int s = 0;
            string a = " php cssharp sql html css js hi  softuni nakov java learn";
            string[] words = a.Split(' ');
            
            foreach(var word in words )
            {
                if (word == "hi" || word == "java" || word =="php")
                {
                    i++=s;
                    
                    Console.Write(s);
                }
                   
            }
      
        }
    }
}
