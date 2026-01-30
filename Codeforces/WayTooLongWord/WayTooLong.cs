using System;

namespace WayTooLongWords{
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){
                string word = Console.ReadLine();
                Console.WriteLine(word.Length > 10 ? word[0].ToString() + (word.Length - 2) + word[word.Length - 1].ToString() : word);       
            }
        }
    }   
}
