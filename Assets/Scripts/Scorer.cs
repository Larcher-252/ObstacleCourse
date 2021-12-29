using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitScore = 0;

    private void OnCollisionEnter(Collision other) 
    {
        hitScore++;
        Debug.Log("You have bumped into a thing this many times: " + hitScore);
    }
}
