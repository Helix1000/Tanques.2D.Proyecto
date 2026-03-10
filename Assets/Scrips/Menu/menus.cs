using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{
    public GameObject plano;

    public GameObject tilemap;

    public GameObject start, options, exit;

    public void Empezar(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Plane()
    {
        plano.SetActive(true); 

        start.SetActive(false); 
        options.SetActive(false); 
        exit.SetActive(false); 
    }
    public void Deplane()
    {
        plano.SetActive(false);

        start.SetActive(true);
        options.SetActive(true);
        exit.SetActive(true);
    }
    public void TileMap()
    {
        tilemap.SetActive(true);
        plano.SetActive(false);
    }
    public void DeTileMap()
    {
        tilemap.SetActive(false);
        plano.SetActive(true);
    }
}
