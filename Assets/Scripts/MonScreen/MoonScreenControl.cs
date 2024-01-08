using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoonScreenControl : MonoBehaviour
{
    public Mon ActualMon;
    public bool PokeView = false;
    public GuildManagment GuildManagment;
    public List<Image> imagesList;
    public GameObject textGameObject;

    public void GenerateMoon()
    {
        ActualMon = GuildManagment.GenerateNewGuildMon();


        imagesList[0].sprite = LoadSprite(ActualMon.MonPokes[0].ImageRoute);
        imagesList[1].sprite = LoadSprite(ActualMon.MonPokes[1].ImageRoute);
        imagesList[2].sprite = LoadSprite(ActualMon.MonPokes[2].ImageRoute);
        imagesList[3].sprite = LoadSprite(ActualMon.MonPokes[3].ImageRoute);
        imagesList[4].sprite = LoadSprite(ActualMon.MonPokes[4].ImageRoute);
        imagesList[5].sprite = LoadSprite(ActualMon.MonPokes[5].ImageRoute);
    }


    public void ChangeStatsTest()
    {
        textGameObject.GetComponent<TextMeshProUGUI>().text = "Nananana";
    }

    private Sprite LoadSprite(string path)
    {
        if (string.IsNullOrEmpty(path)) return null;
            if (File.Exists(path))
            {
                byte[] bytes = File.ReadAllBytes(path);
                Texture2D texture = new Texture2D(100, 100, TextureFormat.RGB24, false);
                texture.LoadImage(bytes);
                Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                return sprite;
            }
        return null;
    }
}
