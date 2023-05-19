using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    //float span = 0.5f;
    float delta = 0;

    //新追加
    GameObject　newpointtext;

    //追加した
    GameObject director;
    //追加した
    

    //追加した(Start メソット)
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

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

        //GameComponentで値を呼び出す時は intメソットにしてreturn値にする。
        int point = this.director.GetComponent<GameDirector>().ShowPoint();

        //Debug.Log(point);

        if (point > 100)
        {
            //難易度　激難
            level(0.1f);
        }else if(point > 50){
            //難易度難
            level(0.3f);
        }else if (point > 10){
            //難易度　普通
            level(0.5f);
        }else{
            //難易度　簡単
            level(1.0f);
        }


     /*
            //難易度　簡単
            level(1.0f);
            
            //難易度　難しい
            　level(0.5f);
        
            //難易度　激難
            level(0.1f);*/
        }
    
}
