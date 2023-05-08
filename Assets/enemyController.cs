using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//なめだるまジャン
public class enemyController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル)")]
    //仮追加
    private ParticleSystem particle;
    public AudioClip clip;
    public AudioClip clip1;

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
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }

    }
}
