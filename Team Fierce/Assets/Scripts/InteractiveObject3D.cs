using UnityEngine;
using System.Collections;


public class InteractiveObject3D : MonoBehaviour
{
    public GameObject message;

    void Start()
    {
        //message = GameObject.FindGameObjectWithTag("Bubble1");
        message.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            TurnOnMessage();
        }
    }

    private void TurnOnMessage()
    {
        message.SetActive(true);
    }


    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            TurnOffMessage();
        }
    }

    private void TurnOffMessage()
    {
        message.SetActive(false);
    }
}
