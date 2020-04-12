using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageArea : MonoBehaviour
{
    public float Damage { get; set; }

    private void Start()
    {
        Damage = 1f;
    }

    private void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.CompareTag("Enemie"))
        {
            other.gameObject.GetComponent<HealthEnemie>().DamageMe(Damage);
        }
    }
}
