using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

    // 回転速度
    private float rotSpeed = 1.0f;

    // Use this for initialization
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, this.rotSpeed, 0);
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (tag == "SmallStarTag")
        {
            BallController.score += 5;
        }
        else if (tag == "LargeStarTag")
        {
            BallController.score += 15;
        }
    }
}
