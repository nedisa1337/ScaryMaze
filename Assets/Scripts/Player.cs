using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed = 10;

    private Rigidbody2D rb;
    private Vector2 mousePos, targetPos;
    private Vector3 worldPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Application.targetFrameRate = 60;
    }

    void Update()
    {
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        worldPos.z = 0;
        targetPos = Vector2.MoveTowards(transform.position, worldPos, speed * Time.deltaTime);
        rb.MovePosition(targetPos);
    }
}
