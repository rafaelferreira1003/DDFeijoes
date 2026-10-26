using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gerenciador_ : MonoBehaviour
{
    public ParticleSystem particulas;
   
   
    void Start()
    {
        particulas = gameObject.GetComponent<ParticleSystem>();
        var ms = particulas.emission;
        ms.enabled = false;
    }

    // Upate is called once per frame

}
