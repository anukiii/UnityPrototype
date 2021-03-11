using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_3rd : MonoBehaviour
{

    public float RotationSpeed;
    public Transform Target, Player;
    float mouseX, mouseY;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        CamControl();
    }


    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;

        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        if (Input.GetKey(KeyCode.LeftShift))
        {

            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        }

        else {
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            //transform.position = Target.position;
            // vector3 targetPos = new vector3(0, mouseX, 0);
           // Player.rotation = Quaternion.RotateTowards(transform.rotation, Target.rotation, RotationSpeed * Time.deltaTime);
           Player.rotation = Quaternion.Euler(0, mouseX, 0);
        }
    }


}
