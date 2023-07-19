using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Transform mainCharacter;
    //// Update is called once per frame
    void Update()
    {
        MoveTowardsMainCharacter();
    }

    public void MoveTowardsMainCharacter()
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


