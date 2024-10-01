using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SpellCard : Card
{
    public EntitySO Entity;
    // Start is called before the first frame update

    public void Start()
    {
        ShowCard();
    }
    public void ShowCard()
    {
        GameManager.gameManager.UpdateSpellCardUI(Entity, Mana);

    }

    
}
