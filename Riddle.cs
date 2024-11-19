namespace WFA24111301;

internal class Riddle
{
    public string Hint { get; set; }
    public string Solution { get; set; }
    public char[] Puzzle { get; set; }

    public bool Solved => !Puzzle.Any(c => c == '_');

    public List<char> WrongTips { get; } = [];
    public List<char> CorrectTips { get; } = [];

    public List<char> AllTips => CorrectTips.Union(WrongTips).Order().ToList();

    public bool Check(char c)
    {
        if (Solution.Contains(c))
        {
            if (!CorrectTips.Contains(c))
            {
                CorrectTips.Add(c);
                for (int i = 0; i < Solution.Length; i++)
                    if (Solution[i] == c) Puzzle[i] = c;
            }
            return true;
        }
        if (!WrongTips.Contains(c)) WrongTips.Add(c);
        return false;
    }

    public Riddle(string row)
    {
        var splts = row.Split(';');
        Hint = splts[0];
        Solution = splts[1].ToUpper();

        Puzzle = new char[Solution.Length];

        for (int i = 0; i < Puzzle.Length; i++)
            Puzzle[i] = Solution[i] == ' ' ? ' ' : '_';
    }
}
