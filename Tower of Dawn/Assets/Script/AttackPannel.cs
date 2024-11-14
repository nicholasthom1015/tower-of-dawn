using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackPannel : MonoBehaviour
{
    public Button Attack;
    public Button Item;
    public Button Run;
    public Button Player1AttackList;
    public GameObject CombatDetails;
    public GameObject Player1AttackListGameObject;
    public GameObject AttackGameObject;
    public GameObject ItemGameObject;
    public GameObject RunGameObject;

    // Start is called before the first frame update
    void Start()
    {
        CombatDetails.SetActive(false);
        Attack.onClick.AddListener(ActivateAttackList);
        Player1AttackList.onClick.AddListener(ActivateCombatDetails);
    }

    private void ActivateAttackList()
    {
        Player1AttackListGameObject.SetActive(true);
        AttackGameObject.SetActive(false);
        ItemGameObject.SetActive(false);
        RunGameObject.SetActive(false);
    }

    private void ActivateCombatDetails()
    {
        CombatDetails.SetActive(true);
        Player1AttackListGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
