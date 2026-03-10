using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject panelpausa;

    private bool isPaused = false;
    public void OnPausa()
    {
        TogglePause();
    }
    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Congela el juego
            panelpausa.SetActive(true);

        }
        else
        {
            Time.timeScale = 1f; // Reanuda el juego
            panelpausa.SetActive(false);

        }
    }
}
