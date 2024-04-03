using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    public int da�o { get; private set; }
    public Color colorizacion { get; private set; }
    public int tiempoInfeccion { get; private set; }

    public Virus(int da�o, Color colorizacion, int tiempoInfeccion)
    {
        this.da�o = da�o;
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

    public void SetDa�o(int NuevoDa�o)
    {
        da�o = NuevoDa�o;
    }
    // ABSTRACTION
    // Este m�todo ser� utilizado por todas las variantes del virus.
    protected virtual void OnTriggerEnter(Collider other)
    {
          if (other.gameObject.CompareTag("celula"))
        {
            Celula celula = other.GetComponent<Celula>();
            celula.Colorizar(this.colorizacion);
            celula.Da�ar(this.da�o);
            gameObject.SetActive(false);
        }
    }

}
