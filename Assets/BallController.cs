using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallController : MonoBehaviour {
    private float visiblePosz = -6.5f;
    private GameObject gameoverText;
	// Use this for initialization
	void Start () {
        this.gameoverText = GameObject.Find("GameOverText");
    }
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z < this.visiblePosz)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
	}
}
