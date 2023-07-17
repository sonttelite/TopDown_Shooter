using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5f; // Tốc độ di chuyển
    public Vector3 direction = Vector3.forward; // Hướng di chuyển
    public Transform mainCharacter;
    public float moveSpeed = 3.0f;

    private void FixedUpdate()
    {
        MoveTowardsMainCharacter();
    }
    private void MoveTowardsMainCharacter()
    {
        Vector3 direction = mainCharacter.position - transform.position;
        Debug.Log(direction);
        //direction.z = 0;
        if (direction != Vector3.zero)
        {
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
        }
    }
}
