using UnityEngine;

public class spawnar_gerenciador_de_pontos : MonoBehaviour
{
    public GameObject gerenciador_de_pontos_prefab;
    public GameObject PointMane;
    void Awake()
    {
        PointMane = GameObject.FindWithTag("PointMane");
        if (PointMane == null)
        {
            Instantiate(gerenciador_de_pontos_prefab);
        }
    }

   
    void Update()
    {
        
    }
}
