using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static int remainingBullets;

    // Start is called before the first frame update
    void Start()
    {
        remainingBullets -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0.7f, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
