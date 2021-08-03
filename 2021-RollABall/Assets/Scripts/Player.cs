using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Rigidbody rd;

    public int score = 0;

    public Text scoreText;
    public GameObject winText;

    // Start is called before the first frame update
    void Start() {
        //Debug.Log("游戏开始了");

        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log("游戏正在运行");
        // Vector3, right left forward back
        // 自定义新的向量，new Vector3(x,y,z)
        //rd.AddForce(Vector3.right);

        // 监听键盘横向方向
        float h = Input.GetAxis("Horizontal") * 2;
        float v = Input.GetAxis("Vertical") * 2;
        //float y = Input.GetAxis("Jump");
        //Debug.Log(h);
        //Debug.Log(v);
        rd.AddForce(new Vector3(h,0,v));
    }

    // 进入碰撞区域
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("发生碰撞了 OnCollisionEnter");

        // 通过组件获得食物标签
        //if (collision.collider.tag == "Food") {
            //销毁组件
            //Destroy(collision.collider);
        //}

        // 通过游戏物体获得食物标签
        if (collision.gameObject.tag == "Food") {
            // 销毁游戏物体
            Destroy(collision.gameObject);
        }
    }

    // 
    //private void OnCollisionStay(Collision collision) {
    //    Debug.Log("发生碰撞了 OnCollisionStay");
    //}

    // 离开碰撞区域
    //private void OnCollisionExit(Collision collision) {
    //    Debug.Log("发生碰撞了 OnCollisionExit");
    //}

    // 进入触发区域
    private void OnTriggerEnter(Collider other) {
        //if (other.gameObject.tag == "Food") {
        //    Debug.Log("哈哈哈");
        //}
        //Debug.Log("OnTriggerEnter" + other.tag);

                // 通过游戏物体获得食物标签
        if (other.gameObject.tag == "Food") {
            // 销毁游戏物体
            Destroy(other.gameObject);

            score++;

            scoreText.text = "分数: " + score;

            if (score == 10) {
                winText.SetActive(true);
            }
        }
    }

    // 在触发区域里面
    //private void OnTriggerStay(Collider other) {
    //    Debug.Log("OnTriggerStay" + other.tag);
    //}

    //// 离开触发区域
    //private void OnTriggerExit(Collider other) {
    //    Debug.Log("OnTriggerExit" + other.tag);
    //}
}
