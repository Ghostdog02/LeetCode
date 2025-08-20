// using System.Text;

string[] input = ["eat", "tea", "tan", "ate", "nat", "bat"];

// var anagramPairs = new Dictionary<string, IList<string>>();
// var occurrences = new Dictionary<char, int>();
// var sortedString = new StringBuilder();
// int value;
// IList<string> anagrams;
// string currString;

// for (int i = 0; i < input.Length; i++)
// {
//     currString = input[i];
//     for (int currLetter = 0; currLetter < currString.Length; currLetter++)
//     {
//         if (occurrences.TryGetValue(currString[currLetter], out value))
//         {
//             occurrences[currString[currLetter]]++;
//         }

//         else
//         {
//             occurrences.Add(currString[currLetter], 1);
//         }
//     }

//     for (char currLetter = 'a'; currLetter <= 'z'; currLetter++)
//     {
//         if (occurrences.TryGetValue(currLetter, out value))
//         {
//             sortedString.Append(currLetter, occurrences[currLetter]);
//         }
//     }

//     if (anagramPairs.TryGetValue(sortedString.ToString(), out anagrams))
//     {
//         anagrams.Add(currString);
//     }

//     else
//     {
//         anagramPairs.Add(sortedString.ToString(), [currString]);
//     }

//     occurrences.Clear();
//     sortedString.Clear();
// }

// var vallues = anagramPairs.Values.ToList();

