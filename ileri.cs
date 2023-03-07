using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ileri : MonoBehaviour
{
    int durum = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 position = transform.position;
        if(durum==1) position.z += 0.05f;
        if (position.z >= 10f) durum = 0;
        if(durum==0) position.z -= 0.05f;
        if (position.z <= 0f) durum = 1;
        this.transform.position = position;*/

        

        //if (position.z >= 10) Destroy(gameObject);

        //Destroy(gameObject, 3); //3 saniye sonra sil

        if (Input.GetKey(KeyCode.UpArrow)) {
            Vector3 position = transform.position;
            position.z += 0.05f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = transform.position;
            position.z -= 0.05f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = transform.position;
            position.x += 0.05f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = transform.position;
            position.x -= 0.05f;
            this.transform.position = position;
        }

    }
}
