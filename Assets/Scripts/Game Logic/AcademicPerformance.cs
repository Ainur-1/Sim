using UnityEngine;

public class AcademicPerformance : MonoBehaviour
{
    public int TotalPoints { get; private set; } = 0;
    public int TargetScore { get; private set; }

    public AcademicPerformance(int targetScore)
    {
        TargetScore = targetScore;
    }

    public int AddPoints(int points)
    {
        return TotalPoints += points;
    }
    public bool IsWin()
    {
        return TargetScore <= TotalPoints;
    }
    public override string ToString()
    {
        return $"{TotalPoints}/{TargetScore}";
    }
}
