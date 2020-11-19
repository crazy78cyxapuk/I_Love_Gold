using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    [HideInInspector] public float speed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector3(0, speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            MoneySpawn.Instance.DespawnMoney(gameObject, false);
        }

        if (collision.gameObject.CompareTag("Chest"))
        {
            MoneySpawn.Instance.DespawnMoney(gameObject, true);

        }
    }
}
