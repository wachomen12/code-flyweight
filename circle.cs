using System;
using System.Collections.Generic;

// Clase Flyweight que representa el objeto compartido
//La clase Circle representa el objeto compartido (flyweight) y tiene una propiedad color que representa el color del círculo. 
//La clase también tiene un método Draw() que toma las coordenadas x e y donde se dibujará el círculo
public class Circle
{
    private string color;

    public Circle(string color)
    {
        this.color = color;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine("Dibujando un círculo de color " + color + " en las coordenadas (" + x + ", " + y + ")");
    }
}