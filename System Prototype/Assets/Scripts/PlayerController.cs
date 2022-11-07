using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Moving")]
    [SerializeField] float m_speed;
    float m_xInput = 0;
    Rigidbody2D m_rb;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        m_rb.velocity = m_xInput * m_speed * Vector2.right * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        m_xInput = Input.GetAxis("Horizontal");
    }
}

