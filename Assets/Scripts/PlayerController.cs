using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor.Util;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float forceJump = 10f;
    public int score = 0;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnLeftButtonDown()
    {
        rb.velocity = new Vector2(-1f * speed, rb.velocity.y);
    }

    public void OnRightButtonDown()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    public void OnButtonUp()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")||collision.gameObject.CompareTag("CrashPlatform"))
        {
            if (collision.relativeVelocity.y >= 0)
            {
                rb.velocity = Vector2.up * forceJump;
                score += 5;
            }

            if (collision.gameObject.CompareTag("CrashPlatform"))
            {
                score += 10;
                Destroy(collision.gameObject);
            }
        }

        if (collision.gameObject.CompareTag("prujPlatform"))
        {
            if (collision.relativeVelocity.y>=0)
            {
                score += 20;
                rb.velocity = Vector2.up*(forceJump*2);
            }
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            scoreHolder.Score = score;
            SceneManager.LoadScene("Defeat");
        }

    }

}
