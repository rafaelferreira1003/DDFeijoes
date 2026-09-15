using UnityEngine;
using UnityEngine.SceneManagement;

public class tocar_músicas : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject Vida;
    public AudioClip som_de_vitoria;
    public AudioClip som_de_morte;
    public AudioClip música_do_jogo;
    public bool somTocado = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = música_do_jogo;
        audioSource.Play();

    }



    void Update()
    {

        try
        {
            Vida = GameObject.Find("vida");
            if (Vida.GetComponent<vida>().player1morto || Vida.GetComponent<vida>().player2morto && somTocado == false)
            {

                audioSource.PlayOneShot(som_de_morte);
                audioSource.PlayOneShot(som_de_vitoria);
                somTocado = true;
            }

            
        } catch (System.Exception)
        {


        }
        if (SceneManager.GetActiveScene().name == "menu")
        {
            somTocado = false;
            Destroy(gameObject);
        }
    }
}