using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
   
    [SerializeField] private EventSystem eventSystem;
    [SerializeField] public GameObject firstButton;
    [SerializeField] public GameObject secondButton;

    [SerializeField] public static GameManager Instance;

    [SerializeField] public GameObject buttonNexRaund;
    [SerializeField] public GameObject buttonPlayAgain;
    [SerializeField] public GameObject buttonExit;
    [SerializeField] public GameObject buttonExitToMenu;

    [SerializeField] public GameObject Panel;

    int puntos = 0;
    int puntos2 = 0;

    [Header("Player1")]
    [SerializeField] public GameObject p1, punto1, punto2, punto3;

    [SerializeField] public GameObject win1;

    [SerializeField] public GameObject scoreP1, score1, score2, score3;

    [Header("Player2")]
    [SerializeField] public GameObject p2, punto4, punto5, punto6;

    [SerializeField] public GameObject win2;

    [SerializeField] public GameObject scoreP2, score4, score5, score6;

   
    private void Awake()
    {


        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void GanarRonda()
    {
        puntos++;
        if (puntos == 1)
        {
            Panel.SetActive(true);

            punto1.SetActive(true);
            p1.SetActive(true);

            score1.SetActive(true);
            scoreP1.SetActive(true);

            buttonNexRaund.SetActive(true);
            buttonExit.SetActive(true);
            buttonExitToMenu.SetActive(true);

            StartCoroutine(Pause());
        }
        else if (puntos == 2)
        {
            Panel.SetActive(true);

            punto1.SetActive(true);
            punto2.SetActive(true);
            p1.SetActive(true);

            score1.SetActive(true);
            score2.SetActive(true);
            scoreP1.SetActive(true);

            buttonNexRaund.SetActive(true);
            buttonExit.SetActive(true);
            buttonExitToMenu.SetActive(true);

            StartCoroutine(Pause());
        }
        else if (puntos == 3)
        {
            Panel.SetActive(true);

            punto1.SetActive(true);
            punto2.SetActive(true);
            punto3.SetActive(true);
            p1.SetActive(true);

            score1.SetActive(true);
            score2.SetActive(true);
            score3.SetActive(true);
            scoreP1.SetActive(true);

            buttonPlayAgain.SetActive(true);
            buttonExitToMenu.SetActive(true);
            buttonExit.SetActive(true);

            win1.SetActive(true);

            eventSystem.firstSelectedGameObject = secondButton;


            StartCoroutine(Pause());
        }


    }
    public void GanarRonda2()
    {
        puntos2++;
        if (puntos2 == 1)
        {
            Panel.SetActive(true);

            punto4.SetActive(true);
            p2.SetActive(true);

            score4.SetActive(true);
            scoreP2.SetActive(true);

            buttonNexRaund.SetActive(true);
            buttonExit.SetActive(true);
            buttonExitToMenu.SetActive(true);

            StartCoroutine(Pause());
        }
        else if (puntos2 == 2)
        {
            Panel.SetActive(true);

            punto4.SetActive(true);
            punto5.SetActive(true);
            p2.SetActive(true);

            score4.SetActive(true);
            score5.SetActive(true);
            scoreP2.SetActive(true);

            buttonNexRaund.SetActive(true);
            buttonExit.SetActive(true);
            buttonExitToMenu.SetActive(true);

            StartCoroutine(Pause());
        }
        else if (puntos2 == 3)
        {
            Panel.SetActive(true);

            punto4.SetActive(true);
            punto5.SetActive(true);
            punto6.SetActive(true);
            p2.SetActive(true);

            score4.SetActive(true);
            score5.SetActive(true);
            score6.SetActive(true);
            scoreP2.SetActive(true);

            buttonPlayAgain.SetActive(true);
            buttonExitToMenu.SetActive(true);
            buttonExit.SetActive(true);

            win2.SetActive(true);


            eventSystem.firstSelectedGameObject = secondButton;


            StartCoroutine(Pause());
        }


    }

    public void NexRaund()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


        Panel.SetActive(false);

        punto1.SetActive(false);
        punto2.SetActive(false);
        punto3.SetActive(false);
        punto4.SetActive(false);
        punto5.SetActive(false);
        punto6.SetActive(false);

        p1.SetActive(false);
        p2.SetActive(false);


        buttonNexRaund.SetActive(false);
        buttonExit.SetActive(false);
        buttonExitToMenu.SetActive(false);

    }
    public void PlayAgain()
    {

        Time.timeScale = 1f;

        eventSystem.firstSelectedGameObject = firstButton;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


        puntos = 0;
        puntos2 = 0;


        Panel.SetActive(false);

        punto1.SetActive(false);
        punto2.SetActive(false);
        punto3.SetActive(false);
        punto4.SetActive(false);
        punto5.SetActive(false);
        punto6.SetActive(false);

        p1.SetActive(false);
        p2.SetActive(false);

        scoreP1.SetActive(false);
        scoreP2.SetActive(false);

        score1.SetActive(false);
        score2.SetActive(false);
        score3.SetActive(false);
        score4.SetActive(false);
        score5.SetActive(false);
        score6.SetActive(false);

        buttonPlayAgain.SetActive(false);
        buttonExitToMenu.SetActive(false);
        buttonExit.SetActive(false);

        win1.SetActive(false);
        win2.SetActive(false);
    }
    public void ExitToMenu(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
        Destroy(gameObject);
    }
    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator Pause()
    {
        yield return new WaitForSecondsRealtime(0f);
        Time.timeScale = 0f;
    }
}

