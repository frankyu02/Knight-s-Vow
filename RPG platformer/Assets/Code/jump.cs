using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    public bool grounded;
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        animator.SetBool("isdead", false);
        grounded = true;
        gameObject.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && grounded==true)
        {
            animator.SetBool("isjumping", true);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 17, 0);
            grounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Floor")
        {
            animator.SetBool("isjumping", false);
            grounded = true;
        }

        if (coll.gameObject.tag == "Enemy")
        {
            animator.SetBool("isdead", true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } 
    }
}
