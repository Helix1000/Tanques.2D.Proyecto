using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
       
    int puntos = 0;
    public GameObject p1, punto1, punto2, punto3;

    private void Awake()
    {
        Instance = this;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bala"))
        {
            puntos++;
        }
    }
    private void FixedUpdate()
    {
        if (puntos == 1)
        {
            p1.SetActive(true);
            punto1.SetActive(true);
        }
    }
    //IEnumerator Rondas(Collider2D collision)
    //{

    //}

}
