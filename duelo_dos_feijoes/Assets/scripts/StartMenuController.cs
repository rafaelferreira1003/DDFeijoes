using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenuController : MonoBehaviour
{

    public GameObject transition;

    List<string> cenas = new List<string> { "game", "Mapa2", "Mapa3"};

    void Start()
    {
     
    }
    public void OnStartClick()
    {
        StartCoroutine(OnStart(cenas[Random.Range(0, 3)]));
    }

    public IEnumerator OnStart(string cena)
    { 
        transition.GetComponent<Animator>().SetTrigger("transition");   
         yield return new WaitForSeconds(1.4f);
        {
            SceneManager.LoadScene(cena);
        }
    }

    public void OncreditosClick()
    {
        StartCoroutine(OnStart("creditos"));
    }

    public void OnTutorialClick()
    {
        StartCoroutine(OnStart("Tutorial"));
    }


    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif 
        Application.Quit();
    }
}
