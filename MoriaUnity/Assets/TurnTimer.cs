using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTimer 
{
    int timeRemaining;

    int timerUpperbound;
    private static int timeLeft;
    private int NEARLY_OVER_THRESHOLD  = 100 ;

    // Start is called before the first frame update

    public TurnTimer(int StartingTime)
    {
        timeRemaining = StartingTime;
    }

    public TurnTimer(int StartingTime, int upperThreshold)
    {
        timeRemaining = StartingTime;
        timerUpperbound = upperThreshold;

    }
    public void AddTime(int NumberOfTurns)
    {
        timeRemaining += NumberOfTurns;
        if (timeRemaining > timerUpperbound)
            timeRemaining = timerUpperbound;
    }

    public bool isOver
    {
        get { return timeRemaining <= 0; }
    }

    public bool isNearlyOver
    {
        get { return timeRemaining < NEARLY_OVER_THRESHOLD; }
    }

    public object timeleft { get { return timeRemaining; } }

    public void tick()
    {
        timeRemaining--;


    }


}
