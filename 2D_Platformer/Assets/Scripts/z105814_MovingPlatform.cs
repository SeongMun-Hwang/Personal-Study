using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z105814_MovingPlatform : MonoBehaviour
{
    public Transform start;
    public Transform end;

    public bool isMoving = false;
    public float moveSpeed = 50f;

    public GameObject platform;
    private Transform currentTarget;

    private Vector2[] endPosition = { new Vector2(4, 0), new Vector2(0, 4) };
    void Start()
    {
        end.transform.localPosition = endPosition[Random.Range(0, endPosition.Length)];
        currentTarget = end.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            platform.transform.position = Vector2.MoveTowards(platform.transform.position,
                currentTarget.position, Time.deltaTime * moveSpeed);
            if (Vector2.Distance(platform.transform.position, currentTarget.position) < 0.001f)
            {
                if (currentTarget == start) { currentTarget = end; }
                else { currentTarget = start; }
            }
        }
    }
}
