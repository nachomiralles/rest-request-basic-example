using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area  {

    public string nombre;
    public string label;
    public double latitud;
    public double longitud;
    public double radio;

    public Area(string n, string lab, double la, double lo, double rad)
    {
        this.nombre = n;
        this.label = lab;
        this.latitud = la;
        this.longitud = lo;
        this.radio = rad;
    }

    public override string ToString()
    {
        return "Nombre: " + this.nombre + "\nEtiqueta: " + this.label +
            "\nLatitud: " + this.latitud + "; Longitud: " + this.longitud + 
            "\nRadio: " + this.radio;
    }

}
