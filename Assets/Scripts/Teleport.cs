using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Destination;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 translation =  Destination.transform.position - other.transform.position;
            other.GetComponent<CharacterController>().Move(translation);
        }
    }
}
