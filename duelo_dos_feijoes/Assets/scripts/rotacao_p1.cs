using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class rotacao_p1 : MonoBehaviour
{
    public Vector3 rotacao = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(rotacao);
    }
}
