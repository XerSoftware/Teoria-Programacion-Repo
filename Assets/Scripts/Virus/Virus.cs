using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    public int daño { get; private set; }
    public Color colorizacion { get; private set; }
    public int tiempoInfeccion { get; private set; }

    public Virus(int daño, Color colorizacion, int tiempoInfeccion)
    {
        this.daño = daño;
        this.colorizacion = colorizacion;
        this.tiempoInfeccion = tiempoInfeccion;
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDaño(int NuevoDaño)
    {
        daño = NuevoDaño;
    }
    // ABSTRACTION
    // Este método será utilizado por todas las variantes del virus.
    protected virtual void OnTriggerEnter(Collider other)
    {
          if (other.gameObject.CompareTag("celula"))
        {
            Celula celula = other.GetComponent<Celula>();
            celula.Colorizar(this.colorizacion);
            celula.Dañar(this.daño);
            gameObject.SetActive(false);
        }
    }

}
