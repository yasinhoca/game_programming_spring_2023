using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carp : MonoBehaviour
{
    public int puan = 0;
    AudioSource ses;
    public GUIStyle stil;
    // Start is called before the first frame update
    void Start()
    {
        ses = GetComponent<AudioSource>();
        stil.fontSize = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kapsul") {
            Debug.Log("Çarpışma gerçekleşti!");
            Destroy(other.gameObject);
            ses.Play();
            puan += 10;
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Box(new Rect(20, 20, 100, 50), puan.ToString(), stil);
    }

}
