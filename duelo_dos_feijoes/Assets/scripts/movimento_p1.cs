using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.UIElements;

public class movimento_p1 : MonoBehaviour
{
    public GameObject vida;
    public GameObject arma;
    public Rigidbody2D rb;
    public bool p1morto = false;
    public float velocidade = 5f;
    public float rotacao = 45f;
    public float movimento_y;
    public float rotacao_x;
    public GameObject imagem;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        p1morto = vida.GetComponent<vida>().player1morto;
        if (p1morto == false)
        {
            rotacao_x = (Input.GetAxisRaw("Horizontal"));
            movimento_y = (Input.GetAxisRaw("Vertical"));
            transform.Translate(0, movimento_y * velocidade * Time.deltaTime, 0);
            transform.Rotate(0, 0, -rotacao_x * rotacao * Time.deltaTime);


            if (movimento_y != 0 || rotacao_x != 0)
            {
                imagem.GetComponent<Animator>().SetBool("movendo", true);
            }
            else
            {
                imagem.GetComponent<Animator>().SetBool("movendo", false);
            }
        }
        else
        {
            imagem.GetComponent<Animator>().SetTrigger("morto");
        }
    }
}