using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    public Text PointText;
    public int total = 0;
    // Use this for initialization
    void Start()
    {
        //PointText = GameObject.Find("PointText");
        //PointText.GetComponent<Text>().text = "Score:0";
        PointText.text = "Score:0";
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PointText.text = "Score:" + total.ToString();
    }
    void OnCollisionEnter(Collision col)
    {
            if (col.gameObject.tag == "SmallStarTag")
            {
                total += 1;
            } 
            else if (col.gameObject.tag == "LargeStarTag")
            {
                total += 10;
                Handheld.Vibrate();
            }
            else if (col.gameObject.tag == "SmallCloudTag")
            {
                total += 5;
            }
            else if (col.gameObject.tag == "LargeCloudTag")
            {
                total += 50;
                Handheld.Vibrate();
            }
    }   


}