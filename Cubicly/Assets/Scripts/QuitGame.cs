using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Game Over...");
    }
}
