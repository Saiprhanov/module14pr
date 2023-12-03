using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14pr
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            
            
            
            string text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

           
            
            
            Dictionary<string, int> wordCount = CountWords<string, int>(text);

            
           
            
            Console.WriteLine("Статистика по тексту:");

            
           Console.WriteLine("=====================");

            Console.WriteLine("| Слово   | Повторения |");

            Console.WriteLine("=====================");




            foreach (var pair in wordCount)
            {
                Console.WriteLine($"| {pair.Key,-7} | {pair.Value,-11} |");
            }

            Console.WriteLine("=====================");
        }

        static Dictionary<TKey, TValue> CountWords<TKey, TValue>(string text)
        {
            
            
            string[] words = text.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);




            Dictionary<TKey, TValue> wordCount = new Dictionary<TKey, TValue>();

            
            
            foreach (var word in words)
            {
                
                
                TKey normalizedWord = (TKey)Convert.ChangeType(word.ToLower(), typeof(TKey)); 
                
                
                if (wordCount.ContainsKey(normalizedWord))
                {
                    int count = (int)Convert.ChangeType(wordCount[normalizedWord], typeof(int));
                    wordCount[normalizedWord] = (TValue)Convert.ChangeType(count + 1, typeof(TValue));
                }
                
                
                else
                {
                    wordCount[normalizedWord] = (TValue)Convert.ChangeType(1, typeof(TValue));
                }
            }

            
            
            return wordCount;


        }
    }
}
