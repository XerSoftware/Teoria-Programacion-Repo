using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celula : MonoBehaviour
{
    private float m_Speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        Vector3 currentPos = transform.position;
        currentPos.x += input * Time.deltaTime * m_Speed;
        transform.position = currentPos;
    }
}
