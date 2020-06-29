using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController m_CharacterController;
    private Vector2 m_Direction;
    private float m_MovementSpeed = 0.01f;

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
        m_CharacterController.Move(m_Direction*m_MovementSpeed);
    }
}
