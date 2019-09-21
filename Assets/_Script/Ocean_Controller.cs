using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean_Controller : MonoBehaviour
{

    public float verticalSpeed = 0.02f;
    public bool resetToBottomPosition = false;

    private float m_topResetPosition = 4.8f;
    private float m_bottomResetPosition = -9.6f;
    private bool m_isFirstRun = true;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }


    void Reset()
    {
        Vector2 resetPosition = new Vector2(0.0f, 0.0f);
        if (m_isFirstRun)
        {
            resetPosition.y = (resetToBottomPosition) ? m_bottomResetPosition : m_topResetPosition;
            transform.position = new Vector2(0.0f, m_bottomResetPosition);
            transform.position = resetPosition;
            m_isFirstRun = false;
            print("is first run");

            m_topResetPosition = 9.6f;
        }
        else
        {
            transform.position = new Vector2(0.0f, m_topResetPosition);
        }
        
    }

    void CheckBounds()
    {
        if (transform.position.y <= -19.2f)
        {
            Reset();
        }
    }

    void Move()
    {
        Vector2 currentPosition = transform.position;
        currentPosition -= new Vector2(0.0f, verticalSpeed);
        transform.position = currentPosition;
    }
}
