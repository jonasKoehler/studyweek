using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController m_CharacterController;
    private Vector2 m_Direction;
    [SerializeField] private float m_MovementSpeed = 0.01f;

    void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Direction = Vector2.zero;
        m_Direction.x = Input.GetAxisRaw("Horizontal");
        m_Direction.y = Input.GetAxisRaw("Vertical");
        Rotation();
        m_CharacterController.Move(m_Direction * m_MovementSpeed);
    }

    void Rotation()
    {
        // We need to tell where the mouse is relative to the
        // player
        Vector3 worldPos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(worldPos);

        /*
           * Get the differences from each axis (stands for
           * deltaX and deltaY)
        */
        float dx = this.transform.position.x - worldPos.x;
        float dy = this.transform.position.y - worldPos.y;

        // Get the angle between the two objects
        float angle = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;

        /*
           * The transform's rotation property uses a Quaternion,
           * so we need to convert the angle in a Vector
           * (The Z axis is for rotation for 2D).
        */
        //Make Upward positive
        angle += 180;
        //Calculate 45° increments
        angle = Mathf.Round(angle / 45) * 45;
        Quaternion rot = Quaternion.Euler(new Vector3(0, 0, angle));

        // Assign the Players rotation
        this.transform.rotation = rot;


    }
}
