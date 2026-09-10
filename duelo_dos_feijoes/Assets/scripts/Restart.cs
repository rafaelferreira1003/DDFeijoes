using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Restart : MonoBehaviour
{

    private string sceneName = "menu";

    private KeyCode loadKey = KeyCode.Escape;

    public GameObject transition;

    private void Update()
    {
        if (Input.GetKeyDown(loadKey))
        {
            if (!string.IsNullOrEmpty(sceneName))
            {
                StartCoroutine(carregar_cena());
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public IEnumerator carregar_cena ()
    {
        transition.GetComponent<Animator>().SetTrigger("transition");
        yield return new WaitForSeconds(1.4f);
        {   SceneManager.LoadScene(sceneName);}
      
    }
}
