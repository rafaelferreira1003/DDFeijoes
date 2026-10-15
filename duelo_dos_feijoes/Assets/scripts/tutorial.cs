using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public int tutorialStage_p1 = 0;
    public int tutorialStage_p2 = 0;
    public GameObject pensamento_p1;
    public GameObject pensamento_p2;
    public bool passarParteTutorialp1 = false;
    public bool passarParteTutorialp2 = false;
    List<string> cenas = new List<string> { "game", "Mapa2", "Mapa3" };
    public string cena;


    void Start()
    {
       cena = cenas[Random.Range(0, 3)];
    }
    void Update()
    {
        if (tutorialStage_p1 == 0)
        { 
            pensamento_p1.GetComponent<Animator>().SetFloat("pensamento", 1f);
            if (Input.GetAxisRaw("Vertical") != 0 && passarParteTutorialp1 == true)
            {
                tutorialStage_p1 = 1;
                passarParteTutorialp1 = false;
                StartCoroutine(passar_partep1());
            }
        }
        else if (tutorialStage_p1 == 1)
        {
            pensamento_p1.GetComponent<Animator>().SetFloat("pensamento", 2f);
            if (Input.GetAxisRaw("Horizontal") != 0 && passarParteTutorialp1 == true)
            {
                tutorialStage_p1 = 2;
                passarParteTutorialp1 = false;
                StartCoroutine(passar_partep1());
            }
        }
        else if (tutorialStage_p1 == 2)
        {
            pensamento_p1.GetComponent<Animator>().SetFloat("pensamento", 3f);
            if (Input.GetKeyDown(KeyCode.G) && passarParteTutorialp1 == true)
            {
                tutorialStage_p1 = 3;
                passarParteTutorialp1 = false;
                StartCoroutine(passar_partep1());
                pensamento_p1.GetComponent<Animator>().SetFloat("pensamento", 4f);
            }
        }

        if (tutorialStage_p2 == 0)
        {
            pensamento_p2.GetComponent<Animator>().SetFloat("pensamento", 1f);
            if (Input.GetAxisRaw("Vertical2") != 0 && passarParteTutorialp2 == true)
            {
                tutorialStage_p2 = 1;
                passarParteTutorialp2 = false;
                StartCoroutine(passar_partep2());
            }
        }
        else if (tutorialStage_p2 == 1)
        {
            pensamento_p2.GetComponent<Animator>().SetFloat("pensamento", 2f);
            if (Input.GetAxisRaw("Horizontal2") != 0 && passarParteTutorialp2 == true)
            {
                tutorialStage_p2 = 2;
                passarParteTutorialp2 = false;
                StartCoroutine(passar_partep2());
            }
        }
        else if (tutorialStage_p2 == 2)
        {
            pensamento_p2.GetComponent<Animator>().SetFloat("pensamento", 3f);
            if (Input.GetKeyDown(KeyCode.RightControl) && passarParteTutorialp2 == true)
            {
                tutorialStage_p2 = 3;
                passarParteTutorialp2 = false;
                StartCoroutine(passar_partep2());
                pensamento_p2.GetComponent<Animator>().SetFloat("pensamento", 4f);
            }
        }
        if (tutorialStage_p1 == 3 && tutorialStage_p2 == 3 && passarParteTutorialp2 && passarParteTutorialp1)
        {
            StartCoroutine(comecar_jogo());
        }
    }

   
    
    public IEnumerator passar_partep1()
    {
       yield return new WaitForSeconds(2f);
        {
         passarParteTutorialp1 = true;
        }
    }

    public IEnumerator passar_partep2()
    {
        yield return new WaitForSeconds(2f);
        {
            passarParteTutorialp2 = true;
        }
    }

    public IEnumerator comecar_jogo()
    {
        yield return new WaitForSeconds(5f);
        {
            
        }
    }
}
