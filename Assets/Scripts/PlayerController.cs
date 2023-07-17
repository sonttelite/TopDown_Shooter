using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; //khai bao bien toc do di chuyen
    public float rollBoost = 2.0f; //khai bao bien toc do cong them khi roll
    private float rollTime;
    public float RollTime;
    bool rollOnce = false;
    private Rigidbody2D rb;

    public Animator animator;

    public Vector3 moveInput; //khai bao bien nhan biet phim bam
    // Start is called before the first frame update

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.position += moveInput * moveSpeed * Time.deltaTime;

        animator.SetFloat("Speed", moveInput.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Space) && rollTime <= 0)
        {
            animator.SetBool("Roll", true);
            moveSpeed += rollBoost;
            rollTime = RollTime;
            rollOnce = true;
        }    

        if (rollTime <= 0 && rollOnce == true)
        {
            animator.SetBool("Roll", false);
            moveSpeed -= rollBoost;
            rollOnce = false;
        }
        else
        {
            rollTime -= Time.deltaTime;
        }

        if (moveInput.x != 0)
        {
            if (moveInput.x > 0)
                transform.localScale = new Vector3(1, 1, 0);
            else
                transform.localScale = new Vector3(-1, 1, 0);    
        }    
    }
}