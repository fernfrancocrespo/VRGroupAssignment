using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearObject : MonoBehaviour {
    public float ActivateAfter;
    private bool appear = false;
    public GameObject message;

    // Use this for initialization
    private void Start()
    {   
    }
   
   

    // Update is called once per frame
    void Update () {
         if (ActivateAfter>0)
         {
            message.SetActive(false);
             ActivateAfter -= Time.deltaTime;
         }
         else if (ActivateAfter<=0)
         { message.SetActive(true);
        }

     
        
		
	}
}
