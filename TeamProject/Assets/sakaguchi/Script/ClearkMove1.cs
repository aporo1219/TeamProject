using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearkMove1 : MonoBehaviour
{
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        //初期化（移動）
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //移動
        transform.position = new Vector3(pos.x + Mathf.PingPong(Time.time, 5), pos.y);
    }
}
