using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public SkinnedMeshRenderer baseSkin;
    public SkinnedMeshRenderer hatSkin;
    public Animator animator;

    public NavMeshAgent agent;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private float speed = 2.5f;
    private float jumpHeight = 10f;
    private float gravityValue = -9.81f;
    private bool groundedPlayer;
    private bool isMoving;
    private bool isRunning;

    public float force;
    public GameObject carrotPre;
    public GameObject firePos;

    // Start is called before the first frame update
    void Start()
    {
        //controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //groundedPlayer = controller.isGrounded;
        //if (groundedPlayer && playerVelocity.y < 0)
        //{
        //    playerVelocity.y = 0f;
        //}

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //if(move != Vector3.zero)
        //{
        //    isMoving = true;
        //    if (Input.GetKey(KeyCode.LeftShift))
        //    {
        //        controller.Move(move * Time.deltaTime * (speed * 2));
        //        isRunning = true;
        //    }
        //    else
        //    {
        //        controller.Move(move * Time.deltaTime * speed);
        //        isRunning = false;
        //    }
        //}
        //else
        //{
        //    isMoving = false;
        //}

        //if (move != Vector3.zero)
        //{
        //    gameObject.transform.forward = move;
        //}

        //if (Input.GetButtonDown("Jump") && groundedPlayer)
        //{
        //    playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //}

        //playerVelocity.y += gravityValue * Time.deltaTime;
        //controller.Move(playerVelocity * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var carrotSeed = Instantiate(carrotPre, this.transform.position, rotation: Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            var carrotSeed = Instantiate(carrotPre, firePos.transform.position, rotation: Quaternion.identity);
            Vector3 direction = new Vector3(firePos.transform.position.x - this.transform.position.x, 0, firePos.transform.position.z - this.transform.position.z);
            carrotSeed.GetComponent<Rigidbody>().AddForce(direction * force);
        }

    }

    //void ChangeState()
    //{
    //    if (isMoving && !isRunning)
    //    {
    //        animator.SetFloat("Speed_f", 0.3f);
    //        animator.Play("Walk_Static", 0);
    //    }
    //    else if (isMoving && isRunning)
    //    {
    //        animator.SetFloat("Speed_f", 0.5f);
    //        animator.Play("Walk_Static");
    //    }
    //    else
    //    {
    //        animator.SetFloat("Speed_f", 0);
    //        animator.Play("Idle");
    //    }
    //}
}
