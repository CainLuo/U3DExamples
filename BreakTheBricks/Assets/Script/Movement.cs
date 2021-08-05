using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Movement : MonoBehaviour {

    public int speed = 1;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Time.deltaTime 代表的是每帧的时间
        // 运动距离 = 速度 * 时间
        transform.Translate( new Vector3(h, v, 0) * speed * Time.deltaTime);
    }
}
