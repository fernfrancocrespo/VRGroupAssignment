using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisObject : MonoBehaviour {

    public float secondsBeforeDestruction;
   

	
	// Update is called once per frame
        void Update () {

        //if timer is not =1 
        if (secondsBeforeDestruction > 0)
        {
            secondsBeforeDestruction -= Time.deltaTime;
        }
        else
        {
           
            Destroy(this.gameObject);
        }
    }
}
