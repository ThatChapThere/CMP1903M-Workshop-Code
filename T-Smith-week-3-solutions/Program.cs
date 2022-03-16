using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 3
            //Challenge: Get the message from the encrypted text
            //
            //1. EITHER:    Read in the .txt file into a List of Strings (or anything else?)
            //   OR:        Read in each line one at a timen and get its maximum character 
            //2. For each string:
            //      Count each character in the string
            //      The maximum is the character
            //3. Output the unencrypted message.

            var message = File.ReadAllText("Week 3 Codes.txt").Split('\n').ToList();

            string messageString = "";

            foreach(string line in message){
                var characterCounts = new Dictionary<char, int>();
                foreach(char character in line) if(!characterCounts.TryAdd(character, 1)) characterCounts[character] ++;

                char mostFrequentCharacter = line[0];
                foreach(char character in characterCounts.Keys) 
                    if(characterCounts[character] > characterCounts[mostFrequentCharacter]) mostFrequentCharacter = character;

                messageString += mostFrequentCharacter;
            }

            Console.WriteLine(messageString);
            /*
            
            var m = new Message();

            m.readMessageFromFile("codes.txt");

            Console.WriteLine(m.decodeMessage());
            */

            //Week 3
            //Task 1: create Message object, call the readTextFromInput() method
            //Task 2: create Atbash object Step 1: pass message to encode() method Step 2: put in the encode logic
            //Task 3: put in the decode logic to the decode() method, check if it works
            //Task 4: read text to encode from a file

            Console.ReadLine();
        }
    }
}
