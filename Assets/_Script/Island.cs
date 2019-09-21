using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class Island : MonoBehaviour
{
    [SerializeField]
    public Boundary boundary;
    

    public float verticalSpeed = 0.02f;

    public float m_topResetPosition = 2.7f;
    public float m_bottomResetPosition = -2.7f;

    // Start is called before the first frame update
    void Start()
    {
        //boundary = new Boundary();

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
        float randomPosition = Random.Range(boundary.leftBounds,boundary.rightBounds);

        transform.position = new Vector2(randomPosition, boundary.topBounds);
       
        
    }

    void CheckBounds()
    {
        if (transform.position.y <= -2.7f)
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

