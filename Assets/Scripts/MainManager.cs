using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }
    // ENCAPSULACIÓN: Utillización de propiedad con campo de respaldo 

    private int m_Dificultad;
    private string m_NombreCelula;
    private bool m_GameOver = false;

    public Color celulaColor;
    public int dificultad
    {
        get { return m_Dificultad; }
        set
        {
            //validación de dificultad
            if (value > 2 && value <= 10)
            {
                m_Dificultad = value;
            }
            else
            {
                throw new ArgumentException("La dificultad debe estar entre 2 y 10 puntos.");
            }
        }
    }
    public string nombreCelula
    {
        get { return m_NombreCelula; }
        set
        {
            if (value.Length > 2 && value.Length < 8 ) 
                { 
                    m_NombreCelula = value;
                }
            else
            {
                throw new ArgumentException("El nombre debe tener al menos 2 caracteres y no más de 8");
            }
        }
    }

    // Aplicación del patrón Singleton
    private void Awake()
    {
        //Si ya existe una instacia, la destruyo
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        //Evitamos destruir objecto singleton al carga una nueva escena. Este sobrevivirá a las multiples escenas
        DontDestroyOnLoad(gameObject);
    }

}
