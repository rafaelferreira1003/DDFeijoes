using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Restart : MonoBehaviour
{

    private string sceneName = "menu";

    private KeyCode loadKey = KeyCode.Escape;

    public GameObject transition;

    public bool autoLoad = false;
    private void Start()
    {
       StartCoroutine(carregar_cena());
        autoLoad = true;
    }
   public void Update()
    {
        if (Input.GetKeyDown(loadKey))
        {
            autoLoad = false;
            StartCoroutine(carregar_cena());
        }
    }
    public IEnumerator carregar_cena()
    {
        if (autoLoad)
        {
            yield return new WaitForSeconds(5f);
            {
                transition.GetComponent<Animator>().SetTrigger("transition");
                yield return new WaitForSeconds(1.4f);
                {
                    SceneManager.LoadScene(sceneName);
                }

            }
            
        }
        else
        {
            transition.GetComponent<Animator>().SetTrigger("transition");
            yield return new WaitForSeconds(1.4f);
            { SceneManager.LoadScene(sceneName); }
        }

   
      
    }

}
