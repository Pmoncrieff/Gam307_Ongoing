using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public static int enemyCount = 0;
    public static float rotateSpeed = 5;

	// Use this for initialization
	void Start () {

        EnemyManager.instance.enemyCount++;
        
        //StartCoroutine(FadeMe());
        enemyCount++;
	}

    private void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);
    }

    void OnMouseDown()
    {
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {

        for (float f = 1f; f >= 0; f -= 0.01f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.b = f;
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }
        yield return new WaitForSeconds(2);
        EnemyManager.instance.enemyCount--;
        EnemyManager.instance.SpawnEnemy;
        GameManager.instance.score += 100;
        Destroy(this.gameObject);
    }
}
