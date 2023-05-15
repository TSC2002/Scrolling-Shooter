using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telaraña : MonoBehaviour
{

    public float Speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemigo = collision.collider.GetComponent<DañoAlEnemigo>();
        if (enemigo)
        {
            enemigo.Takehit(1);
        }

        Destroy(gameObject);
    }
}
