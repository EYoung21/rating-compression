using System;
using System.Linq;

class Program {
    static void Main() {
        // Example: int n = int.Parse(Console.ReadLine());
        // Example: int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string word = Console.ReadLine();
        char first = word[0];
        char last = word[word.Length - 1];
        int minus2 = word.Length - 2;

        string answer = "";

        answer = answer + first.ToString();
        answer = answer + minus2.ToString();
        answer = answer + last.ToString();
        
        Console.WriteLine(answer);
    }
}
