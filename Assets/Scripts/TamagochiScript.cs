#pragma warning disable CS0649
using UnityEngine;

public class TamagochiScript : MonoBehaviour
{
    [SerializeField]
    private GameObject mainImage;
    private void Awake()
    {
        this.gameObject.SetActive(false);
    }
    public void MainPage()
    {
        mainImage.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
