using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    public GameObject[] points;
    public Vector3 angle;
    public Vector3 translation;
    public Vector3 scaling;
    public Vector3 shear;
    public GameObject centre;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 c = new Vector3(centre.transform.position.x,
                                centre.transform.position.y,
                                centre.transform.position.z);

        angle = angle * Mathf.Deg2Rad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
