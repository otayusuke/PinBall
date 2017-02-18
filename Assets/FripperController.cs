using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    private HingeJoint myHingeJoynt;
    private float defaultAngle = 20;
    private float flickAngle = -20;

    // Use this for initialization
    void Start()
    {
        this.myHingeJoynt = GetComponent<HingeJoint>();
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch t in Input.touches)
        {
            switch (t.phase)
            {
                case TouchPhase.Began:
                    if (t.position.x > Screen.width / 2 && tag == "RightFripperTag")
                    {
                        SetAngle(flickAngle);
                    }
                    else if (t.position.x < Screen.width / 2 && tag == "LeftFripperTag")
                    {
                        SetAngle(flickAngle);
                    }
                    break;
                case TouchPhase.Ended:
                    if (t.position.x > Screen.width / 2 && tag == "RightFripperTag")
                    {
                        SetAngle(defaultAngle);
                    }else if (t.position.x < Screen.width / 2 && tag == "LeftFripperTag")
                    {
                        SetAngle(defaultAngle);
                    }
                        break;
            }
        }
    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoynt.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoynt.spring = jointSpr;
    }
}