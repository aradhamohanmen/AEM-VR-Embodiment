using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float delay = 3f;
    public float radius = 5f;
    public float force = 700f;
    public GameObject explosionEffect;
    float countdown;
    bool hasExploded = false;
    public AudioSource ExplosionSFX;
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
        ExplosionSFX.Play();
        Destroy(gameObject);
    }
    
}
