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
    public bool comecar_musica = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

    }



    void Update()
    {

        
           
            if (SceneManager.GetActiveScene().name == "Vitória" || SceneManager.GetActiveScene().name == "Vitória_1" && somTocado == false)
            {

                audioSource.PlayOneShot(som_de_vitoria);
                somTocado = true;
            }

            
       
        if (SceneManager.GetActiveScene().name == "menu" || SceneManager.GetActiveScene().name == "creditos")
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