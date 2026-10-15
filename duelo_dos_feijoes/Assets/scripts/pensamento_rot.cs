using UnityEngine;

public class pensamento_rot : MonoBehaviour
{
    void Update()
    {
        transform.localRotation = Quaternion.Inverse(transform.parent.rotation);
    }
}
