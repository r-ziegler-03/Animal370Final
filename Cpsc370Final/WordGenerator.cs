using System.Security.Cryptography;

namespace Cpsc370Final;

public class WordGenerator
{ 
    public string RandomWord { get; private set; }
    public int randomNumber { get; private set; }
    
    public string GenerateWordForGame(Random random)
    {
        List<string> WordList = new List<string>
        {
            "apple", "banana", "cherry", "grape", "orange", "pear", "watermelon", "strawberry", "blueberry", "pineapple",
            "dog", "cat", "elephant", "giraffe", "hippopotamus", "kangaroo", "lion", "tiger", "bear", "zebra",
            "sun", "moon", "stars", "planet", "comet", "galaxy", "universe", "blackhole", "nebula", "asteroid",
            "mountain", "river", "ocean", "forest", "desert", "valley", "canyon", "waterfall", "lake", "island",
            "computer", "keyboard", "monitor", "mouse", "processor", "memory", "harddrive", "laptop", "tablet", "phone",
            "music", "song", "melody", "guitar", "piano", "drums", "violin", "flute", "trumpet", "saxophone",
            "car", "bus", "bicycle", "airplane", "train", "ship", "rocket", "motorcycle", "scooter", "submarine",
            "school", "teacher", "student", "classroom", "education", "homework", "library", "notebook", "pen", "pencil",
            "soccer", "basketball", "tennis", "cricket", "swimming", "running", "cycling", "baseball", "volleyball", "hockey",
            "disease", "medicine", "hospital", "doctor", "nurse", "patient", "surgery", "treatment", "vaccine", "prescription",
            "chef", "restaurant", "kitchen", "recipe", "cook", "meal", "ingredient", "dish", "menu", "delicious"
        };
        randomNumber = random.Next(0, WordList.Count);
        RandomWord = WordList[randomNumber];
        return RandomWord;
    }
}