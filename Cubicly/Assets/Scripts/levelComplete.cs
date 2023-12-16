using UnityEngine;
using UnityEngine.SceneManagement;
public class levelComplete : MonoBehaviour
{
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
