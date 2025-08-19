public class Program
{
    public static void Main(string[] args)
    {
        string ransomNote = "bg",
            magazine = "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj";

        Dictionary<char, int> bigDictionary = new();
        char currLetter;
        int occurrences;

        for (int i = 0; i < magazine.Length; i++)
        {
            currLetter = magazine[i];
            if (bigDictionary.TryGetValue(currLetter, out occurrences))
            {
                bigDictionary[currLetter]++;
            }

            else
            {
                bigDictionary.Add(currLetter, 1);
            }
        }

        occurrences = 0;
        
        for (int i = 0; i < ransomNote.Length; i++)
        {
            currLetter = ransomNote[i];
            if (!bigDictionary.TryGetValue(currLetter, out occurrences) || occurrences <= 0)
            {
                System.Console.WriteLine(false);
                return;
            }

            bigDictionary[currLetter]--;
        }

        System.Console.WriteLine(true);
    }
}
