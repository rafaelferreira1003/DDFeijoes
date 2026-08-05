using JetBrains.Annotations;
using UnityEngine;

public class rotacao_p1 : MonoBehaviour
{
   


    // Update is called once per frame
    void Update()
    {

        transform.localRotation = Quaternion.Inverse(transform.parent.rotation);

    }
}
