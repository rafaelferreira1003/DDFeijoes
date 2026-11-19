using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class musica_menu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip música_do_jogo;
    public bool comecar_musica = false;
   
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "menu" || SceneManager.GetActiveScene().name == "creditos" || SceneManager.GetActiveScene().name == "Tutorial") 
        {
           if (comecar_musica == false)
           {

            audioSource.clip = música_do_jogo;
            audioSource.Play();
            comecar_musica = true;

           }
        }
        else
        {
            comecar_musica = false;
            audioSource.Stop();
        }

    }
}
