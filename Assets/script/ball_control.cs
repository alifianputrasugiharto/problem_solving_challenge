using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rigidbody;

    public void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rigidbody.AddForce(new Vector2(1, 1) * moveSpeed);
    }
}
