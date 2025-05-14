using System.Reflection.Emit;

namespace Atbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string m = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo. Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh. Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm. Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt. Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg. Erxglib rh mvzi. Hgzb ivzwb.";
         }
        static void OverallView(Dictionary<string, int> MessmessagePoint) 
        {
            Console.WriteLine("chagay");
        }
      
        static string  MessageDecoder(string EncryptedMessage)
        {
            string MessageDecoder = "";
            foreach (char letter in EncryptedMessage.ToLower())
            {
                if (char.IsLetter(letter))
                {
                    MessageDecoder += DecodingLetter(letter);
                }
                else
                {
                    MessageDecoder += letter;
                }
            }
            return MessageDecoder;
        }

        static char DecodingLetter(char Letter)
        {
            int formula = 'z' - (Letter - 'a');
            char DecodingLetter = Convert.ToChar(formula);
            return DecodingLetter;
        }

        static Dictionary<string, int> DangerousWordsCalculator(string messege)
        {
            var messagePoints = new Dictionary<string, int> { { "a", 1 } };
            return messagePoints;
        }
    }
}
