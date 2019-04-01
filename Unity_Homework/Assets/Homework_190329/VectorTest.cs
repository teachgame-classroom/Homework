using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    public float xAxisLength = 10;
    public float yAxisLength = 10;

    public float pointSize = 0.1f;

    public Vector3 a;
    public Vector3 b;
    public Vector3 c;

    public Vector3 movePoint;

    public Color colorA;
    public Color colorB; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ab = b - a;
        Debug.Log(string.Format("点A到点B的距离是{0}", ab.magnitude));

        Vector3 co = c - Vector3.zero;
        Debug.Log(string.Format("点C到原点的距离是{0}", co.magnitude));

        if(Input.GetKeyDown(KeyCode.A))
        {
            movePoint -= Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            movePoint += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            movePoint += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            movePoint -= Vector3.up;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawSphere(Vector3.zero, pointSize);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, Vector3.right * xAxisLength);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, Vector3.up * yAxisLength);

        Gizmos.color = colorA;
        Gizmos.DrawSphere(a, pointSize);

        Gizmos.color = colorB;
        Gizmos.DrawSphere(b, pointSize);

        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(c, pointSize);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(a, b);
        Gizmos.DrawLine(c, Vector3.zero);

        Gizmos.color = Color.white;
        Vector3 ab = b - a;
        Gizmos.DrawLine(movePoint, movePoint + ab);

    }
}
