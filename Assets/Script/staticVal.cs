using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class staticVal
{
    public static int dif;
    public static int [] theBest = {0,0,0};
    public static FileInfo f = new FileInfo("save.bin");
    public static int angBest;
    public static int ileGeoAsk;
    public static List<Quest> ans;
    public static bool nxt = true;

    public static List<Quest> Quests = new List<Quest>
    {
        new Quest("Albania","Tirana"),new Quest("Andora","Andorra la Vella"),new Quest("Austria","Wiedeñ"),new Quest("Belgia","Bruksela"),new Quest("Bia³oruœ","Miñsk"),new Quest("Boœnia i Hercegowina","Sarajewo"),new Quest("Bu³garia","Sofia"),new Quest("Chorwacja","Zagrzeb"),new Quest("Czarnogóra","Podgorica"),
        new Quest("Czechy","Praga"),new Quest("Dania","Kopenhaga"),new Quest("Estonia","Tallin"),new Quest("Finlandia","Helsinki"),new Quest("Francja","Pary¿"),new Quest("Grecja","Ateny"),new Quest("Hiszpania","Madryt"),new Quest("Holandia","Amsterdam"),new Quest("Irlandia","Dublin"),new Quest("Kosowo","Prisztina"),new Quest("Islandia","Rejkiawik"),new Quest("Liechtenstein","Vaduz"),new Quest("Litwa","Wilno"),new Quest("Luksemburg","Luksemburg"),
        new Quest("£otwa","Ryga"),new Quest("Macedonia","Skopje"),new Quest("Malta","Valletta"),new Quest("Mo³dawia","Kiszyniów"),new Quest("Monako","Monako"),new Quest("Niemcy","Berlin"),new Quest("Norwegia","Oslo"),new Quest("Polska","Warszawa"),new Quest("Portugalia","Lizbona"),new Quest("Rosja","Moskwa"),new Quest("Rumunia","Bukareszt"),new Quest("",""),new Quest("San Marino","San Marino"),new Quest("Serbia","Belgrad"),
        new Quest("S³owacja","Bratys³awa"),new Quest("S³owenia","Lublana"),new Quest("Szwajcaria","Berno"),new Quest("Szwecja","Sztokholm"),new Quest("Ukraina","Kijów"),new Quest("Watykan","Watykan"),new Quest("Wêgry","Budapeszt"),new Quest("Wielka Brytania","Londyn"),new Quest("W³ochy","Rzym")
    };
    public static void save()
    {
        using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
        {
            for(int i = 0; i < theBest.Length; i++)
                bw.Write(theBest[i]);

            bw.Write(angBest);
            bw.Close();
        }
       

    }

    public static void load()
    {
        if (f.Exists)
        {
            using (BinaryReader br = new BinaryReader(f.OpenRead()))
            {
                for (int i = 0; i < theBest.Length; i++)
                    theBest[i] = br.ReadInt32();

                angBest = br.ReadInt32();
                br.Close();
            }
        }
        
    }

}
