namespace InfijaAPostfija.Models
{
    public class Pila<T>
    {
        public T[] Datos { get; set; }
        public int Tope { get; set; }

        // Constructor para inicializar la pila
        public Pila(int capacidad) => InicializarPila(capacidad);
        

        public void InicializarPila(int capacidad)
        {
            Datos = new T[capacidad];
            Tope = 0;
        }

        public bool PilaVacia() => Tope == 0;
        public bool PilaLlena() => Tope == Datos.Length;

        public void Apilar(T valor)
        {
            if (PilaLlena()) throw new InvalidOperationException("La pila está llena");
            Datos[Tope] = valor;
            Tope++;
        }

        public T Desapilar()
        {
            if (PilaVacia()) throw new InvalidOperationException("La pila está vacía");
            Tope--;
            return Datos[Tope];
        }

        // Método para obtener el elemento superior de la pila sin desapilarlo
        public T Peek()
        {
            if (PilaVacia()) throw new InvalidOperationException("La pila está vacía");
            return Datos[Tope - 1];
        }

        // Método para limpiar la pila
        public void LimpiarPila()
        {
            Tope = 0;
        }

        // Método para obtener el número de elementos en la pila
        public int ContarElementos() => Tope;

        // Método para obtener el número de elementos que la pila puede almacenar
        public int Capacidad() => Datos.Length;

        //recorrer la pila pero no en reversa
        public T[] Recorrer()
        {
            T[] recorrer = new T[Tope];
            int j = 0;
            for (int i = 0; i < Tope; i++)
            {
                recorrer[j++] = Datos[i];
            }
            return recorrer;
        }


    }
}
