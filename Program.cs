class Program
{
  //se crea una instancia de CircleFactory y una instancia de Client pasando el factory como argumento.
  // Luego, el cliente dibuja varios círculos utilizando diferentes colores y coordenadas
    static void Main(string[] args)
    {
        CircleFactory circleFactory = new CircleFactory();
        Client client = new Client(circleFactory);

        // Dibuja varios círculos utilizando el mismo objeto Flyweight
        client.DrawCircle("Rojo", 100, 100);
        client.DrawCircle("Azul", 200, 200);
        client.DrawCircle("Rojo", 300, 300);

        Console.ReadLine();
    }
}

//el resultado  es que se crea y utiliza objetivos circle
 //compartidos cuando se dibujo los circulos se solicito un color ya existente, se reutiliza el objetivos flyweiht 
 //en lugar de crear uno nuev, lo que ahorra memoria y mejora el rendimiento