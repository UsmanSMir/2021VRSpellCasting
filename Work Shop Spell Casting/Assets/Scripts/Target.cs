using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    void OnParticleCollision(GameObject other)
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
}
