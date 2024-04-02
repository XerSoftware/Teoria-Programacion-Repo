using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Herencia
public class Hongos : Virus
{
    // Constructor de la clase derivada
    public Hongos() : base(0, Color.blue, 1)
    { }

    void Awake()
    {
        int nuevoDaño = Random.Range(0, 1); // Genera un número aleatorio entre 0 y 100 (incluyendo ambos extremos)
        this.SetDaño(nuevoDaño);
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
