using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 7. 在Unity场景中有两个独立的游戏对象，名称分别是 objA 和 objB，（ A ）身上有一个脚本，其中的（ A ）语句可以将 objB 设置为 objA 的子对象

public class ObjA : MonoBehaviour
{
    public int id = 0;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        // A.
        GameObject.Find("objB").transform.SetParent(transform);

        // C.
        // gameObject.Find("objB").transform.SetParent(this);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            count++;

            if(count % 2 == id)
            {
                GameObject.Find("objB").transform.SetParent(transform, false);

                // 等价于 
                // Transform objTrans = GameObject.Find("objB").transform;
                // objTrans.SetParent(transform);
                // objTrans.localPosition = Vector3.forward;
            }
        }
    }
}
