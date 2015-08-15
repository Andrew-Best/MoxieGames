using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour
{
    /// <summary>The player's party member array, this array is limited to 4 including the player themselves</summary>
    public List<Character> m_PartyMembers = new List<Character>();
    /// <summary>In game currency</summary>
    private int coins_;

    Text testParty;

    void Start()
    {
        testParty = GameObject.Find("PartyInfo").GetComponent<Text>();
    }

    void Update()
    {
        testParty.text = DisplayPartyInformation();
    }

    string DisplayPartyInformation()
    {
        string tempString = "";
        for(int i = 0; i < m_PartyMembers.Count; ++i)
        {
            tempString += m_PartyMembers[i].Name + "\n";
        }
        return tempString;
    }
}