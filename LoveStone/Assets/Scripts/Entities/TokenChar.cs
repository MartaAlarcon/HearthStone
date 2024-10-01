using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenChar : MonoBehaviour
{
    public string HP;
    public string Damage;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.gameManager.UpdateTokenUI(HP, Damage);

    }


    
}
