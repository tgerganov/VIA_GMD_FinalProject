using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public Text Content;
    public Image Thumbnail;
    public Text Title;

    ItemData itemData;

    private void Start()
    {
        itemData = XMLSync.DeserializeFile<ItemData>(Application.streamingAssetsPath + "/Data.xml");
    }

    private void Update()
    {
        OpenPanel();
    }

    public void OpenPanel()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Sun");
            Title.text = itemData.items[0].name;
            Content.text = itemData.items[0].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Mercury");
            Title.text = itemData.items[1].name;
            Content.text = itemData.items[1].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Venus");
            Title.text = itemData.items[2].name;
            Content.text = itemData.items[2].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Earth");
            Title.text = itemData.items[3].name;
            Content.text = itemData.items[3].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Mars");
            Title.text = itemData.items[4].name;
            Content.text = itemData.items[4].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Jupiter");
            Title.text = itemData.items[5].name;
            Content.text = itemData.items[5].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Saturn");
            Title.text = itemData.items[6].name;
            Content.text = itemData.items[6].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Uranus");
            Title.text = itemData.items[7].name;
            Content.text = itemData.items[7].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Neptune");
            Title.text = itemData.items[8].name;
            Content.text = itemData.items[8].information;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Pluto_2");
            Title.text = itemData.items[9].name;
            Content.text = itemData.items[9].information;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            ActivatePanel();
            Thumbnail.sprite = Resources.Load<Sprite>("Thumbnails/Moon");
            Title.text = itemData.items[10].name;
            Content.text = itemData.items[10].information;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(false);
        }
    }

    public void ActivatePanel()
    {
        Panel.SetActive(true);
    }
}
