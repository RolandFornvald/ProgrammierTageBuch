namespace SortedIteration;

public sealed class UserScore : IComparable<UserScore> 
{
    public UserScore(string name, DateTime timestamp, int score) 
    {
        Name = name;
        Timestamp = timestamp;
        Score = score;
    }

    public string Name { get; }
    public DateTime Timestamp { get; }
    public int Score { get; }
    public int CompareTo(UserScore? other)
    {
        if (ReferenceEquals(this, other)) 
        {
            return 0;
        }

        if (ReferenceEquals(null, other)) 
        {
            return 1;
        }

        int scoreComparison = Score.CompareTo(other.Score) * -1; 

        if (scoreComparison != 0) 
        {
            return scoreComparison;
        }

        int timestampComparison = Timestamp.CompareTo(other.Timestamp); 

        return timestampComparison != 0 
            ? timestampComparison 
            : string.Compare(Name, other.Name, StringComparison.Ordinal); 
    }
    
    public static bool operator <(UserScore? left, UserScore? right) => 
        Comparer<UserScore>.Default.Compare(left, right) < 0; 

    public static bool operator >(UserScore? left, UserScore? right) => 
        Comparer<UserScore>.Default.Compare(left, right) > 0; 

    public static bool operator <=(UserScore? left, UserScore? right) => 
        Comparer<UserScore>.Default.Compare(left, right) <= 0; 

    public static bool operator >=(UserScore? left, UserScore? right) => 
        Comparer<UserScore>.Default.Compare(left, right) >= 0; 
}