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

     public void Add(T node)
     {
         list.AddLast(node);
     }

     public void AddAll(CFLinkedList<T> list2)
     {
         T[] arr = convert(list2);
         for (int i = 0; i < arr.Length; i++)
             list.AddLast(arr[i]);
     }

     public void Remove()
     {
         list.RemoveLast();
     }

     public void RemoveObj(T obj)
     {
         list.Remove(obj);
     }

     public T get(int index)
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         obj = array[index];
         //return object
         return obj;
     }

     public T getFirst()
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         obj = array[0];
         //return object
         return obj;
     }

     public T getLast()
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         obj = array[list.Count-1];
         //return object
         return obj;
     }

     public T getCurrent()
     {
         T obj;
         //convert list to array
         convert();
         //get object per index of array
         obj = array[current];
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
         obj = array[current];
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

         obj = array[current];
         //return object
         return obj;
     }

     public int size()
     {
         return list.Count;
     }

     public LinkedList<T> getList()
     {
         return list;
     }

     private void convert()
     {
         array = new T[list.Count];
         list.CopyTo(array, 0);
     }

     private T[] convert(CFLinkedList<T> list2)
     {
         T[] array = new T[list2.size()];
         for(int i =0; i<list2.size(); i++)
          array[i] = list2.get(i);
         return array;
     }

	}

