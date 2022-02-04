
public static class Events
{
    public delegate void ScoreUpdatedAction(int score);
    public static ScoreUpdatedAction OnScoreUpdatedEvent;
}
