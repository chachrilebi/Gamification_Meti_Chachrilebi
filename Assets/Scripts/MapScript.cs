#pragma warning disable CS0649
using UnityEngine;

public class MapScript : MonoBehaviour
{
    [SerializeField]
    public GameObject mapImage, mapImage1, mapARImage, mainImage;
    private void Awake()
    {
        mapARImage.SetActive(false);
        this.gameObject.SetActive(false);
    }
    public void MainMenu()
    {
        mainImage.SetActive(true);
        mapARImage.SetActive(false);
        mapImage1.SetActive(false);
        mapImage.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void MapMapMap()
    {
        mapImage1.SetActive(true);
        mapImage.SetActive(false);
    }
    private int i = 1;

    public void MapChanger()
    {

        if (mapImage.activeSelf)
        {
            mapARImage.SetActive(true);
            mapImage.SetActive(false);
            i = 1;
        }
        else if (mapImage1.activeSelf)
        {
            mapARImage.SetActive(true);
            mapImage1.SetActive(false);
            i = 2;
        }
        else if (i == 1)
        {
            mapARImage.SetActive(false);
            mapImage.SetActive(true);
        }
        else if (i == 2)
        {
            mapARImage.SetActive(false);
            mapImage1.SetActive(true);
        }
    }
}
