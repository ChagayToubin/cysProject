using System.Reflection.Emit;

namespace Atbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            OverallView(DangerousWordsCalculator(MessageDecoder("ds"), ["1","2"]));
         }
        static void OverallView(Dictionary<string, int> MessmessagePoint) 
        {
            string message = "";
            Console.WriteLine("chagay");
            int numPoint = MessmessagePoint.Values.First();

            if (numPoint > 15 || numPoint < 1)
            {
                message += "exceptional";

            }
            else if(numPoint < 5 && numPoint > 0)
            {
                message += "WARNING";

            }
            else if (numPoint > 5 && numPoint < 11)
            {
                message += "DANGER";


            }
            else if (numPoint > 11 && numPoint < 16)
            {
                message += "ULTRA ALERT!";

            }
            
            Console.WriteLine(MessmessagePoint.Keys.First() +" "+ message + " "+numPoint);
                

                 
        }
      
        static string  MessageDecoder(string EncryptedMessage)
        {
            string MessageDecoder = "";
            foreach (char letter in EncryptedMessage.ToLower())
            {
                MessageDecoder += char.IsLetter(letter) ? DecodingLetter(letter) : letter;
            }
            return MessageDecoder;
        }

        static char DecodingLetter(char Letter)

        {
            int formula = 'z' - (Letter - 'a');
            char DecodingLetter = Convert.ToChar(formula);
            return DecodingLetter;
        }

        static Dictionary<string, int> DangerousWordsCalculator(string messege,string[]Arry)
        {
            var messagePoints = new Dictionary<string, int> { { "a", 0 } };
            return messagePoints;
        }

        static string ClearWord(string word)
        {
            string clearWord = "";
            foreach (char letter in  word)
            {
                clearWord += char.IsLetter(letter) ? letter : "";
            }
            return clearWord;
        }
    }

}
