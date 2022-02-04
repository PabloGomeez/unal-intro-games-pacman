using UnityEngine;
using TMPro;

public class UIScore : MonoBehaviour
{
    private TextMeshProUGUI _ScoreText;
    private TextMeshProUGUI _HighScoreText;

    private const string SCORE_TEXT_TEMPLATE = "{0} pts";
    private const string HIGH_SCORE_TEXT_TEMPLATE = "{0} pts";
    
    void Start()
    {
        _ScoreText = transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        _HighScoreText = transform.Find("HighScoreText").GetComponent<TextMeshProUGUI>();

        Events.OnScoreUpdatedEvent += OnScoreUpdated;
        
    }

    private void OnDestroy()
    {
        Events.OnScoreUpdatedEvent -= OnScoreUpdated;
    }
    
    public void OnScoreUpdated(int score)
    {
        _ScoreText.text = string.Format(SCORE_TEXT_TEMPLATE, score);
    }

}
