namespace _2300_SuccessfulPairsOfSpellsAnd_Potions;

class Program
{
    static void Main(string[] args)
    {
        int[] spells = [5,1,3]; 
        int[] potions = [1,2,3,4,5];
        int success = 7;

        SuccessfulPairs(spells, potions, success);
    }

    static int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);

        int[] result = new int[spells];

        for (int i = 0; i < spells.Length; i++)
        {
            for (int j = potions.Length - 1; j >= 0; j--)
            {
                if (spells[i] * potions[j] > success)
                {
                    result[i]++;
                }

                else
                {
                    break;
                }
            }
        }

        return result;
    }
}
