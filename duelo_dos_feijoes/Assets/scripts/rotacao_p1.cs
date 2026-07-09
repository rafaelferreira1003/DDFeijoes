using JetBrains.Annotations;
using UnityEngine;

public class rotacao_p1 : MonoBehaviour
{
    public float velocidaderotacao = 100f;
    public float eixoX = 0f;
    public GameObject player1;
    public Rigidbody2D rig2;

    void Start()
    {
        rig2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        eixoX = Input.GetAxis("Horizontal") * velocidaderotacao;
        transform.RotateAround(player1.transform.position, Vector3.forward, eixoX * Time.deltaTime);
      
    }
}
