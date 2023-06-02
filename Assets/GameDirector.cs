using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject pointText;
    GameObject remainText;

    int point = 0;
    int remain = 3;

    public void AddPoint()
    {
        this.point += 1;
    }
    public void Subremain()
    {
        this.remain -= 1;
    }

    //public intで
    public int ShowPoint()
    {
        int points = this.point;
        return points;
       
    }
    public void Show()
    {
        StartCoroutine("Sample");
    }

     IEnumerator Sample()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("ContinueScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("Point");
        this.remainText = GameObject.Find("Remaining");
    }

    // Update is called once per frame
    void Update()
    {
        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString() + " point";
        //仮追加
        this.remainText.GetComponent<TextMeshProUGUI>().text = this.remain.ToString() + "×"; ;
    }
}
