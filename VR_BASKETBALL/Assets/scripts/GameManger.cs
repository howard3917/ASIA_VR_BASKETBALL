using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public void Quitgame()
    {
        Application.Quit();



    }




public void Restartgame()
    {
        SceneManager.LoadScene("basketball");




    }




}
