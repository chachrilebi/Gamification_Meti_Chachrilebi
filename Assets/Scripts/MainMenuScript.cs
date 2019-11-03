#pragma warning disable CS0649
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject hamburgerMenu, tamagochi/*, rankBoard*/, map;

    private void Awake()
    {
        this.gameObject.SetActive(true);        
    }
    public void HamburgerButton()
    {
        hamburgerMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }
    
    public void TamagochiButton()
    {
        tamagochi.SetActive(true);
        this.gameObject.SetActive(false);
    }
    /*
    public void RankBoardButton()
    {
        rankBoard.SetActive(true);
        this.gameObject.SetActive(false);
    }*/
    public void MapButton()
    {
        map.SetActive(true);
        this.gameObject.SetActive(false);
    }


}
