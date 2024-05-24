using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform start;
    public Transform end;

    public bool isMoving = false;
    public float moveSpeed = 50f;

    private GameObject platform;
    private Transform currentTarget;

    void Start()
    {
        platform = GameObject.Find("Platform");
        currentTarget = end.transform;
    }
    void Update()
    {
        if (isMoving)
        {
            platform.transform.position = Vector3.MoveTowards(platform.transform.position,
                currentTarget.position, Time.deltaTime * moveSpeed);
            if (Vector3.Distance(platform.transform.position, currentTarget.position) < 0.001f)
            {
                if (currentTarget == start) { currentTarget = end; }
                else { currentTarget = start; }
            }
        }
    }
    void OnDrawGizmos()
    {
        // Start 위치에 빨간 구체 Gizmo 그리기
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(start.position, 0.1f);  // 크기는 원하는 대로 조절 가능
                                                  // End 위치에 파란 구체 Gizmo 그리기
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(end.position, 0.1f);

        // Start와 End 위치에 텍스트 표시
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.white;
        UnityEditor.Handles.Label(start.position, "Start", style);
        UnityEditor.Handles.Label(end.position, "End", style);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(start.position, end.position);
    }
}
