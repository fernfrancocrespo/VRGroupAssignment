using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Utility
{
    public class AutoMoveAndRotate : MonoBehaviour
    {
        public Vector3andSpace moveUnitsPerSecond;
        public Vector3andSpace rotateDegreesPerSecond;
        public bool ignoreTimescale;
        private float m_LastRealTime;
        private Boolean updateOn = false;
        private float timer = 0;
        public float eachWait;
        public float moveFor;




        private void Start()
        {
             
           
     
                StartCoroutine(updateStart(timer=timer+eachWait));
                StartCoroutine(updateStop(timer+moveFor));

            StartCoroutine(updateStart(timer = timer + eachWait));
            StartCoroutine(updateStop(timer + moveFor));

            StartCoroutine(updateStart(timer = timer + eachWait));
            StartCoroutine(updateStop(timer + moveFor));

            StartCoroutine(updateStart(timer = timer + eachWait));
            StartCoroutine(updateStop(timer + moveFor));

            StartCoroutine(updateStart(timer = timer + eachWait));
            StartCoroutine(updateStop(timer + moveFor));

            StartCoroutine(updateStart(timer = timer + eachWait));
            StartCoroutine(updateStop(timer + moveFor));





            m_LastRealTime = Time.realtimeSinceStartup;
            
        }


        // Update is called once per frame
        private void Update()
        {
            if (updateOn == true)
            {
                float deltaTime = Time.deltaTime;
                if (ignoreTimescale)
                {
                    deltaTime = (Time.realtimeSinceStartup - m_LastRealTime);
                    m_LastRealTime = Time.realtimeSinceStartup;
                }
                transform.Translate(moveUnitsPerSecond.value * deltaTime, moveUnitsPerSecond.space);
                transform.Rotate(rotateDegreesPerSecond.value * deltaTime, moveUnitsPerSecond.space);
            }
        }
           

            IEnumerator updateStart(float time)
        {
            yield return new WaitForSeconds(time);
          
            updateOn = true;
        }
        IEnumerator updateStop(float timeStop)
        {
            yield return new WaitForSeconds(timeStop);
            updateOn = false;
        }

        [Serializable]
        public class Vector3andSpace
        {
            public Vector3 value;
            public Space space = Space.Self;
        }
    }
}
