using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW0704 : MonoBehaviour
{
    [SerializeField] private SphereCollider sc;
    [SerializeField] private Camera cam;
    [SerializeField] private Transform capsule;
    [SerializeField] private Transform sqhere;
    [SerializeField] private Transform cube;
    [SerializeField] Rigidbody rigcap;

    void Start()
    {
        float camdep = Camera.main.depth;
        print($"攝影機深度： {camdep}");

        float SphColl = sc.radius;
        print($"球體碰撞器半徑：{SphColl}");

        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Random.ColorHSV();

        transform.localScale = new Vector3(3, 2, 1);
    }

    void Update()
    {
        cube.RotateAround(sc.gameObject.transform.position, Vector3.forward, 200 * Time.deltaTime);
        rigcap.AddForce(Vector2.up * 10 * Time.deltaTime);
    }
}
