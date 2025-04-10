using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponets : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherSccript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;

    // Start is called before the first frame update
    void Awake()
    {

        anotherScript = GetComponent<AnotherSccript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();

    }

    // Update is called once per frame
    void start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
