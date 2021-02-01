using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[Serializable]
 public class CFLinkedList<T>
	{

     LinkedList<T> list = new LinkedList<T>();
     T[] array;

     public int current = 0;

    public T[] Array { get => array; set => array = value; }
    public LinkedList<T> List { get => list; set => list = value; }

    public void Add(T node)
     {
         List.AddLast(node);
     }

     public void AddAll(CFLinkedList<T> list2)
     {
         T[] arr = convert(list2);
         for (int i = 0; i < arr.Length; i++)
             List.AddLast(arr[i]);
     }

     public void Remove()
     {
         List.RemoveLast();
     }

     public void RemoveObj(T obj)
     {
         List.Remove(obj);
     }

     public T get(int index)
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         obj = Array[index];
         //return object
         return obj;
     }

     public T getFirst()
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         obj = Array[0];
         //return object
         return obj;
     }

     public T getLast()
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         obj = Array[List.Count-1];
         //return object
         return obj;
     }

     public T getCurrent()
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         obj = Array[current];
         //return object
         return obj;
     }

     public T next()
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         current = current + 1;
         obj = Array[current];
         //return object
         return obj;
     }

     public T previous()
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         if(current > 0)
            current = current - 1;

         obj = Array[current];
         //return object
         return obj;
     }

     public int size()
     {
         return List.Count;
     }

     public LinkedList<T> getList()
     {
         return List;
     }

     public void convert()
     {
         Array = new T[List.Count];
         List.CopyTo(Array, 0);
     }

     private T[] convert(CFLinkedList<T> list2)
     {
         T[] array = new T[list2.size()];
         for(int i =0; i<list2.size(); i++)
          array[i] = list2.get(i);
         return array;
     }

	}

