namespace Portal.Common.Core;

/// <summary>
/// Пара свободного времени для определения брони
/// </summary>
public class FreeTime
{
    /// <summary>
    /// Начало времени
    /// </summary>
    /// <example>12:00:00</example>
    public TimeOnly StartTime { get; }

    /// <summary>
    /// Конец времени
    /// </summary>
    /// <example>18:00:00</example>
    public TimeOnly EndTime { get; }

    public FreeTime(TimeOnly startTime, TimeOnly endTime)
    {
        StartTime = startTime;
        EndTime = endTime;
    }
    
    public FreeTime(string startTime, string endTime)
    {
        StartTime = TimeOnly.Parse(startTime);
        EndTime = TimeOnly.Parse(endTime);
    }
    
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        var other = (FreeTime) obj;
        return StartTime == other.StartTime
               && EndTime == other.EndTime;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(StartTime, EndTime);
    }
}