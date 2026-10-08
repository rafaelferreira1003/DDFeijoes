using UnityEngine;

public class spawnar_gerenciador_de_pontos : MonoBehaviour
{
    public GameObject gerenciador_de_pontos_prefab;
    public GameObject som_prefab;
    public GameObject PointMane;
    public GameObject som;
    void Awake()
    {
        PointMane = GameObject.FindWithTag("PointMane");
        som = GameObject.FindWithTag("som");
        if (PointMane == null)
        {
            Instantiate(gerenciador_de_pontos_prefab);
        }
        if (som == null)
        {
            Instantiate(som_prefab);
        }

    }

   
    void Update()
    {
        
    }
}
