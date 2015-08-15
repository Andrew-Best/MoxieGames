using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BattleController : MonoBehaviour
{
    /******TEST CODE*********/
    Character player;
    Character testAI;
    Text testText;
    /*****END TEST CODE******/

	void Start () 
    {
        GameObject test = GameObject.Find("CharacterInfo");
        testText = test.GetComponent<Text>();
        Equipment testE = new Equipment("Excaliburrrrr", 100, 100, 100, 100, 100, 100, 100, 200, 0, 0, 0);
        player = new Character("Steve", 1.0f, 1, 1000, 10, 5, 5, 5, 5, 5, 5, 50, 50, 50, 10, 100, null);
        testAI = new Character("Frank", 10.0f, 2, 20, 20, 10, 10, 10, 10, 10, 10, 100, 100, 100, 20, 100, testE);
	}

    void Update()
    {
        testText.text = player.DisplayInformation() + "\n\n" + testAI.DisplayInformation();
    }

    /// <summary>This function will deal damage to the attacker's target and call that character's appropriate TakeDamage function</summary>
    public void DealDamage()
    {
        player.TakeDamage(testAI.Attack());
    }

    public void GainExperience()
    {
        player.GiveExp(600);
    }
}
