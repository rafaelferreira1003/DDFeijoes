using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenuController : MonoBehaviour
{

    public GameObject transition;


    public void OnStartClick()
    {
        StartCoroutine(OnStart());
    }

    public IEnumerator OnStart()
    { 
        transition.GetComponent<Animator>().SetTrigger("transition");   
         yield return new WaitForSeconds(1.4f);
        {
            SceneManager.LoadScene("game");
        }
       
       
       
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
