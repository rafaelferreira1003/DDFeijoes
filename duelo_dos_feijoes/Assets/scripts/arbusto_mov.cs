using UnityEngine;
using UnityEngine.Audio;

public class arbusto_mov : MonoBehaviour
{
    public int velocidade = 5;
    public GameObject vida;
    public GameObject medkit;
    public GameObject cartucho;
    void Start()
    {
        vida = GameObject.Find("vida");
        medkit = GameObject.Find("medkit");
        cartucho = GameObject.Find("cartucho");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.right * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Player"))
        {
            vida.GetComponent<vida>().player1life = vida.GetComponent<vida>().player1life - 1;
            vida.GetComponent<vida>().animacao_danoP1 = true;
            vida.GetComponent<vida>().UpdateVidaUI();
            Destroy(gameObject);
        }
        if (collision.CompareTag("player2"))
        {
            vida.GetComponent<vida>().player2life = vida.GetComponent<vida>().player2life - 1;
            vida.GetComponent<vida>().animacao_danoP2 = true;
            vida.GetComponent<vida>().UpdateVidaUI();
            Destroy(gameObject);
        }
        if (collision.CompareTag("tiro"))
        {
            Destroy(gameObject);
            levarDano();
        }
       

    }

    public void levarDano()
    {
            int chance = Random.Range(1, 101);
            if (chance > 75)
            {
                int tipo_item = Random.Range(0, 2);
                if (tipo_item == 0)
                {
                    Instantiate(medkit, transform.position, Quaternion.identity);
                }
                else if (tipo_item == 1)
                {
                    Instantiate(cartucho, transform.position, Quaternion.identity);
                }
            }
    }
}
