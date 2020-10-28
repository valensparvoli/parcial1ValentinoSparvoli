using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calcular : MonoBehaviour
{
    public Text Name;
    public Text FechaNacimiento;
    public Text Resultado;
    string name;
    string fechaNac;
    int day;
    int month;
    int year;

    public void CalcularEdad()
    {
        name = Name.text;
        fechaNac = FechaNacimiento.text;
        day = Convert.ToInt32(fechaNac.Substring(0, 2));
        month = Convert.ToInt32(fechaNac.Substring(3, 2));
        year = Convert.ToInt32(fechaNac.Substring(6, 4));

        // var dates = FechaNacimiento.text.Split('/');

        DateTime nacimiento = new DateTime(year, month, ++day); //Fecha de nacimiento
        int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

        Debug.Log(name + " " + edad);

        Resultado.text = name + " " + edad;


    }
}
