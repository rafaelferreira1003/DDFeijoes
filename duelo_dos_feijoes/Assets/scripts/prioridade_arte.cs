using UnityEngine;
using UnityEngine.Rendering;

public class prioridade_arte : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool prioridade_da_arte = false;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (PlayerPrefs.GetInt("ocorrencia_de_prioridade") == 0)
        {
           PlayerPrefs.SetInt("ocorrencia_de_prioridade", 0);
        }
    }


    void Update()
    {
       
        if (PlayerPrefs.GetInt("ocorrencia_de_prioridade") == 0 && prioridade_da_arte == false)
        {
            spriteRenderer.sortingOrder = 1;
            PlayerPrefs.SetInt("ocorrencia_de_prioridade", 1);
            prioridade_da_arte = true;
        }
        if (PlayerPrefs.GetInt("ocorrencia_de_prioridade") == 1 && prioridade_da_arte == false)
        { 
            spriteRenderer.sortingOrder = 0;
            prioridade_da_arte = true;
            
        }

         
    }
}
