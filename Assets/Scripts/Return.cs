using System;
using UnityEngine;

public class Return : MonoBehaviour
{
    public Transform targetDestination;
    public GameObject deadCat;
    public GameObject playerObject;

    public PlayerMovement playerPosition;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject copy = Instantiate(deadCat);
            // I'm having trouble with the 
            other.transform.position = targetDestination.position;
        }
    }
}
