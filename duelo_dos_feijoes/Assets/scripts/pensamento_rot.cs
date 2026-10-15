using UnityEngine;

public class pensamento_rot : MonoBehaviour
{
    public Transform parentTransform;
    void Update()
    {
        transform.position = parentTransform.position + new Vector3(1, 1, 0);
    }
}
