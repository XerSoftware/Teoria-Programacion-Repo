using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celula : MonoBehaviour
{
    private float m_Speed = 4.0f;
    private float salud = 100f;
    public Color m_Color = Color.green;
    public Renderer m_Render;

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

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Colisión detectada");
        //ColorHandler cambiarColor = transform.gameObject.GetComponent<ColorHandler>();
        //if (cambiarColor != null)
        //{
        //    cambiarColor.SetColor(Color.green);
        //    Debug.Log("Cambio de Color");
        //}
        if (other.gameObject.CompareTag("virus"))
        {
            m_Render.material.color = Color.green;
            salud -= 1;
            Debug.Log("Salud:" + salud.ToString());
            Destroy(other);
        }
        
    }
}
