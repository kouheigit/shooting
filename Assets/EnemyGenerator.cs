using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    //float span = 0.5f;
    float delta = 0;

    void level(float num)
    {
        float span = num;
        this.delta += Time.deltaTime;
        if (this.delta > span)
        {
            this.delta = 0;
            GameObject go = Instantiate(enemyPrefab);
            int px = Random.Range(-9,9);
            go.transform.position = new Vector3(px, 6, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //難易度　普通
        level(1.0f);

        //難易度　難
        //level(0.5f);

        //難易度　激難
        //level(0.1f);
    }
}
