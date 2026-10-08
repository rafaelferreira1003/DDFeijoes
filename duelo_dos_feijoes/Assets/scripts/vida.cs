
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{
    [Min(0)]public int player1life = 7;
    [Min(0)]public int player2life = 7;
    public bool player1morto = false;
    public bool player2morto = false;
    [SerializeField] TMPro.TMP_Text vidap1Text;
    [SerializeField] TMPro.TMP_Text vidap2Text;
    public SpriteRenderer player1;
    public SpriteRenderer player2;
    public PointMane pointmaneger;
    public float cooldown = 0.5f;
    public float tempo = 0f;
    public float animacao_dano_tempoP1 = 0f;
    public float animacao_dano_tempoP2 = 0f;
    public bool animacao_danoP1 = false;
    public bool animacao_danoP2 = false;
    public GameObject transition;
    public bool som_tocando = false;
    public bool rodar_random = true;
    public Scene Tutorial;
    public GameObject som;
    public AudioClip som_de_morte;

    void Start()
    {
        UpdateVidaUI(); 
        try
        {
            pointmaneger = GameObject.FindWithTag("PointMane").GetComponent<PointMane>();
            som = GameObject.FindWithTag("som");
            som_de_morte = som.GetComponent<tocar_músicas>().som_de_morte;
        }
        catch
        { }
       

    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == ("Tutorial"))
        {
            player1life = 999999999;
            player2life = 999999999;
        }

        if (player1life <= 0)
        {
           player1morto = true;
            tempo += Time.deltaTime;
            mudar_cena();
           
        }

        if (player2life <= 0)
        {
            player2morto = true;
            tempo += Time.deltaTime;
            mudar_cena();
        }

        if (animacao_danoP1 == true)
        {
            animacao_dano_tempoP1 += Time.deltaTime;
            player1.color = Color.indianRed;
            if (animacao_dano_tempoP1 >= 0.2f)
            {
                player1.color = Color.white;
                animacao_danoP1 = false;
                animacao_dano_tempoP1 = 0f;
            }
        }

        if (animacao_danoP2 == true)
        {
            animacao_dano_tempoP2 += Time.deltaTime;
            player2.color = Color.indianRed;
            if (animacao_dano_tempoP2 >= 0.2f)
            {
                player2.color = Color.white;
                animacao_danoP2 = false;
                animacao_dano_tempoP2 = 0f;
            }
        }

    }


    public void UpdateVidaUI()
    {
        try
        {
            vidap1Text.text = player1life.ToString();
            vidap2Text.text = player2life.ToString();
            mudar_cena();
        }
        catch
        { }
    }
    public void mudar_cena()
    {
       som.GetComponent<AudioSource>().PlayOneShot(som_de_morte);
        if (tempo >= cooldown && rodar_random)
        {
            if (player1morto == true)
            {
                pointmaneger.player2Points++;
               

            }
            else if (player2morto == true)
            {
                pointmaneger.player1Points++;
               

            }
           
            StartCoroutine(pointmaneger.OnStart());
            rodar_random = false;
            
          
        }


        if (tempo >= cooldown / 2.0f)
        {
            transition.GetComponent<Animator>().SetTrigger("transition");
        }
    }

    
}

