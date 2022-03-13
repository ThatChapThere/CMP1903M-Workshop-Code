using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Message
    {
        //private field
        private List<string> _message = new List<string>{};

        //public property hiding private field
        public List<string> message
        {
            get { return _message; }
            private set { _message = value; }
        }
        
        public char getMostFrequentCharacter(string line) {
            var characterCounts = new Dictionary<char, int>();
            foreach(char character in line) if(!characterCounts.TryAdd(character, 1)) characterCounts[character] ++;

            char mostFrequentCharacter = line[0];
            foreach(char character in characterCounts.Keys) 
                if(characterCounts[character] > characterCounts[mostFrequentCharacter]) mostFrequentCharacter = character;

            return mostFrequentCharacter;
        }

        public string decodeMessage(){
            string messageString = "";

            foreach(string line in message){
                messageString += getMostFrequentCharacter(line);
            }

            return messageString;
        }

        //read the message to encrypt from a file
        public void readMessageFromFile(string filename)
        {
            //Read text from a file
            //create a list of each line of the file
            message = File.ReadAllText(filename).Split('\n').ToList();
        }

        //read the message to encrypt from input
        public void readMessageFromInput()
        {
            Console.WriteLine("Enter your message to encode...");
            message = new List<string> {Console.ReadLine()};
        } 
    
    }
}
