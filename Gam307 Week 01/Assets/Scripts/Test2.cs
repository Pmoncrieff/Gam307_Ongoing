using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

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
        for (int i = 0; i < 40; i++)
        {
            cube.transform.Translate(Vector3.right);
            yield return null;
        }
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 30; i++)
        {
            cube.transform.Translate(Vector3.up);
            yield return null;
        }
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 40; i++)
        {
            cube.transform.Translate(Vector3.left);
            yield return null;
        }
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 30; i++)
        {
            cube.transform.Translate(Vector3.down);
            yield return null;
        }
        yield return new WaitForSeconds(1);
    }

}
