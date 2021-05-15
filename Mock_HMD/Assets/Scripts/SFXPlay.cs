using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SFXPlay : MonoBehaviour 
{
	public AudioSource Explosion;
    public void PlayExplosion() => Explosion.Play();

}
