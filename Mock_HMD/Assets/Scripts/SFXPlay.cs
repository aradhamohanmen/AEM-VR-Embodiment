using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SFXPlay : MonoBehaviour 
{
	public AudioSource GlassBreakSFX;
	void OnTriggerEnter ()
	{
			GlassBreakSFX.Play();
	}
		
}
