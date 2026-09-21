using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_script : MonoBehaviour
{  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
