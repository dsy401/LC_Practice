namespace LeetcodeAlgo;

// BFS
public class LC200_2
{
    public int NumIslands(char[][] grid)
    {
        var row = grid.Length;
        var col = grid[0].Length;

        var result = 0;

        var bfs = (int x, int y) =>
        {
            var queue = new Queue<int[]>();
            
            queue.Enqueue(new []{x, y});

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                
                if (current[0] < 0 || current[1] < 0 || current[0] > row - 1 || current[1] > col - 1 
                    || grid[current[0]][current[1]] == '0') continue;

                grid[current[0]][current[1]] = '0';
                
                queue.Enqueue(new []{current[0] + 1, current[1]});
                queue.Enqueue(new []{current[0] - 1, current[1]});
                queue.Enqueue(new []{current[0], current[1] + 1});
                queue.Enqueue(new []{current[0], current[1] - 1});
            }
        };

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < col; j++)
            {
                if (grid[i][j] == '1')
                {
                    result += 1;
                    bfs(i, j);
                } 
            }
        }

        return result;
    }
}