
using System;
using System.Collections.Generic;

public class Mon 
{
    public string MonName { get; set; }
    public List<Poke> MonPokes { get; set; }
    public List<Bone> MonBones { get; set; }  

    public Mon()
    {
        MonPokes = new List<Poke>();
        MonBones = new List<Bone>();
    }

    public static Mon GenerateNewMon()
    {
        Mon newMon = new Mon();
        var rand = new Random();
        newMon.MonName = "MonName" + rand.Next();

        for (int i = 1; i < 7; i++)
        {
            newMon.MonPokes.Add(Poke.GenerateNewPoke(i));
        }

        for (int i = 1; i < 7; i++)
        {
            newMon.MonBones.Add(Bone.GenerateNewBone(i));
        }

        return newMon;
    }
}
