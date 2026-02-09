using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject button;

    int puntos = 0;
    int puntos2 = 0;

    [Header("Player1")]
    public GameObject p1, punto1, punto2, punto3;

    [Header("Player2")]
    public GameObject p2, punto4, punto5, punto6;

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
            punto1.SetActive(true);
            p1.SetActive(true);
            button.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (puntos == 2)
        {
            punto1.SetActive(true);
            punto2.SetActive(true);
            p1.SetActive(true);
            button.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (puntos == 3)
        {
            punto1.SetActive(true);
            punto2.SetActive(true);
            punto3.SetActive(true);
            p1.SetActive(true);
            button.SetActive(true);
            Time.timeScale = 0f;
        }


    }
    public void GanarRonda2()
    {
        puntos2++;
        if (puntos2 == 1)
        {
            punto4.SetActive(true);
            p2.SetActive(true);
            button.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (puntos2 == 2)
        {
            punto4.SetActive(true);
            punto5.SetActive(true);
            p2.SetActive(true);
            button.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (puntos2 == 3)
        {
            punto4.SetActive(true);
            punto5.SetActive(true);
            punto6.SetActive(true);
            p2.SetActive(true);
            button.SetActive(true);
            Time.timeScale = 0f;
        }


    }

    public void Reseteo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1f;

        punto1.SetActive(false);
        punto2.SetActive(false);
        punto3.SetActive(false);
        punto4.SetActive(false);
        punto5.SetActive(false);
        punto6.SetActive(false);

        p1.SetActive(false);
        p2.SetActive(false);


        button.SetActive(false);


    }
}

