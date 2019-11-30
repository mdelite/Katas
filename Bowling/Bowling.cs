using System.Linq;

public class Bowling
{
    private string _scorecard;
    private int _lastRoll; // last regular roll of frame 10
    public Bowling(string game)
    {
        _scorecard = game.Replace(" ", "").ToLowerInvariant();

        for (var c = 0; c <= 2; c++)
        {
            var test = _scorecard.Substring(0, _scorecard.Length - c);
            var strikes = test.Count(x => x == 'x');

            if (test.Length + strikes == 20)
            {
                _lastRoll = test.Length;
                break;
            }
        }
    }

    public int Score
    {
        get
        {
            var p = Enumerable.Range(0, _lastRoll)
                .Select(x => RollValue(x) + GetBonus(x))
                .Sum();

            return p;
        }
    }

    private int RollValue(int rollNum)
    {
        var score = 0;
        var roll = _scorecard[rollNum];

        if (!int.TryParse(roll.ToString(), out score))
        {
            switch (roll)
            {
                case 'x':
                    return 10;
                case '/':
                    return 10 - RollValue(rollNum - 1);
                default:
                    break;
            }
        }

        return score;
    }

    private int GetBonus(int rollNum)
    {
        if (rollNum <= _lastRoll)
        {
            var roll = _scorecard[rollNum];
            switch (roll)
            {
                case 'x':
                    return RollValue(rollNum + 1) + RollValue(rollNum + 2);
                case '/':
                    return RollValue(rollNum + 1);
            }
        }

        return 0;
    }
}

