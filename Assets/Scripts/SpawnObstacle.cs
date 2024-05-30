using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject prefab;

    public float spawnTime;
    private float timeCount;
    private bool speedIncreased = false;
    private bool speedIncreased2 = false;
    private bool speedIncreased3 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aumentarSpawnTime();
        timeCount += Time.deltaTime;

        if(timeCount >= spawnTime)
        {
            GameObject go = Instantiate(prefab, transform.position, transform.rotation);
            Destroy(go, 12f);
            timeCount = 0;
        }
    }

    void aumentarSpawnTime()
    {
        if (GameController.instance.level == 3 && !speedIncreased)
        {
            spawnTime = 2.8f;
            speedIncreased = true;
        }

         if (GameController.instance.level == 5 && !speedIncreased2)
        {
            spawnTime = 2.6f;
            speedIncreased = false;
            speedIncreased2 = true;
        }

         if (GameController.instance.level == 7 && !speedIncreased3)
        {
            spawnTime = 2.5f;
            speedIncreased = false;
            speedIncreased2 = false;
            speedIncreased3 = true;
        }
    }
}
