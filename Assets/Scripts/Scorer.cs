using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {   
        // Included plane conditional, collision detected traversing the plane
        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "Plane")
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: "+ hits);
        }   
    }
}
