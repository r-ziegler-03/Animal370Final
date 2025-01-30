namespace HangmanAI;

public static class HangmanAI
{
    private static List<string> allWords = new List<string>();
    private static string correctWord;
    private static List<char> guessedLetters = new List<char>();
    private static bool hasGuessedWord = false;
    private static int numberOfGuesses = 0;
    private static int numberOfWrongGuessesLeft;
    
    public static bool SolvePuzzle(string word, int numberOfWrongGuesses)
    {
        allWords = LoadWords();
        
        SetCorrectWord(word);
        Console.WriteLine("Word to guess is: " + correctWord);

        Initialize(numberOfWrongGuesses);

        allWords = RemoveWordsWithWrongNumberOfLetters();
        
        while (numberOfWrongGuessesLeft > 0)
        {
            char guessedLetter = GuessLetter(allWords); 
            CheckGuessesLetter(guessedLetter);

            hasGuessedWord = CheckForWin();
            if (hasGuessedWord)
                break;
        }

        return ShowResults(numberOfWrongGuesses);
    }

    public static void Initialize(int  numberOfWrongGuesses)
    {
        guessedLetters = new List<char>();
        numberOfWrongGuessesLeft = numberOfWrongGuesses;
    }

    private static bool CheckForWin()
    {
        string currentStatus = GetCurrentStatus();
        Console.WriteLine("Current status: " + currentStatus);
        if (!currentStatus.Contains('_'))
            return true;
        return false;
    }

    private static bool ShowResults(int numberOfWrongGuesses)
    {
        if (hasGuessedWord)
        {
            Console.WriteLine("Guessed the word " + correctWord + " with " + numberOfWrongGuesses + " left");
            return true;
        }
        else
        {
            Console.WriteLine("No word found in " + numberOfGuesses + " guesses");
            return false;
        }
    }

    private static void CheckGuessesLetter(char guessedLetter)
    {
        List<int> positions = FindLetterPositionsInWord(guessedLetter);

        if (positions.Count != 0)
        {
            allWords = GetWordsWithLetterInPositions(guessedLetter, positions);
        }
        else
        {
            numberOfWrongGuessesLeft--;
        }
    }


    private static char GuessLetter(List<string> words)
    {
        char guessedLetter = FindMostCommonLetter(words);
        Console.WriteLine("Guessing: " + guessedLetter);
            
        guessedLetters.Add(guessedLetter);
        numberOfGuesses++;
        
        return guessedLetter;
    }
    
    public static void SetCorrectWord(string word)
    {
        correctWord = word;
    }

    private static string GetCurrentStatus()
    {
        string currentStatus = String.Empty;
        foreach (char letter in correctWord)
        {
            if (guessedLetters.Contains(letter))
                currentStatus += letter;
            else
            {
                currentStatus += "_";
            }
        }
        return currentStatus;
    }

    private static List<int> FindLetterPositionsInWord(char mostCommonLetter)
    {
        List<int> positions = new List<int>();

        for (int i = 0; i < correctWord.Length; i++)
        {
            if (correctWord[i] == mostCommonLetter)
                positions.Add(i);
        }
        
        return positions;
    }

    public static List<string> RemoveWordsWithWrongNumberOfLetters()
    {
        int numberOfLetters = correctWord.Length;
        List<string> newList = new List<string>();
        foreach (string word in allWords)
        {
            if (word.Length == numberOfLetters)
            {
                newList.Add(word);
            }
        }
        
        return newList;
    }
    
    public static List<string> LoadWords()
    {
        allWords = new List<string>();
        using (StreamReader r = new StreamReader("words_alpha.txt"))
        {
            string word;
            while ((word = r.ReadLine()) != null)
            {
                allWords.Add(word);
            }
        }
        
        return allWords;
    }

    public static List<string> GetWordsWithLetterInPositions(char letter, List<int> positions)
    {
        List<string> newList = new List<string>();
        foreach (string word in allWords)
        {
            bool foundInAllPositions = true;
            for (int i = 0; i < positions.Count; i++)
            {
                if (word[positions[i]] != letter)
                    foundInAllPositions = false;
            }
            if (foundInAllPositions)
            {
                newList.Add(word);
            }
        }
        
        return newList;
    }

    public static char FindMostCommonLetter(List<string> wordlist)
    {
        Dictionary<char, int> letterCount = new Dictionary<char, int>();
        foreach (string word in wordlist)
        {
            foreach (char character in word)
            {
                if (letterCount.ContainsKey(character))
                    letterCount[character]++;
                else
                {
                    letterCount.Add(character, 1);
                }
            }
        }

        char biggestLetter = ' ';
        int biggestCount = 0;
        foreach (KeyValuePair<char,int> keyValuePair in letterCount)
        {
            if (!guessedLetters.Contains(keyValuePair.Key))
            {
                if (keyValuePair.Value > biggestCount)
                {
                    biggestCount = keyValuePair.Value;
                    biggestLetter = keyValuePair.Key;
                }
            }
        }
        
        return biggestLetter;
    }
}