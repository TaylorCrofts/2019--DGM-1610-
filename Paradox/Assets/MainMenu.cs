using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour 
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void ExitGame()
    {
        print("You've left the game");
        Application.Quit();
    }

}
