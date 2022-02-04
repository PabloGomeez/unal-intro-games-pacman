using UnityEngine;

public class OneLive : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    
    void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 1;

        Events.OnOneLiveLostEvent += OnOneLiveLost;
        Events.OnNewGameEvent += OnNewGame;
    }

    private void OnDestroy()
    {
        Events.OnOneLiveLostEvent -= OnOneLiveLost;
        Events.OnNewGameEvent -= OnNewGame;
    }
    
    private void OnOneLiveLost()
    {
        _canvasGroup.alpha = 0;
    }
   
    private void OnNewGame()
    {
        _canvasGroup.alpha = 1;
    }
}
