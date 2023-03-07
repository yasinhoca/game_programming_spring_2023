using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kapsul;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(kapsul, transform.position, transform.rotation);
        }
        
    }
}
