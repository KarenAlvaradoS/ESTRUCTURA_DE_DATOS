using System;

// Clase que representa un nodo en la lista enlazada
public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

// Clase que representa la lista enlazada
public class LinkedList
{
    private Node head;

    // Agregar un nodo al final de la lista
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // Calcular el número de elementos en la lista
    public int Count()
    {
        int count = 0;
        Node current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    // Mostrar los elementos de la lista
    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    // Invertir los elementos de la lista enlazada
    public void Reverse()
    {
        Node prev = null;
        Node current = head;
        Node next = null;

        while (current != null)
        {
            next = current.Next;  // Guardar el siguiente nodo
            current.Next = prev;  // Invertir el enlace
            prev = current;       // Mover prev al nodo actual
            current = next;       // Avanzar al siguiente nodo
        }
        head = prev; // Actualizar la cabeza al último nodo procesado
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Agregar elementos a la lista
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        Console.WriteLine("Lista original:");
        list.Print();

        // Invertir la lista
        list.Reverse();
        Console.WriteLine("Lista invertida:");
        list.Print();

        // Calcular el número de elementos
        Console.WriteLine("Número de elementos en la lista: " + list.Count());
    }
}
