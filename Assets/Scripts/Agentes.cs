using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agentes : MonoBehaviour
{
    private float m_speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * m_speed * MainManager.Instance.dificultad * Time.deltaTime);
    }
}
