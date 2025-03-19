using UnityEngine;
using UnityEngine.SceneManagement;

public class voititScript : MonoBehaviour
{
    public void yritaGame()
    {
        SceneManager.LoadScene(2);
    }
    public void takaisinMenu()
    {
        SceneManager.LoadScene(0);
    }
}
