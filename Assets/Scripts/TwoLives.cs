using UnityEngine;

public class TwoLives : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    
    void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 1;

        Events.OnTwoLivesLostEvent += OnTwoLivesLost;
        Events.OnNewGameEvent += OnNewGame;
    }

    private void OnDestroy()
    {
        Events.OnTwoLivesLostEvent -= OnTwoLivesLost;
        Events.OnNewGameEvent -= OnNewGame;
    }
    
    private void OnTwoLivesLost()
    {
        _canvasGroup.alpha = 0;
    }
   
    private void OnNewGame()
    {
        _canvasGroup.alpha = 1;
    }
}
