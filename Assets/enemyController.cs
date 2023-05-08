using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//なめだるまジャン
public class enemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0.15f,0);
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
        
    }
}
