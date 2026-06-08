using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class atirar2 : MonoBehaviour
{
    public float tempo = 0.0f;
    public float municao = 5.0f;
    public bool recarga = true;
    public float cooldown = 1.0f;
    public bool aconteceu = false;
    public float tempoParaRecarga = 6.0f;
    public GameObject tiro;
    public GameObject clone;
    public float velocidade = 6.0f;
    public float movimento_y = 4.0f;
    public bool tiroP2 = false;

    void Start()
    {
        tiro = GameObject.Find("tirop2");
    }


    void Update()
    {

        if (cooldown > 0.0f)
        {
            cooldown -= Time.deltaTime;
        }

        // Tiro
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && recarga && municao > 0.0f && cooldown <= 0.0f)
        {
            Debug.Log("Atirou");
            clone = Instantiate(tiro, gameObject.transform.position, gameObject.transform.rotation);
            clone.tag = "tiro2";

            municao -= 1.0f;
            cooldown = 1.0f;
            tiroP2 = true;
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

        if (clone != null)
        {
            clone.transform.Translate(new Vector3(0, movimento_y, 0) * velocidade * Time.deltaTime);
        }
    }
}
