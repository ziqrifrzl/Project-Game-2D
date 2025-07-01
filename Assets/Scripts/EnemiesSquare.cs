using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSquare : MonoBehaviour
{

    public float movementSpeed;
    public bool isFacingRight;

    public Transform groundChecker;
    public float radius;
    public LayerMask WhatIsGround;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        if (!       ThereIsGround())
        {
            if (isFacingRight)
            {
                transform.eulerAngles = Vector2.up * 180;
                isFacingRight = false;
            }
            else
            {
                transform.eulerAngles = Vector2.zero;
                isFacingRight = true;
            }
        }
    }

    bool ThereIsGround()
    {
        return Physics2D.OverlapCircle(groundChecker.position, radius, WhatIsGround);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundChecker.position, radius);
    }
}
