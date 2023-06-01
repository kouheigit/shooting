using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject pointText;
    int point = 0;

    public void AddPoint()
    {
        this.point += 1;
    }
    //public int で
    public int ShowPoint()
    {
        int points = this.point;
        return points;
       
    }
    public void Show()
    {
        Debug.Log("呼ばれた");
        StartCoroutine("Sample");
    }
    //Sample
     IEnumerator Sample()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("コルーチン成功");
        //ここのメゾットに処理をしたいのではなく
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString() + " point";
    }
}
