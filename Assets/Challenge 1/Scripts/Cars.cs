using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    public float speed;
    public string inputID;
    private Vector3 position; 
    // Start is called before the first frame update
    void Start()
    {
        if(inputID == "car1") {
            position = new Vector3(-3, 0, 183);
        }else {
            position = new Vector3(5, 1, 183);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(transform.position.z <= -16){
            transform.position = position;
        }
    }
}
