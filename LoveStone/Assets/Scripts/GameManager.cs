using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    // UI Elements for a Character Card
    public Image Char, Spell, Token, Power, Avatar;
    public Text CharMana, CharDMG, CharHP, CharDesc, SpellMana, SpellDesc, PowerMana, TokenHP, TokenDMG, AvatarName;

    private void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gameManager = this;
        }
    }

    // Method to update the UI based on a Character card
    public void UpdateCharacterCardUI(CharacterSO characterSO, int mana, int dmg, int hp)
    {
        Char.sprite = characterSO.Design;
        CharMana.text = mana.ToString();
        CharDMG.text = dmg.ToString();
        CharHP.text = hp.ToString();
        CharDesc.text = characterSO.Description;
    }
    public void UpdateSpellCardUI(EntitySO entitySO, int mana)
    {
        Spell.sprite = entitySO.Design;
        SpellMana.text = mana.ToString();
        SpellDesc.text = entitySO.Description;
    }
    public void UpdateAvatarUI(EntitySO entitySO)
    {
        Avatar.sprite = entitySO.Design;
        AvatarName.text = entitySO.Name;    

    }
    public void UpdateTokenUI(string hp, string dammage)
    {
        TokenDMG.text = hp;
        TokenHP.text = dammage;

    }
}
