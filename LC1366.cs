namespace LeetcodeAlgo;

public class LC1366
{
    public string RankTeams(string[] votes)
    {
        var scores = new Dictionary<string, int[]>();

        for (var i = 0; i < votes.Length; i++)
        {
            for (var j = 0; j < votes[i].Length; j++)
            {
                var team = votes[i][j].ToString();

                if (!scores.ContainsKey(team))
                {
                    scores[team] = new int[votes[i].Length];
                }
                
                scores[team][j]++;
            }
        }

        var maxHeap = new PriorityQueue<string, object[]>(Comparer<object[]>.Create((x, y) =>
        {
            var p1 = (int[]) x[0];
            var p2 = (int[]) y[0];
            
            int CompareLists(int[] a, int[] b)
            {
                var len = Math.Min(a.Length, b.Length);
                for (int i = 0; i < len; i++)
                {
                    if (a[i] > b[i]) return -1;
                    if (a[i] < b[i]) return 1;
                }
                return a.Length.CompareTo(b.Length);
            }

            var pCheck = CompareLists(p1, p2);

            if (pCheck != 0)
            {
                return pCheck;
            }
            
            var s1 = (string)x[1];
            var s2 = (string)y[1];

            return string.Compare(s1, s2, StringComparison.Ordinal);
        }));
        
        foreach (var key in scores.Keys)
        {
            maxHeap.Enqueue(key, new object[] {scores[key], key});
        }

        var result = "";

        while (maxHeap.Count != 0)
        {
            result += maxHeap.Dequeue();
        }

        return result;
    }
}