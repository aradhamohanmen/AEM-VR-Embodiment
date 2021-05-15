using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade_Ak : MonoBehaviour
{
    public float delay = 3f;
    public GameObject explosionEffect;
    float countdown;
    bool hasExploded = false;
    void Start ()
    {
        countdown = delay;
    }

    void Update ()
    {
       countdown -= Time.deltaTime;
       if (countdown <= 0f && hasExploded==false)
        {
           Explode();
           hasExploded = true;
        }

    }
    void Explode ()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Destroy(gameObject);

    }
    
}


