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

    public void ShowPoint()
    {
        int points = this.point;
        Debug.Log(points);
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
