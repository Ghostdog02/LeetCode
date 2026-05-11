namespace _2300_SpellsAndPotions;

public class Program
{
    static void Main(string[] args)
    {
        int[] spells = [5, 1, 3];
        int[] potions = [1, 2, 3, 4, 5];
        int success = 7;

        SuccessfulPairs(spells, potions, success);
    }

    static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);

        int minPower = 0;
        int left = 0;
        int right = potions.Length - 1;
        int mid = 0;
        int indexLastSuccessfull = -1;
        int[] result = new int[spells.Length];

        for (int i = 0; i < spells.Length; i++)
        {
            minPower = (int)Math.Ceiling((double)success / spells[i]);

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (potions[mid] >= minPower)
                {
                    indexLastSuccessfull = mid;
                    right = mid - 1;
                }

                else
                {
                    left = mid + 1;
                }
            }

            if (indexLastSuccessfull == -1)
            {
                result[i] = 0;
            }


            else
            {
                result[i] = potions.Length - indexLastSuccessfull;   
            }

            right = potions.Length - 1;
            left = 0;
            indexLastSuccessfull = -1;
        }

        return result;
    }
}
