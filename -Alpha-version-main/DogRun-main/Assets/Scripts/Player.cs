using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    private float horizontalInput;
    public float horizontalSpeed;

    private Rigidbody rbComp;

    public int coins;

    public bool isDead = false;

    public float speedIncrease;

    public float jumpForce = 400f;
    public LayerMask groundMask;



    // Start is called before the first frame update
    void Start()
    {
        rbComp = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDead)
        {
            //Gets keyboard movement
            horizontalInput = Input.GetAxis("Horizontal");
        }        
    }

    private void FixedUpdate()
    {
        if(!isDead)
        {
            //Moves the player forward at a constant speed and moves the player to the corresponding horizontalInput
            transform.Translate(new Vector3(horizontalInput * horizontalSpeed, 0, 1 * speed * Time.deltaTime));
        }
        
    }

    public void AddCoin()
    {
        //Calls IncrementScore function in GameManager Script
        GameManager.inst.IncrementScore();
    }

    public void Die()
    {
        isDead = true;
        print("Player died!");
    }


}
