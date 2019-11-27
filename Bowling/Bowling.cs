using System;
using System.Linq;
using System.Collections.Generic;

public class Bowling
{
    private string _rolls;
    public Bowling(string game)
    {
        _rolls = game.Replace(" ", "");
    }

    public int Score
    {
        get
        {
            var p = Enumerable.Range(0, _rolls.Count())
                .Select(x => RollValue(x) + GetBonus(x))
                .Sum();

            return p;
        }
    }

    private int RollValue(int roll)
    {
        var score = 0;

        int.TryParse(_rolls[roll].ToString(), out score);
        
        return score;
    }

    private int GetBonus(int roll)
    {
        var bonus = 0;

        return bonus;
    }



    private int StrikesCount()
    {
        return _rolls.Count(x => x == 'X');
    }
}

