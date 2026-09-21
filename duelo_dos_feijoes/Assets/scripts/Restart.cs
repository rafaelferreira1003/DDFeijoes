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
        if (SceneManager.GetActiveScene().name == "Vitória" || (SceneManager.GetActiveScene().name == "Vitória_1"))
        {
            StartCoroutine(carregar_cena());
            autoLoad = true;
        }
        else
        {
           
            autoLoad = false;
        }
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
            yield return new WaitForSeconds(10f);
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
