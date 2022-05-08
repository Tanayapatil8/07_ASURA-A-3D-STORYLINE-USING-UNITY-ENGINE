using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : Interactable
{
    public GameObject _puzzle;
    void Start()
    {
        //wm = GameObject.FindGameObjectWithTag("Player").GetComponent<WeaponManager>();
    }
    public override string GetDescription()
    {
        return "Press [E] to view puzzle.";
    }

    public override void Interact()
    {
        _puzzle.SetActive(true);
    }
}
