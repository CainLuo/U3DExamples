using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bulletPrefab;

    private GameObject bullet;

    // Start is called before the first frame update
    void Start() {
        // 根据Prefab创建实例 = 实例化Prefab
        // 如果实例化时不提供位置和旋转角度，会使用默认值
        // 这里指定的是相机的position和rotation
        // GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update() {

        // Input
        // 0代表鼠标左键，1代表鼠标右键
        // 返回值是bool值
        if (Input.GetMouseButtonDown(0)) {
            bullet = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.name = "Bullet";

            Rigidbody rd = bullet.GetComponent<Rigidbody>();

            // 添加力，Vector3.forward 默认是1牛的力度
            // 但是这种不方便观察速度，速度需要牛顿力学的运动公式
            //rd.AddForce(Vector3.forward);

            // 设置速度，Vector3.forward默认是1米每秒
            rd.velocity = Vector3.forward * 30;
        }
    }
}
