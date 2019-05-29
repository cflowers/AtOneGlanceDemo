using UnityEngine;
using System.Collections.Generic;

	public class LaptopPlacementList : MonoBehaviour
	{
        private LinkedList<GameObject> items = new LinkedList<GameObject>();
        private HashSet<GameObject> objs = new HashSet<GameObject>();
        private CFLinkedList<LoadNotesSave> listSaveNotes = new CFLinkedList<LoadNotesSave>();

        public CFLinkedList<LoadNotesSave> ListSaveNotes
        {
            get { return listSaveNotes; }
            set { listSaveNotes = value; }
        }

        public void setItems(LinkedList<GameObject> items)
        {
            this.items = items;
        }

        public LinkedList<GameObject> getItems()
        {
            return items;
        }


        public void addElem(GameObject go)
        {
            this.items.AddLast(go);
        }

        public HashSet<GameObject> getObjs()
        {
            return objs;
        }
	}

