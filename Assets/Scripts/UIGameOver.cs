using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    
    void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0;

        Events.OnNewGameEvent += OnNewGame;
        Events.OnGameOverEvent += OnGameOver;
    }

    private void OnDestroy()
    {
        Events.OnNewGameEvent -= OnNewGame;
        Events.OnGameOverEvent -= OnGameOver;
    }
    
    private void OnNewGame()
    {
        _canvasGroup.alpha = 0;
    }
   
    private void OnGameOver()
    {
        _canvasGroup.alpha = 1;
    }
}
