using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDrawGizmos()
    {
        Vector3 direction = new Vector3(1, -1, 0);
        direction.Normalize();

        float speed = 10f;

        Vector3 posAfter1Sec = direction * speed;

        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if(transform.position.sqrMagnitude > 50 * 50)
        {
            transform.position = Vector3.zero;
        }

        Gizmos.DrawSphere(transform.position, 1f);
        Gizmos.DrawSphere(transform.position.x * Vector3.right, 1f);
        Gizmos.DrawSphere(transform.position.y * Vector3.up, 1f);

        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(posAfter1Sec, 1f);
        Debug.Log("1秒后的位置:" + posAfter1Sec);
    }
}
