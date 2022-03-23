using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public BirdScript bs;
    public GameObject pipes;
    public float time;

    public float height;

    public void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!bs.isDead)
        {
            Instantiate(pipes, new Vector3(2, Random.Range(-height, height),0), Quaternion.identity);
            yield return new WaitForSeconds(time);

        }  

    }

}
