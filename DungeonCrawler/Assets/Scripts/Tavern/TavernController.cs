using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TavernController : MonoBehaviour
{
    /// <summary>Player stats script</summary>
    private PlayerStats pStats_;

    //Test code
    GameObject testChar;
    Button testPurchase;
    void Start()
    {
        pStats_ = GameObject.Find("PlayerStats").GetComponent<PlayerStats>();
        testChar = GameObject.Find("TestChar");
        Character blah = new Character("Blah", 1.0f, 1, 10, 10, 10, 10, 10, 10, 10, 10, 100, 100, 100, 100, 100, null);
        Character meh = new Character("Meh", 1.0f, 1, 10, 10, 10, 10, 10, 10, 10, 10, 100, 100, 100, 100, 100, null);
        testPurchase = GameObject.Find("TestPurchase").GetComponent<Button>();
        testPurchase.onClick.AddListener(delegate { HireMember(blah); });
        /*AddMember(blah, blah.HireCost);
        AddMember(meh, meh.HireCost);*/
    }

    /// <summary>Add a character to the player's party, if the hire cost of the character is 0 this character is not available for purchase</summary>
    /// <param name="c">Character script of the character that is being hired</param>
    public void HireMember(Character c)
    {
        if(c == null)
        {
            Debug.LogError("Character is null in HireMember");
        }
        if(c.HireCost > 0)
        {
            if (!pStats_.m_PartyMembers.Contains(c))
            {
                pStats_.m_PartyMembers.Add(c);
            }
            else
            {
                Debug.LogWarning("Character is already hired");
            }
        }
    }

    /// <summary>Remove a character from the player's party</summary>
    /// <param name="c">Character script of the character that is being removed from the player's party</param>
    public void RemoveMember(Character c)
    {
        if(c == null)
        {
            Debug.LogError("Character is null in RemoveMember");
        }
        if(pStats_.m_PartyMembers.Contains(c))
        {
            pStats_.m_PartyMembers.Remove(c);
        }
        else
        {
            Debug.LogWarning("Character has already been removed");
        }
    }
}