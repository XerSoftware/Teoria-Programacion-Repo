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
        float vertical = Input.GetAxis("Vertical");
        float input = Input.GetAxis("Horizontal");
        Vector3 currentPos = transform.position;
        currentPos.x += input * Time.deltaTime * m_Speed;
        currentPos.y += vertical * Time.deltaTime * m_Speed;
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
            //Destroy(other);
        }
        
    }
    public void Colorizar(Color nuevoColor)
    {
        m_Render.material.color = nuevoColor;
    }

    public void Dañar(int dimensionDaño)
    {
        salud -= dimensionDaño;
        Debug.Log("Salud:" + salud.ToString());
        if (salud < 20)
        {
            MainManager.Instance.GameOver();
        }    
    }

    public void Sanar(int dimensionSanar)
    {
        if (salud < 100)
        {
            salud += dimensionSanar;
        }
        
    }

    public void CambiarTamaño(float dimensionCelula)
    {
        Vector3 nuevoTamaño = new Vector3(dimensionCelula, dimensionCelula, dimensionCelula);
        transform.localScale = nuevoTamaño;
    }
}
