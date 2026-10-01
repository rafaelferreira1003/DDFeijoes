using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class PointMane : MonoBehaviour
{
    public int player1Points;
    public int player2Points;
    public int rounds;
    public List<string> cenas = new List<string> { "game", "Mapa2", "Mapa3", "Mapa4" };
    public GameObject transition;
    public bool vitoria_ocorreu = false;
    [SerializeField] TMPro.TMP_Text pontos_p1;
    [SerializeField] TMPro.TMP_Text pontos_p2;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }
    public void Update()
    {
        if (rounds >= 5 || player1Points > 2 || player2Points > 2)
        {
            if (player1Points > player2Points && !vitoria_ocorreu)
            {
               SceneManager.LoadScene("Vitória_1");
                vitoria_ocorreu = true;
            }
            else if (player2Points > player1Points && !vitoria_ocorreu)
            {
                SceneManager.LoadScene("Vitória");
                vitoria_ocorreu = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "menu")
        {
            player1Points = 0;
            player2Points = 0;
            rounds = 0;
            vitoria_ocorreu = false;
        }

        if (transition == null)
        {
            transition = GameObject.FindWithTag("transition");
        }
        if (SceneManager.GetActiveScene().name != "menu" && SceneManager.GetActiveScene().name != "tutorial")
        {
            if (pontos_p1 == null)
            {
                pontos_p1 = GameObject.FindWithTag("pontos_p1").GetComponent<TMP_Text>();
            }
            if (pontos_p2 == null)
            {
                pontos_p2 = GameObject.FindWithTag("pontos_p2").GetComponent<TMP_Text>();
            }
            pontos_p1.text = player1Points.ToString();
            pontos_p2.text = player2Points.ToString();
        }
        
    }

    public IEnumerator OnStart()
    {
        transition.GetComponent<Animator>().SetTrigger("transition");
        rounds++;
        yield return new WaitForSeconds(1.4f);
        {
            SceneManager.LoadScene(cenas[Random.Range(0, 4)]);
        }
    }

}

