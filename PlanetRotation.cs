using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        move = new Vector3(0, 0, 60);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(move * Time.deltaTime);
    }
}
