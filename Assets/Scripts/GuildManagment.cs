using System.Collections.Generic;
using UnityEngine;

public class GuildManagment : MonoBehaviour
{

    public List<Mon> MonGuildList;

    private void Start()
    {
        MonGuildList = new List<Mon>();
    }

    public Mon GenerateNewGuildMon()
    {
        Mon NewMon = Mon.GenerateNewMon();

        MonGuildList.Add(NewMon);

        return NewMon;
    }
}
