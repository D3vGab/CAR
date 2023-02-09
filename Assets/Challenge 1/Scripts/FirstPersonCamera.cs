using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject camTwo;
    public bool firstPerson = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && firstPerson == false){
            firstPerson = true;
            camera.SetActive(true);
            camTwo.SetActive(false);
            Debug.Log("First person cam is activated!");
        } else if (Input.GetKeyDown("space") && firstPerson == true){
            firstPerson = false;
            camera.SetActive(false);
            camTwo.SetActive(true);
            Debug.Log("Cam normal is activated!");
        }
    }
}
