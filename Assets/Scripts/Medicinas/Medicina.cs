using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicina : MonoBehaviour
{
    public int sanacion { get; private set; }
    [SerializeField]
    public Color colorizacion { get; private set; } = new Color(0f, 143f, 253f);
    public Medicina(int sanacion)
    {
        this.sanacion = sanacion;
    }    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("celula"))
        {
            Celula celula = other.GetComponent<Celula>();
            celula.Colorizar(this.colorizacion);
            celula.Sanar(this.sanacion);
            gameObject.SetActive(false);
        }
    }
}
