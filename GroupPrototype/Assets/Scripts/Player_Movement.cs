using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
  
    public Rigidbody projectile;
    public Transform BulletSpawn;
    public bool isGrounded;
    Rigidbody rb;

    private  int timePlayed = 0;
    public Text textObj; // assign from the inspector.



    public float Speed;
    
    
    void Start()
    {
        StartCoroutine(GameCounter());
        healthBAr.SetHealthBarValue(1);
        rb = GetComponent<Rigidbody>();
        //jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void FixedUpdate()
    {
        PlayerMovement();
        //jumping check

    }

    IEnumerator GameCounter()
    {
        WaitForSeconds wfs = new WaitForSeconds(1);
        while (true)
        {
            textObj.text = timePlayed.ToString();
            yield return wfs;
            timePlayed++;
        }
    }

    public int getTimePlayed() { 
        return timePlayed; 
    }
    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
          {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
          }*/
        if (healthBAr.GetHealthBarValue() <= 0.001)
        {
            PlayerPrefs.SetInt("Score", timePlayed);
            PlayerPrefs.Save();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Rigidbody bullet;
            bullet = Instantiate(projectile, BulletSpawn.position , transform.rotation);
            bullet.velocity = transform.TransformDirection(Vector3.forward * 100);
            //bullet.timeoutDestructor();
        }
    }
    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement);


    }


    //checks if on floor
    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void OnCollisionExit()
    {
        isGrounded = false;
    }





}
