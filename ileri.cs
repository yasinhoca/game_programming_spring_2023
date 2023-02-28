using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ileri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.z += 0.01f;
        this.transform.position = position;
    }
}
