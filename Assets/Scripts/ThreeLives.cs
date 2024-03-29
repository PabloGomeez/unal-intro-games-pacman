using UnityEngine;

public class ThreeLives : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    
    void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 1;

        Events.OnThreeLivesLostEvent += OnThreeLivesLost;
        Events.OnNewGameEvent += OnNewGame;
    }

    private void OnDestroy()
    {
        Events.OnThreeLivesLostEvent -= OnThreeLivesLost;
        Events.OnNewGameEvent -= OnNewGame;
    }
    
    private void OnThreeLivesLost()
    {
        _canvasGroup.alpha = 0;
    }
   
    private void OnNewGame()
    {
        _canvasGroup.alpha = 1;
    }
}
