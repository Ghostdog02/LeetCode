string s = "badc",
    t = "baba";

var visitedLettersInT = new HashSet<char>();
var dictionary = new Dictionary<char, char>();

char value;

char currLetter;
char letterToBeMapped;

for (int i = 0; i < s.Length; i++)
{
    currLetter = s[i];
    letterToBeMapped = t[i];

    if (dictionary.TryGetValue(currLetter, out value))
    {
        if (value != letterToBeMapped)
        {
            System.Console.WriteLine(false);
            return;
        }
    }

    else
    {
        if (visitedLettersInT.Contains(letterToBeMapped))
        {
            System.Console.WriteLine(false);
            return;
        }

        dictionary.Add(currLetter, letterToBeMapped);
        visitedLettersInT.Add(letterToBeMapped);
    }
}

System.Console.WriteLine(true);
