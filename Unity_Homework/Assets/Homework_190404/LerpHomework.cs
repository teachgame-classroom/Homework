using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpHomework : MonoBehaviour
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
        float radius = 0.1f;

        Gizmos.color = Color.white;
        Gizmos.DrawSphere(Vector3.zero, radius);

        Gizmos.DrawLine(Vector3.zero, Vector3.right * 50);

        // 2. 已知数轴上的点 A = 2，点 B = 8，那么线段 AB 的中点 C = （   ）

        float a = 2;
        float b = 8;
        float t = 0.5f;

        float c = Mathf.Lerp(a, b, t);

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(Vector3.right * a, radius);
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(Vector3.right * b, radius);
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(Vector3.right * c, radius);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(Vector3.right * a, Vector3.right * b);

        Debug.Log("2. C = " + c);

        // 3. 线性插值运算中，使用线段的起点 A，终点 B，以及插值系数 t 可以求出线段 AB 上任一点 P 的值，计算公式为（   ）

        c = a + (b - a) * t;
        Debug.Log("3. C = A + (B - A) * t = " + c);

        // 4. 线性插值运算中，对于任意的线段 AB，插值系数 t = 0，t = 0.5，t = 1 分别对应线段上的（   ）

        float t0 = Mathf.Lerp(a, b, 0);
        float t05 = Mathf.Lerp(a, b, 0.5f);
        float t1 = Mathf.Lerp(a, b, 1);

        Debug.Log(string.Format("4. t = 0 : {0}, t = 0.5 : {1}, t = 1 : {2}", t0, t05, t1));

        // 5. 已知数轴上的点 A = 2，点 B = 8，那么插值系数 t = 0.25 对应的点 P = （   ）

        float t025 = Mathf.Lerp(a, b, 0.25f);
        Debug.Log("5. P =" + t025);

        // 6. 已知三维向量 v1(1,2,3)，v2(5,6,7)，v3 = Vector3.Lerp(v1, v2, 0.75f)，那么 v3 的值是（   ）

        Vector3 v1 = new Vector3(1, 2, 3);
        Vector3 v2 = new Vector3(5, 6, 7);

        Vector3 v3 = Vector3.Lerp(v1, v2, 0.75f);

        DrawLineWithGizmos(v1, v2, Color.yellow);
        DrawSphereWithGizmos(v3, radius, Color.cyan);
        DrawAxis(v1, 20);

        Debug.Log("6. v3 = " + v3);

        // 8. 已知三维向量 v4(1,2,3)，v5(10,2,3)，浮点数 s = 5.0f，某一帧的经过时间 dt = 0.016f，那么 Vector3.MoveTowards(v4,v5,s * dt) 等于（   ）

        Vector3 v4 = new Vector3(1, 2, 3);
        Vector3 v5 = new Vector3(10, 2, 4);

        float s = 5.0f;
        float dt = 0.016f;

        Vector3 result8 = Vector3.MoveTowards(v4, v5, s * dt);

        Debug.Log(string.Format("8. result = ({0},{1},{2})", result8.x, result8.y, result8.z));

        // 9. 已知三维向量 v6(4,5,6)，v7(4,6,6)，浮点数 s = 100.0f，某一帧的经过时间 dt = 0.02f，那么 Vector3.MoveTowards(v6,v7,s * dt) 等于（   ）

        Vector3 v6 = new Vector3(4, 5, 6);
        Vector3 v7 = new Vector3(4, 6, 6);

        float s9 = 100.0f;
        float dt9 = 0.02f;

        Vector3 result9 = Vector3.MoveTowards(v6, v7, s9 * dt9);

        Debug.Log(string.Format("9. s * dt = {3}, result = ({0},{1},{2})", result9.x, result9.y, result9.z, s9 * dt9));
    }

    void DrawLineWithGizmos(Vector3 a, Vector3 b, Color color)
    {
        DrawSphereWithGizmos(a, 0.1f, Color.red);
        DrawSphereWithGizmos(b, 0.1f, Color.green);

        Gizmos.color = color;
        Gizmos.DrawLine(a, b);
    }

    void DrawSphereWithGizmos(Vector3 center, float radius, Color color)
    {
        Gizmos.color = color;
        Gizmos.DrawSphere(center, radius);
    }

    void DrawAxis(Vector3 origin, float axisLength)
    {
        DrawLineWithGizmos(origin, origin + Vector3.right * axisLength, Color.red);
        DrawLineWithGizmos(origin, origin + Vector3.up * axisLength, Color.green);
        DrawLineWithGizmos(origin, origin + Vector3.forward * axisLength, Color.blue);
    }
}
