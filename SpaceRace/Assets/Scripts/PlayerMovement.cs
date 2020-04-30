using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public static int player1score, player2score ;
    public Text Player1Text, Player2Text;

    public AudioSource audioSrc;

    private void Awake()
    {
        audioSrc = GetComponent<AudioSource>();

        player1score = 0;
        player2score = 0;
    }

    void Update()
    {
        Player1Text.text = player1score.ToString();
        Player2Text.text = player2score.ToString();

        if (gameObject.CompareTag("Player1"))
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
        }
        if (gameObject.CompareTag("Player2"))
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.7f, 6f), transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            if (gameObject.CompareTag("Player1"))
            {
                gameObject.transform.position = new Vector2(-2, -3.7f);
                audioSrc.Play();
            }
            else
            {
                gameObject.transform.position = new Vector2(2, -3.7f);
                audioSrc.Play();
            }
        }

        if (collision.gameObject.tag == "Point")
        {
            if (gameObject.CompareTag("Player1"))
            {
                player1score += 1;
                gameObject.transform.position = new Vector2(-2, -3.7f);
            }
            else
            {
                player2score += 1;
                gameObject.transform.position = new Vector2(2, -3.7f);
            }
        }
    }

}
