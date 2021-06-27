using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControleur : MonoBehaviour
{
    public GameObject joueur;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - joueur.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = joueur.transform.position + offset;
    }
}
