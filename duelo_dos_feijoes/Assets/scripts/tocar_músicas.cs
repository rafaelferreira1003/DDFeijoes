using UnityEngine;
using UnityEngine.SceneManagement;

public class tocar_músicas : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip som_de_vitoria;
    public AudioClip som_de_derrota;
    public AudioClip música_do_jogo;
    public vida vida;
    public bool somTocado = false;
    public bool comecar_musica = false;
    public bool tocar_som_derrota = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

    }



    void Update()
    {

       
        if (SceneManager.GetActiveScene().name == "menu" || SceneManager.GetActiveScene().name == "creditos" || SceneManager.GetActiveScene().name == "Tutorial" || SceneManager.GetActiveScene().name == "Vitória" || SceneManager.GetActiveScene().name == "Vitória_1")
        {    if (SceneManager.GetActiveScene().name == "Vitória" && somTocado == false || SceneManager.GetActiveScene().name == "Vitória_1" && somTocado == false)
            {
                audioSource.PlayOneShot(som_de_vitoria);
                somTocado = true;
            }}
        else
        { if (vida == null)
         {
            vida = GameObject.Find("vida").GetComponent<vida>();
         }

         

            if (vida.player1morto == true && tocar_som_derrota == false || vida.player2morto == true && tocar_som_derrota == false)
            {
                audioSource.PlayOneShot(som_de_derrota);
                tocar_som_derrota = true;
            }
        }
            
       
        if (SceneManager.GetActiveScene().name == "menu" || SceneManager.GetActiveScene().name == "creditos" || SceneManager.GetActiveScene().name == "Tutorial")
        {
            somTocado = false;
            audioSource.Stop();
            comecar_musica = false;
        }
        else if (comecar_musica == false)
        {
          
                audioSource.clip = música_do_jogo;
                audioSource.Play();
                comecar_musica = true;

        }

    }
}