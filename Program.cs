namespace Atbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDictionary(DangerousWordsCalculator("hey zalmen ma", ["hey", "ma"]));
        }
        static void OverallView(Dictionary<string, int> MessmessagePoint) 
        {
            Console.WriteLine("chagay");
        }
      
        string  MessageDecoder(string EncryptedMessage)
        {
            return "Message - Experience";
        }

        
        
        static Dictionary<string, int> DangerousWordsCalculator(string messege, string[] dangerousWords)
        {
            string temp = "";
            int sumWords = 0;
            for (int i = 0; i < messege.Length; i++)
            {
                if (messege[i] == ' ')
                {
                    sumWords += dangerousWords.Contains(temp) ? 1 : 0;
                    temp = "";
                }
                else if (i == messege.Length - 1)
                {
                    temp += messege[i];
                    sumWords += dangerousWords.Contains(temp) ? 1 : 0;
                }
                else
                {
                    temp += messege[i];
                }
            }
            var messagePoints = new Dictionary<string, int> { { messege, sumWords } };


            return messagePoints;


        }

        static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }




    }
}
