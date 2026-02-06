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
        }
        else if (puntos == 2)
        {
            punto2.SetActive(true);
            p1.SetActive(true);
            button.SetActive(true);
        }
        else if (puntos == 3)
        {
            punto3.SetActive(true);
            p1.SetActive(true);
            button.SetActive(true);
        }


    }
    public void GanarRonda2()
    {
        puntos2++;
        if (puntos == 1)
        {
            punto4.SetActive(true);
            p2.SetActive(true);
            button.SetActive(true);
        }
        else if (puntos == 2)
        {
            punto5.SetActive(true);
            p2.SetActive(true);
            button.SetActive(true);
        }
        else if (puntos == 3)
        {
            punto6.SetActive(true);
            p2.SetActive(true);
            button.SetActive(true);
        }


    }

    public void Reseteo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

