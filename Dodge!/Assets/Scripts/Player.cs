using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public ScoreScript myscore;

    [Header("Player Settings :")]
    public int speed;
    public int Health = 100;
    public int JumpPower;
    public bool isGrounded = true;
    private Rigidbody2D mybody;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        //This will move the player right or left depending on the key pressed
        transform.position += new Vector3(inputX, 0f, 0f) * Time.deltaTime * speed;
        //Now for the jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            //This runs when player presses space
            //This code will make player jump
            mybody.AddForce(new Vector2(0f, JumpPower), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ground")
        {
            isGrounded = true;
        }
        if (other.gameObject.name == "Enemy(Clone)")
        {
            Health -= 35;
            if (Health <= 0)
            {
                myscore.SetHighScore();
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
}
