using JetBrains.Annotations;
using UnityEngine;

public class rotacao_armap1 : MonoBehaviour
{

    public Transform parentTransform;
    public SpriteRenderer spriteRenderer;
    public float angle;

    // Update is called once per frame
    void Update()
    {
        angle = parentTransform.eulerAngles.z;

  
        if (angle > 160 || angle < -90 )
        {
            spriteRenderer.flipX = true;

        }
        else
        {
            spriteRenderer.flipX = false;

        }
    }
}
