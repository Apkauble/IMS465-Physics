using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int speed;
    [SerializeField]
    private Rigidbody rigid;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.MovePosition(transform.position + (new Vector3(1, 0, 1) * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigid.MovePosition(transform.position + (new Vector3(0, 0, 1) * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigid.MovePosition(transform.position + (new Vector3(-1, 0, -1) * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigid.MovePosition(transform.position + (new Vector3(0, 0, -1) * speed * Time.deltaTime));
        }
    }
}
