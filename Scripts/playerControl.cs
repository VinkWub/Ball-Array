using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerControl : MonoBehaviour
{
    private Rigidbody2D playerRigid;
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJump;
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        playerRigid.velocity = new Vector2(Input.GetAxis("Horizontal") * playerSpeed, playerRigid.velocity.y);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRigid.velocity = new Vector2(playerRigid.velocity.x, playerJump);
        }
        if(Input.GetAxis("Horizontal") > 0.01f)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if(Input.GetAxis("Horizontal") < -0.01f)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Boom"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
