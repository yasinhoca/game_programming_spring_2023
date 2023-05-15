using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{
    public Joystick joystick;
    public Joybutton joybutton;
    protected bool jump=false;
    // Start is called before the first frame update
    void Start()
    {
     joystick = FindObjectOfType<Joystick>();
     joybutton = FindObjectOfType<Joybutton>();
        Physics.gravity = new Vector3(0f, -30f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal*10f, rigidbody.velocity.y,joystick.Vertical*10f);
        
        if(!jump && joybutton.pressed)
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 10f;
        } else if(jump && !joybutton.pressed)
        {
            jump = false;

        }
    
    }
}
