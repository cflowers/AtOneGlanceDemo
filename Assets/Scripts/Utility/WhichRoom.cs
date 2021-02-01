using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


/*
 * WhichRoom determines what buttons to show on screen
 * This is used in the PlaceButtonsMain class
 * and its set in the Background class
 * Initially the WHOLE_ROOM key already has a 
 * true value, everything else false
 * If player wants to see the envelope or wot not on
 * the floor, boolHandle checks for the key
 * and sets the ENVELOPE value to true and 
 * loops and sets everything else false etc
 * 
 */
public class WhichRoom
{
    public Dictionary<string, bool> map = new Dictionary<string, bool>();
    public LinkedList<string> list = new LinkedList<string>();
    public string currentName = "";

    public void fillMap()
    {
        map.Add("ENVELOPE", false);
        map.Add("WHOLE_ROOM", true);
        map.Add("ENVELOPE_CONT", false);
        map.Add("FIREPLACE", false);
        map.Add("FIREPLACE_UP", false);
        map.Add("FIREPLACE_DOWN", false);
        map.Add("FPD_MAP", false);
        map.Add("FPD_LETTER", false);
        map.Add("FPU_BOOMBOX", false);
        map.Add("FPU_PICL", false);
        map.Add("FPU_PICR", false);
        map.Add("FPU_PHONE", false);
        map.Add("TABLE", false);
        map.Add("TABLE_WINEBOTTLE", false);
        map.Add("TABLE_FWINEGLASS", false);
        map.Add("TABLE_EWINEGLASS", false);
        map.Add("BODY", false);
        map.Add("HAND", false);
        map.Add("ROUNDTABLE", false);
        map.Add("GOLDPHONE", false);
        map.Add("RT_PAPERS", false);
        map.Add("RT_PAPER1", false);
        map.Add("RT_PAPER2", false);
        map.Add("P_BOOKCASE", false);
        map.Add("COUCH", false);
        map.Add("COUCH_PILLOW", false);
        map.Add("COUCH_BOOK", false);
        map.Add("COUCH_CD_OPEN", false);
        map.Add("FP_MESS", false);
        map.Add("FP_MESS_PAPER1", false);
        map.Add("FP_MESS_PAPER2", false);
        map.Add("FP_MESS_LOG", false);
        map.Add("FIREPLACE_RIGHT", false);
        map.Add("FIREPLACE_LEFT", false);
        map.Add("BINDER", false);
        map.Add("FPACC_SHOVEL", false);
        map.Add("FPACC_PICK", false);
        map.Add("FPACC_BROOM", false);
        map.Add("FPACC_FORK", false);
        map.Add("WALL_PICS", false);
        map.Add("DAD_PIC", false);
        map.Add("SHELF_LEFT", false);
        map.Add("CLOCK", false);
        map.Add("TIGER", false);
        map.Add("GLOBE", false);
        map.Add("SL_BOOKS", false);
        map.Add("B_BOOKCASE", false);
        map.Add("G_BOOKCASE", false);
        map.Add("TICKET", false);
        map.Add("BBOOKCASE_UP", false);
        map.Add("SHELF_RIGHT", false);
        map.Add("CUP", false);
        map.Add("JAR", false);
        map.Add("HEAD", false);
        map.Add("AWARD", false);
        map.Add("CUPLOOK", false);
        map.Add("JARLOOK", false);
        map.Add("AWARDZM", false);
        map.Add("STATUE", false);
        map.Add("GOLDPH_CONTACTS", false);
        map.Add("GOLDPH_STACY", false);
        map.Add("GOLDPH_DAD", false);
        map.Add("GOLDPH_DAD_ZM", false);
        map.Add("GOLDPH_STACY_ZM", false);
        map.Add("GOLDPH_STACY_MESS2", false);
        map.Add("GOLDPH_STACY_ZM2", false);
        map.Add("GOLDPH_DAD_MESS2", false);
        map.Add("GOLDPH_DAD_ZM2", false);
        map.Add("BOOMBOX_OPEN", false);
        map.Add("PURPLEPH_CONTACTS", false);
        map.Add("PURPLEPH_FAREED", false);
        map.Add("PURPLEPH_FAREED_MESS2", false);
        map.Add("PURPLEPH_FAREED_ZM2", false);
        map.Add("PURPLEPH_FAREED_MESS3", false);
        map.Add("PURPLEPH_FAREED_ZM3", false);
        map.Add("ANTHRAX_BOOK", false);
        map.Add("GUN", false);
        map.Add("TICKET_F", false);
    }

    public void fillList()
    {
        list.AddFirst("ENVELOPE_CONT");
        list.AddFirst("FPD_MAP");
        list.AddFirst("FPD_LETTER");
        list.AddFirst("FPU_PICL");
        list.AddFirst("FPU_PICR");
        list.AddFirst("BOOMBOX_OPEN");
        list.AddFirst("PURPLEPH_FAREED");
        list.AddFirst("PURPLEPH_FAREED_MESS2");
        list.AddFirst("PURPLEPH_FAREED_MESS3");
        list.AddFirst("TABLE_WINEBOTTLE");
        list.AddFirst("TABLE_FWINEGLASS");
        list.AddFirst("TABLE_EWINEGLASS");
        list.AddFirst("GOLDPH_STACY");
        list.AddFirst("GOLDPH_DAD");
        list.AddFirst("GOLDPH_STACY_ZM");
        list.AddFirst("GOLDPH_STACY_MESS2");
        list.AddFirst("GOLDPH_STACY_ZM2");
        list.AddFirst("GOLDPH_DAD_MESS2");
        list.AddFirst("GOLDPH_DAD_ZM2");
        list.AddFirst("RT_PAPER1");
        list.AddFirst("RT_PAPER2");
        list.AddFirst("P_BOOKCASE");
        list.AddFirst("COUCH_BOOK");
        list.AddFirst("COUCH_CD_OPEN");
        list.AddFirst("FP_MESS_PAPER1");
        list.AddFirst("FP_MESS_PAPER2");
        list.AddFirst("FP_MESS_LOG");
        list.AddFirst("FIREPLACE_RIGHT");
        list.AddFirst("BINDER");
        list.AddFirst("FPACC_SHOVEL");
        list.AddFirst("FPACC_PICK");
        list.AddFirst("FPACC_BROOM");
        list.AddFirst("FPACC_FORK");
        list.AddFirst("WALL_PICS");
        list.AddFirst("DAD_PIC");
        list.AddFirst("CLOCK");
        list.AddFirst("TIGER");
        list.AddFirst("GLOBE");
        list.AddFirst("G_BOOKCASE");
        list.AddFirst("TICKET");
        list.AddFirst("BBOOKCASE_UP");
        list.AddFirst("HEAD");
        list.AddFirst("CUPLOOK");
        list.AddFirst("JARLOOK");
        list.AddFirst("AWARDZM");
        list.AddFirst("STATUE");
        list.AddFirst("ANTHRAX_BOOK");
        list.AddFirst("GUN");
        list.AddFirst("TICKET_F");
    }


    public void boolHandle(string name)
    {
        currentName = name;
        List<string> keys = new List<string>(map.Keys);

        foreach (string key in keys)
        {
            if (key == name)
                map[key] = true;
            else
                map[key] = false;
        }
    }

    public bool cursorCheckName(string name)
    {
        bool check = false;
        //Debug.Log("Name:" + name);
        currentName = name;
        List<string> keys = new List<string>(list);

        foreach (string key in keys)
        {
            if (key == name)
            {
                check = true;
                break;
            }
        }

        return check;
    }

}
        


 