using Unity.VisualScripting;
using UnityEngine;

public class arbusto : MonoBehaviour
{
    public Transform minpos;
    public Transform maxpos;
    public GameObject arbustoPrefab;
    public float spawnInterval = 3f;
    public float spawnTimer = 0f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > spawnInterval)
        {
            spawnTimer = 0f;
            spawnInterval = Random.Range(2.3f, 4.5f);
            float randomy = Random.Range(minpos.position.y, maxpos.position.y);
            Instantiate(arbustoPrefab, new Vector2(transform.position.x, randomy), Quaternion.identity);
        }
        else
        {
            spawnTimer += Time.deltaTime;
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

