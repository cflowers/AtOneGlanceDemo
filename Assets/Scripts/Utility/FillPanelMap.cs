using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


	public class FillPanelMap
	{
        Dictionary<string, SuspectGameObject> map = new Dictionary<string, SuspectGameObject>();

        public void fillPanelMap()
        {
            map.Add("LISA HAWK", new LisaGameObject());
            map.Add("BRANDON HAWK", new DadGameObject());
            map.Add("STACY HAWK", new SisGameObject());
            map.Add("FAREED", new FareedGameObject());

        }

        public Dictionary<string, SuspectGameObject> Map
        {
            get { return map; }
            set { map = value; }
        }

	}

