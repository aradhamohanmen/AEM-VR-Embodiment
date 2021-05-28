using UnityEngine;
using Valve.VR.InteractionSystem;
using System.Collections;
using System.Collections.Generic;


public class LeftHide : MonoBehaviour
{
    public void HideOBJ(GameObject obj)
    {
        obj.GetComponent<Renderer>().enabled = false;
    }

    public void position(GameObject obj)
    {
        Debug.Log("Left=" + obj.transform.position.ToString("F3"));
            }
    public void ShowOBJ(GameObject obj)
    {
        obj.GetComponent<Renderer>().enabled = true;
    }


}