
public static class Events
{
    public delegate void ScoreUpdatedAction(int score);
    public static ScoreUpdatedAction OnScoreUpdatedEvent;

    public delegate void HighScoreUpdatedAction(int highscore);
    public static HighScoreUpdatedAction OnHighScoreUpdatedEvent;

    public delegate void OneLiveLostAction();
    public static OneLiveLostAction OnOneLiveLostEvent;
    public delegate void TwoLivesLostAction();
    public static TwoLivesLostAction OnTwoLivesLostEvent;
    public delegate void ThreeLivesLostAction();
    public static ThreeLivesLostAction OnThreeLivesLostEvent;

    public delegate void NewGameAction();
    public static NewGameAction OnNewGameEvent;

    public delegate void GameOverAction();
    public static GameOverAction OnGameOverEvent;
}
