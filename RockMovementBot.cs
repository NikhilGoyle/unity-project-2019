using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovementBot : MonoBehaviour
{

    public float speed = 1.5f;
    private Rigidbody2D rb;
    public GameObject explosionprefab;
    public Transform location;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-1.5f, 1.5f), speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject boom = Instantiate(explosionprefab, location.position, location.rotation);
        Destroy(gameObject);
        Destroy(boom, 0.2f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
