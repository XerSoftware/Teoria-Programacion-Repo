using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI nombreCelulaText;
    public Slider dificultadSlider;
    public void SetearNombreCelula()
    {
        MainManager.Instance.nombreCelula = nombreCelulaText.text;
        //Debug.Log(MainManager.Instance.nombreCelula);
    }

    public void SetearDificultad()
    {
        MainManager.Instance.dificultad = ((int)dificultadSlider.value);
        Debug.Log(MainManager.Instance.dificultad);
    }

    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }

}
