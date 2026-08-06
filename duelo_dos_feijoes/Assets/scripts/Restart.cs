using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    private string sceneName = "menu";

    private KeyCode loadKey = KeyCode.R;

    private void Update()
    {
        if (Input.GetKeyDown(loadKey))
        {
            if (!string.IsNullOrEmpty(sceneName))
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
