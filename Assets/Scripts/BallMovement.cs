using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] AudioSource VineBoom;
    [SerializeField] AudioSource Boop;

    Rigidbody2D rigid;
    Vector3 startPosition;

    public Color thered;
    public Color thegreen;

    private void Start()
    {
        startPosition = transform.position;
        rigid = GetComponent<Rigidbody2D>();

        Launch();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Castle"))
        {
            VineBoom.Play();
            GameObject.Find("Main Camera").GetComponent<CamShake>().Shake();
            collision.gameObject.GetComponent<Castle>().Break();
            Reset();
        }
    }

    private void Reset()
    {
        rigid.velocity = Vector2.zero;
        transform.position = startPosition;
        GetComponent<SpriteRenderer>().color = Color.white;
        Launch();
    }

    private float GetRandomNum()
    {
        return Random.Range(0, 2) == 0 ? -1 : 1;
    }
    private void Launch()
    {
        float velx = GetRandomNum();
        float vely = GetRandomNum();

        rigid.velocity = new Vector2(speed * velx, speed * vely);
    }

    private void Faster()
    {
        rigid.velocity *= new Vector2(1.25f, 1.25f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("P1"))
        {
            GetComponent<SpriteRenderer>().color = thered;
            Faster();
        }
        else if (collision.gameObject.CompareTag("P2"))
        {
            GetComponent<SpriteRenderer>().color = thegreen;
            Faster();
        }

        Boop.Play();
    }
}
