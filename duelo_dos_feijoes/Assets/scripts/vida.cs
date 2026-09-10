
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
    public float cooldown = 0.5f;
    public float tempo = 0f;
    public float animacao_dano_tempoP1 = 0f;
    public float animacao_dano_tempoP2 = 0f;
    public bool animacao_danoP1 = false;
    public bool animacao_danoP2 = false;
    public GameObject transition;

    void Start()
    {
        UpdateVidaUI();
    }
    void Update()
    {
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
        vidap1Text.text = player1life.ToString();
        vidap2Text.text = player2life.ToString();
        mudar_cena();
    }

    public void mudar_cena()
    {
        if (tempo >= cooldown)
        {
            if (player1morto == true)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Vitória");
            }
            else if (player2morto == true)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Vitória_1");
            }
        }

        if (tempo >= cooldown / 2.0f)
        {
            transition.GetComponent<Animator>().SetTrigger("transition");
        }
    }

    
}

