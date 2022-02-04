
public static class Events
{
    public delegate void ScoreUpdatedAction(int score);
    public static ScoreUpdatedAction OnScoreUpdatedEvent;

    public delegate void HighScoreUpdatedAction(int highscore);
    public static HighScoreUpdatedAction OnHighScoreUpdatedEvent;
}
