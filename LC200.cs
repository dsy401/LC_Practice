namespace LeetcodeAlgo;

// DFS
public class LC200
{
    public int NumIslands(char[][] grid)
    {
        var row = grid.Length;
        var col = grid[0].Length;

        var result = 0;
        
        Action<int, int> dfs = null;

        dfs = (x, y) =>
        {
            if (x < 0 || y < 0 || x > row - 1|| y > col - 1 || grid[x][y] == '0') return;

            grid[x][y] = '0';

            dfs(x + 1, y);
            dfs(x - 1, y);
            dfs(x, y + 1);
            dfs(x, y - 1);
        };

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < col; j++)
            {
                if (grid[i][j] == '1')
                {
                    result += 1;
                    dfs(i, j);
                } 
            }
        }

        return result;
    }
}