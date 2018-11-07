using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Utility
{
    public class AutoMoveAndRotateOriginal : MonoBehaviour
    {
        public Vector3andSpace moveUnitsPerSecond;
        public Vector3andSpace rotateDegreesPerSecond;
        public bool ignoreTimescale;
        private float m_LastRealTime;
        private Boolean updateOn = true;
        public float howLongToWait;


        private void Start()
        {
            StartCoroutine(updateOff());
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
            IEnumerator updateOff()
        {
            yield return new WaitForSeconds(howLongToWait);
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
