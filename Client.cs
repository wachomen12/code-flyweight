public class Client
{
    //La clase Client representa el cliente que utiliza los objetos flyweight. Toma una instancia de CircleFactory en su constructor.
    // El método DrawCircle() del cliente utiliza el factory para obtener 
    //el objeto Circle flyweight correspondiente al color solicitado y luego llama al método Draw()
    // del objeto para dibujarlo en las coordenadas especificadas.
    private CircleFactory circleFactory;

    public Client(CircleFactory circleFactory)
    {
        this.circleFactory = circleFactory;
    }

    public void DrawCircle(string color, int x, int y)
    {
        Circle circle = circleFactory.GetCircle(color); // Obtiene un objeto Flyweight del Factory
        circle.Draw(x, y); // Dibuja el círculo utilizando las coordenadas dadas
    }
}