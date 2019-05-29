using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class NoteBookData
	
{  
    public ItemsFactory[] items = new ItemsFactory[10];
    public LinkedList<ItemsFactory> itemList = new LinkedList<ItemsFactory>();//use for count
    
    public NoteBookData()
    {
        items = NotebookInfo.getNotebook().getArr();
        itemList = NotebookInfo.getNotebook().getList();
    }


	
}

