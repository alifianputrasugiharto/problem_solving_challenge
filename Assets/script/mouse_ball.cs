using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_ball : MonoBehaviour
{
    public float moveSpeed = 5;

    private Vector3 targetMove;
    private Rigidbody2D _rigibody2D;

    // Start is called before the first frame update
    void Start()
    {
        _rigibody2D = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetMove = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetMove.z = 0;
        }

        if(transform.position != targetMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetMove, moveSpeed * Time.deltaTime);
        }
    }
    
}
