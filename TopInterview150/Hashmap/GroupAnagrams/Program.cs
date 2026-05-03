// using System.Text;

string[] input = ["eat", "tea", "tan", "ate", "nat", "bat"];

var anagramPairs = new Dictionary<string, IList<string>>();

string sortedString;
IList<string> anagrams;

foreach (string currString in input)
{
    char[] count = new char[26];
    foreach (char letter in currString)
    {
        count[letter - 'a']++;
    }

    sortedString = new string(count);

    if (anagramPairs.TryGetValue(sortedString, out anagrams))
    {
        anagramPairs[sortedString].Add(currString);
    }
    else
    {
        anagramPairs.Add(sortedString, [currString]);
    }
}

var vallues = anagramPairs.Values.ToList();
