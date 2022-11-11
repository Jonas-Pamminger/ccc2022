using ccc.ConsoleApp;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class TestClass
{
    static void Main(string[] args)
    {

        // Display the number of command line arguments.
        AlienMessage alienMessage = new AlienMessage();
        StringBuilder str = new StringBuilder();
        foreach (var letter in alienMessage.returnDictionary(alienMessage.Read()))
        {
           str.AppendLine((alienMessage.CountLetter(letter)));
        }

        
    }
    
}