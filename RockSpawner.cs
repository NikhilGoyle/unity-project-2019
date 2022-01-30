using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    public GameObject rock;
    float randX;
    public Transform where;
    Vector2 whereToSpawn;
    public float spawnRate = 5f;
    float nextSpawn = 0.0f;
    float count = 0;


    // Update is called once per frame
    void Update()
    {
        
        count += 1f;
        if (count > 10f) {
            spawnRate -= .010f;
            count = 0f;
        }
        if (spawnRate < .12f)
        {
            spawnRate = .12f;
        }
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-9f, 9f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(rock, whereToSpawn, where.rotation);
            Rigidbody2D rb = rock.GetComponent<Rigidbody2D>();
            rb.AddForce(where.up * 4f, ForceMode2D.Impulse);
        }
    }
}
