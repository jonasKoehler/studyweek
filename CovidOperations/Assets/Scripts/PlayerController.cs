using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController m_CharacterController;
    private Vector2 m_Direction;
    void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Direction = Vector2.zero;
        m_Direction.x = Input.GetAxisRaw("Vertical");
        m_Direction.y = Input.GetAxisRaw("Horizontal");
        m_CharacterController.Move(m_Direction);
    }
}
