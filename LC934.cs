namespace LeetcodeAlgo;

public class LC934
{
    public int ShortestBridge(int[][] grid)
    {
        var gridSize = grid.Length;
        
        Action<int, int> dfs = null;

        var queue = new Queue<int[]>();

        dfs = (i, j) =>
        {
            if (i < 0 || j < 0 || j > gridSize - 1 || i > gridSize - 1 || grid[i][j] == 2 || grid[i][j] == 0)
            {
                return;
            }
            
            grid[i][j] = 2;
            
            queue.Enqueue(new [] {i, j});

            dfs(i + 1, j);
            dfs(i - 1, j);
            dfs(i, j + 1);
            dfs(i, j - 1);
        };

        var isBreak = false;

        for (var i = 0; i < gridSize; i++)
        {
            if (isBreak) break;
            
            for (var j = 0; j < gridSize; j++)
            {
                if (grid[i][j] == 1)
                {
                    dfs(i, j);
                    isBreak = true;
                    break;
                }
            }
        }

        var result = 0;

        var visited = new bool[gridSize, gridSize];
        
        while (queue.Count != 0)
        {
            var size = queue.Count;

            while (size !=0)
            {
                var coords = queue.Dequeue();
                var x = coords[0];
                var y = coords[1];

                if (x < 0 || y < 0 || x > gridSize - 1 || y > gridSize - 1 || visited[x,y])
                {
                    size--;
                    continue;
                }
                
                if (grid[x][y] == 1)
                {
                    return result - 1;
                }

                visited[x, y] = true;

                queue.Enqueue(new []{x + 1, y});
                queue.Enqueue(new []{x - 1, y});
                queue.Enqueue(new []{x, y + 1});
                queue.Enqueue(new []{x, y - 1});
                
                size--;
            }
            
            result += 1;
        }

        return 0;
    }
}