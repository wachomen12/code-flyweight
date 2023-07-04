public class CircleFactory
//La clase CircleFactory actúa como un Factory que gestiona la creación y recuperación de objetos Circle (flyweights). 
//Utiliza un diccionario circleCache para almacenar y reutilizar los objetos flyweight. Cuando se solicita un objeto Circle con un color 
//específico, se verifica si ya existe en el caché. Si existe, se retorna el objeto existente;
// de lo contrario, se crea un nuevo objeto Circle y se agrega al caché.
{
    private Dictionary<string, Circle> circleCache = new Dictionary<string, Circle>();

    public Circle GetCircle(string color)
    {
        if (circleCache.ContainsKey(color))
        {
            return circleCache[color]; // Retorna el objeto Flyweight existente
        }
        else
        {
            Circle circle = new Circle(color); // Crea un nuevo objeto Flyweight
            circleCache[color] = circle; // Almacena el objeto en el caché
            return circle;
        }
    }
}