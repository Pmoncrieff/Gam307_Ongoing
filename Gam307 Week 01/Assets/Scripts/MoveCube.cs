using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    public float speed = 10f;

	// Use this for initialization
	void Start () {

    int rnd = Random.Range(0, 360);
            
        transform.Rotate(new Vector3(0, rnd, 0));

        //transform.Rotate(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
            transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
	    
}
