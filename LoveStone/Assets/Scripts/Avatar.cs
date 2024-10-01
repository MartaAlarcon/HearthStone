using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using static UnityEngine.EventSystems.EventTrigger;

public class Avatar : Fighter
{
    public Power Power;
    public int Armor;
    public EntitySO EntitySO;

    public void Start()
    {
        ShowCard();
    }
    public void ShowCard()
    {
        GameManager.gameManager.UpdateAvatarUI(EntitySO);

    }
}
