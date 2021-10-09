using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_ball : MonoBehaviour
{
    public float moveSpeed = 10;

    private Vector2 movement;
    private Rigidbody2D _rigibody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigibody2D = GetComponent<Rigidbody2D>()
;    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical"); 
        movement.Set(xMove, yMove);      
    }

    private void FixedUpdate()
    {
        _rigibody2D.velocity = movement.normalized * moveSpeed;
    }
}
