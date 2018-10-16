using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoTest : MonoBehaviour {

    public GameObject cube;

    // Use this for initialization
    void Start()
    {

        //StartCoroutine(TestText());

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Do something BEFORE the Coroutine");
            StartCoroutine(MoveCube());
            Debug.Log("Do something AFTER the Coroutine");
        }

    }

    IEnumerator MoveCube()
    {
        for (int i = 0; i < 500; i++)
        {
            cube.transform.Translate(Vector3.forward * Time.deltaTime);
            yield return null;
        }
        Debug.Log("FINISHED");
    }

    /*IEnumerator TestText()
    {
        Debug.Log("Frame 0");
        yield return null;
        Debug.Log("Frame 1");
        yield return null;
        Debug.Log("Frame 2");
        yield return null;
        Debug.Log("Frame 3");
    }*/
}
