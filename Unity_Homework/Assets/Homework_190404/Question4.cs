using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question4 : MonoBehaviour
{
    private Vector3 fPos;
    private List<Vector3> posList = new List<Vector3>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float f = Mathf.Sin(2 * Mathf.PI * Time.time) * 5 + 5;
        fPos = Vector3.right * Time.time + Vector3.up * f;
        posList.Add(fPos);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        for(int i = 0; i < posList.Count; i++)
        {
            Gizmos.DrawSphere(posList[i], 0.1f);
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(Vector3.zero, Vector3.right * 20);
        Gizmos.DrawLine(Vector3.zero, Vector3.up * 20);
    }
}
