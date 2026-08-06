using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class atirar : MonoBehaviour
{
    public float tempo = 0.0f;
       float municao = 5.0f;
    public bool recarga = true;
    public float cooldown = 0.5f;
    public bool aconteceu = false;
    public float tempoParaRecarga = 5.0f;
    public GameObject tiro;
    public GameObject clone;
    public float velocidade = 6.0f;
    public float movimento_y = 4.0f;
    public bool tiroP1 = false;
    public bool p1morto = false;
    public GameObject vida;
    public GameObject imagem;
    [SerializeField] TMPro.TMP_Text municaoText;

    void Start()
    {
        tiro = GameObject.Find("tirop1");
        municaoText.text = municao.ToString();
    }


    void Update()
    {
        p1morto = vida.GetComponent<vida>().player1morto;
        if (p1morto == false)
        {
            if (cooldown > 0.0f)
            {
                cooldown -= Time.deltaTime;
            }

            // Tiro
            if (Input.GetKeyDown(KeyCode.Space) && recarga && municao > 0.0f && cooldown <= 0.0f)
            {
                Debug.Log("Atirou");
                clone = Instantiate(tiro, gameObject.transform.position, gameObject.transform.rotation);
                clone.tag = "tiro";
                imagem.GetComponent<Animator>().SetBool("atirando", true);
                municao -= 1.0f;
                cooldown = 0.5f;
                tiroP1 = true;
                municaoText.text = municao.ToString();
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
                    municaoText.text = municao.ToString();
                }
            }


            if (recarga && municao <= 0.0f)
            {
                municao = 5.0f;
                municaoText.text = municao.ToString();
            }

            if (clone != null)
            {
                clone.transform.Translate(new Vector3(0, movimento_y, 0) * velocidade * Time.deltaTime);
            }
        }
    }
}
