using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    // mouse parameters
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;

    [SerializeField] private Transform playerBody;

    private float xAxisClamp;


    // //  key parameters
    // [SerializeField]
    // public float keySensitivity = 5.0f; // 2.0f;
    // [SerializeField]
    // public float keySmoothing = 2.0f;  // 2.0f;
    
    // public float keySpeedx = 10.0f;   // 10.0f;

    // // public GameObject keyCharacter;    // the chacter is the capsule
    // private Vector2 mouseLook;  // get the incremental value of mouse moving
    // private Vector2 smoothV;    // smooth the mouse moving
    // // private float translation;   
    // private float horiz;

    private void Awake()
    {
        // LockCursor();
        xAxisClamp = 0.0f;
    }

    // private void LockCursor()
    // {
    //     Cursor.lockState = CursorLockMode.Locked;
    // }


    private void Update()
    {
        // if (Input.GetMouseButton(0))
        //     MouseRotation();
        // else
        //     KeyRotation();
        Rotation();
    }


   //  private void KeyRotation()
   //  {
   //      horiz = Input.GetAxis("Horizontal") * keySpeedx * Time.deltaTime;
   //      // translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
   //      // transform.Translate(straffe, 0, translation);

   //      // md is mouse delta
   //      // var md = new Vector2(Input.GetAxisRaw("Mouse X"), 0); // Input.GetAxisRaw("Mouse Y")
   //      var md = new Vector2(horiz, 0); // Input.GetAxisRaw("Mouse Y");
   //      md = Vector2.Scale(md, new Vector2(keySensitivity * keySmoothing, keySensitivity * keySmoothing));

   //      smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / keySmoothing);    // the interpolated float result between the two float values
   //      smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / keySmoothing);
        
   //      mouseLook += smoothV;   // incrementally add to the camera look

   //      // vector3.right means the x-axis
   //      transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
   //      // playerBody.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, playerBody.transform.up);
   //      playerBody.localRotation = Quaternion.AngleAxis(mouseLook.x, playerBody.up);
   // }


    // private void MouseRotation()
    private void Rotation()
    {
        float mouseX;
        float mouseY;

        if (Input.GetMouseButton(0))
        {
            // MouseRotation();
            mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
            mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;
        }
        else
        {
            // KeyRotation();
            mouseX = Input.GetAxis("Horizontal")    * mouseSensitivity * Time.deltaTime;
            mouseY = 0.0f;
        }

        xAxisClamp += mouseY;

        if(xAxisClamp > 30.0f)
        {
            xAxisClamp = 30.0f;
            mouseY = 0.0f;
            // ClampXAxisRotationToValue(270.0f);
            ClampXAxisRotationToValue(330.0f);
        }
        else if (xAxisClamp < -30.0f)
        {
            xAxisClamp = -30.0f;
            mouseY = 0.0f;
            // ClampXAxisRotationToValue(90.0f);
            ClampXAxisRotationToValue(30.0f);
       }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
