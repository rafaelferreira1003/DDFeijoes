using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
   public void OnStartClick()
    {
        SceneManager.LoadScene("game");
    }

    public void OncreditosClick()
    {
        SceneManager.LoadScene("creditos");
    }

    public void OnTutorialClick()
    {
        SceneManager.LoadScene("Tutorial");
    }


    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif 
        Application.Quit();
    }
}
