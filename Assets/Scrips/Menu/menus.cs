using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{
    public GameObject planoOtions;

    public GameObject tileMapPlayer;

    public GameObject tilemapExplicacionP1;

    public GameObject tilemapExplicacionP2;

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
        planoOtions.SetActive(true); 

        start.SetActive(false); 
        options.SetActive(false); 
        exit.SetActive(false); 
    }
    public void Deplane()
    {
        planoOtions.SetActive(false);

        start.SetActive(true);
        options.SetActive(true);
        exit.SetActive(true);
    }
    public void TileMap()
    {
        tileMapPlayer.SetActive(true);
        planoOtions.SetActive(false);
    }
    public void DeTileMap()
    {
        tileMapPlayer.SetActive(false);
        planoOtions.SetActive(true);
    }
    public void TileMapExplicacion1()
    {
        tilemapExplicacionP1.SetActive(true);
        tileMapPlayer.SetActive(false);
    }
    public void DeTileMapExplicacion1()
    {
        tilemapExplicacionP1.SetActive(false);
        tileMapPlayer.SetActive(true);
    }
    public void TileMapExplicacion2()
    {
        tilemapExplicacionP2.SetActive(true);
        tileMapPlayer.SetActive(false);
    }
    public void DeTileMapExplicacion2()
    {
        tilemapExplicacionP2.SetActive(false);
        tileMapPlayer.SetActive(true);
    }
}
