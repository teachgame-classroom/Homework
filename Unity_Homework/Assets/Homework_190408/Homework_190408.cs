using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_190408 : MonoBehaviour
{
    private int nameHash_walk = Animator.StringToHash("walk");
    private bool isWalk;

    // Start is called before the first frame update
    void Start()
    {
        // 2. 要使一个游戏对象的旋转角度变为(0,0,90)，以下写法正确的是
        transform.rotation = Quaternion.Euler(0, 0, 90);
        // transform.rotation = new Quaternion(0, 0, 90, 0);
        // transform.rotation = new Vector3(0, 0, 90);
        // transform.rotation.z = 90;

        Debug.Log("Quaternion.Euler(0, 0, 90) :" + Quaternion.Euler(0, 0, 90));
        Debug.Log("new Quaternion(0, 0, 90, 0) :" + new Quaternion(0, 0, 90, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Animator anim = GetComponent<Animator>();

            if(anim != null)
            {
                isWalk = !isWalk;

                Debug.Log("nameHash_walk:" + nameHash_walk);
                anim.SetBool(nameHash_walk, isWalk);
            }
        }
    }
}
