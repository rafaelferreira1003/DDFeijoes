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
    public float speed = 5f;
    public float eixoY = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        p1morto = vida.GetComponent<vida>().player1morto;
        if (p1morto == false)
        {
            eixoY = (Input.GetAxisRaw("Vertical")) * speed;
            transform.position = new Vector2(transform.position.x, transform.position.y + eixoY * Time.deltaTime);
            transform.rotation = (arma.transform.rotation);
        }
        else
        {
            GetComponent<Animator>().SetTrigger("morto");
        }
    }
}