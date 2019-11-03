#pragma warning disable CS0649
using UnityEngine;

public class PlayerStatsScript : MonoBehaviour
{
    [SerializeField]
    private GameObject mainPage;
    private void Awake()
    {
        this.gameObject.SetActive(false);
    }
    public void MainMenu()
    {
        mainPage.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
