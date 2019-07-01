using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class NotebookInfo : MonoBehaviour {


    private static NotebookInfo m_instance;
    private static ItemsFactory[] items = new ItemsFactory[50];
    private static int index = 0;
    private static LinkedList<ItemsFactory> itemList = new LinkedList<ItemsFactory>();//use for count

    void Awake()
    {
        assignInstance();
      //  NotebookInfo.itemList =  new LinkedList<ItemsFactory>();
    }

    void assignInstance()
    {
        if (m_instance != null && m_instance != this)
            Destroy(this);
        else
            m_instance = this;
    }
    

    public static NotebookInfo getNotebook()
    {
        return m_instance;
    }

    public void AddItem(ItemsFactory item)
    {
         Debug.Log("Notebook:" + NotebookInfo.itemList.Count);
        NotebookInfo.itemList.AddLast(item);
        NotebookInfo.items[index] = item;
        index = index + 1;
        Debug.Log("Notebook:" + NotebookInfo.itemList.Count);
    }

    public ItemsFactory getFirstItemArr()
    {
        return NotebookInfo.items[0];
    }

    public ItemsFactory[] getArr()
    {
        return NotebookInfo.items;
    }

    public ItemsFactory getFirstItem()
    {
        return NotebookInfo.itemList.First.Value;
    }

    public LinkedList<ItemsFactory> getList()
    {
        return NotebookInfo.itemList;
    }

    public void setArr(ItemsFactory[] items)
    {
        NotebookInfo.items = items;
    }

    public void setList(LinkedList<ItemsFactory> itemList)
    {
        NotebookInfo.itemList = itemList;
    }
}
