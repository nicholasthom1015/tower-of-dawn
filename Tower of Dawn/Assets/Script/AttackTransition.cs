using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTransition : MonoBehaviour
{
    public GameObject Attack;
    public GameObject Item;
    public GameObject Run;
    public GameObject Player1AttackList;
    public GameObject CombatDetails;

    [SerializeField] private bool isL1;
    [SerializeField] private bool isL2;

    void Start()
    {
        CombatDetails.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isL1)
            {
                Attack.SetActive(false);
                Item.SetActive(false);
                Run.SetActive(false);
                // CombatDetails.SetActive(false);
                Player1AttackList.SetActive(true);
            }

        if (isL2)
        {
            // Attack.SetActive(true);
            // Item.SetActive(true);
            // Run.SetActive(true);
            CombatDetails.SetActive(true);
            Player1AttackList.SetActive(false);
        }
    }
}
