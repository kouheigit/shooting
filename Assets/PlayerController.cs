using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//animation start
public class PlayerController : MonoBehaviour
{

    public GameObject bulletPrefab;
    GameObject director;



    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル)")]
    //仮追加
    private ParticleSystem particle;
    public AudioClip clip;
    public AudioClip clip1;
    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //GetComponent<AudioSource>().Play();
            transform.Translate(0, 0.2f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.2f, 0);
           // GetComponent<ParticleSystem>().Play();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.2f, 0, 0);
        }
        //弾の発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(clip1, transform.position);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //プレイヤーが破壊された時の動作
        if (collision.gameObject.tag == "Enemy")
        {
            ParticleSystem newParticle = Instantiate(particle);
            // パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
            newParticle.transform.position = this.transform.position;
            // パーティクルを発生させる。
            newParticle.Play();
            // インスタンス化したパーティクルシステムのGameObjectを削除する。(任意)
            // ※第一引数をnewParticleだけにするとコンポーネントしか削除されない。
            Destroy(newParticle.gameObject, 5.0f);
            //GameDirectorからコルーチンを呼び出す
            this.director.GetComponent<GameDirector>().Show();
            //試し
            this.director.GetComponent<GameDirector>().Subremain();
        }
        AudioSource.PlayClipAtPoint(clip, transform.position);
        Destroy(gameObject);
        //コルーチンテストメソットGameOverメソットだけ起動してコルーチンメソットのSampleメソットは起動しない
    }

}

