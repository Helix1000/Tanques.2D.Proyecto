using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{
    public GameObject plano;
    public void Empezar(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void plane()
    {
        plano.SetActive(true); 
    }

}
