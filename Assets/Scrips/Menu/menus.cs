using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{
    public void Empezr(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
   public void Salir()
    {
        Application.Quit();
    }
    
}
