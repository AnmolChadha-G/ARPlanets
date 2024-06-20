using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlanetObject;
    public Vector3 RotationVector;
    // Update is called once per frame
    void Update()
    {
        PlanetObject.transform.Rotate(RotationVector*Time.deltaTime);
    }
}
