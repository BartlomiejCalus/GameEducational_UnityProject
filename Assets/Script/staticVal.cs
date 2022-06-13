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
    public static void save()
    {
        using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
        {
            for(int i = 0; i < theBest.Length; i++)
            bw.Write(theBest[i]);
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
            }
        }
        
    }

}
