using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEffect 
{

    void Effect();
    void Effect(Fighter target);
    void Effect(Fighter[] target);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
