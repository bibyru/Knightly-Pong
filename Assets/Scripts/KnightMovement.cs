using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void Move(int dir)
    {
        rigid.velocity = new Vector2(0, speed * dir);
    }
}
