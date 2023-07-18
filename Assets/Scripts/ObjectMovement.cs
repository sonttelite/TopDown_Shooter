using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5f; // Tốc độ di chuyển
    public Vector3 direction = Vector3.forward; // Hướng di chuyển

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
