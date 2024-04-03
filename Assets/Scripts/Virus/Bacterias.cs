using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// HERENCIA
public class Bacterias : Virus
{
    // Constructor de la clase derivada
    public Bacterias() : base(10, Color.blue, 1)
    {}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // POLYMORPHISM
    // Por anulaci�n de m�todo
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("celula"))
        {
            Celula celula = other.GetComponent<Celula>();
            celula.Colorizar(this.colorizacion);
            celula.Da�ar(this.da�o);
            celula.CambiarTama�o(4.0f);
            gameObject.SetActive(false);
        }
    }
}
