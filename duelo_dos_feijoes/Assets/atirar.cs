using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class atirar : MonoBehaviour
{
    public float tempo = 0.0f;
    public float municao = 5.0f;
    public bool recarga = true;
    public float cooldown = 1.0f;
    public bool aconteceu = false;
    public float tempoParaRecarga = 5.0f;
    public GameObject tiro;

    void Start()
    {
        tiro = GameObject.Find("tiro");
    }


    void Update()
    {
      
        if (cooldown > 0.0f)
        {
            cooldown -= Time.deltaTime;
        }

        // Tiro
        if (Input.GetKeyDown(KeyCode.Space) && recarga && municao > 0.0f && cooldown <= 0.0f)
        {
            Debug.Log("Atirou");
            Instantiate(tiro, gameObject.transform.position, gameObject.transform.rotation);
            
            municao -= 1.0f;
            cooldown = 1.0f;
        }

      
        if (municao <= 0.0f && !aconteceu)
        {
            recarga = false;
            aconteceu = true;
            tempo = 0.0f;
        }

    
        if (aconteceu)
        {
            tempo += Time.deltaTime;
            if (tempo >= tempoParaRecarga)
            {
                tempo = 0.0f;
                aconteceu = false;
                recarga = true;
                municao = 5.0f;
            }
        }

      
        if (recarga && municao <= 0.0f)
        {
            municao = 5.0f;
        }

    }
}
