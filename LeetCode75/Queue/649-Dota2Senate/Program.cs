namespace _649_Dota2Senate;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(PredictPartyVictory("RRDDD"));
    }

    static string PredictPartyVictory(string senate)
    {
        var radiantQueue = new Queue<int>();
        var direQueue = new Queue<int>();

        for (int i = 0; i < senate.Length; i++)
        {
            if (senate[i] == 'R')
            {
                radiantQueue.Enqueue(i);
            }

            else
            {
                direQueue.Enqueue(i);
            }
        }

        while (radiantQueue.Count > 0 && direQueue.Count > 0)
        {
            int direIndex = direQueue.Dequeue();
            int radiantIndex = radiantQueue.Dequeue();

            if (direIndex < radiantIndex)
            {
                direQueue.Enqueue(direIndex + senate.Length);
            }

            else
            {
                radiantQueue.Enqueue(radiantIndex + senate.Length);
            }
        }

        return radiantQueue.Count > 0 ? "Radiant" : "Dire";
    }
}
