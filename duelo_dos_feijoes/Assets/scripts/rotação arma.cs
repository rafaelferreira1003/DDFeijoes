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
        angle = Mathf.RoundToInt(parentTransform.rotation.z);

  
        if (angle < 1)
        {
            spriteRenderer.flipX = true;

        }
        else
        {
            spriteRenderer.flipX = false;

        }
    }
}
