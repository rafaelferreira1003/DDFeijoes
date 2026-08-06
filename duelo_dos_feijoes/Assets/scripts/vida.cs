using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{
    public int player1life = 7;
    public int player2life = 7;
    public bool player1morto = false;
    public bool player2morto = false;
    [SerializeField] TMPro.TMP_Text vidap1Text;
    [SerializeField] TMPro.TMP_Text vidap2Text;
    public float cooldown = 0.5f;
    public float tempo = 0f;


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
    }
}

