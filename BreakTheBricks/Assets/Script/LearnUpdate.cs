using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnUpdate : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Debug.Log(Time.deltaTime);
        //Debug.Log("FPS:" + 1 / Time.deltaTime); // FPS frame per secound
    }

    // 上次调用到当前调用的时间
    private void FixedUpdate() {
        //Debug.Log(Time.deltaTime);
        //Debug.Log("FPS:" + 1 / Time.deltaTime); // FPS frame per secound
    }
}
