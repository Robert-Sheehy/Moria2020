using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDamagePopUp : MonoBehaviour
{
    TurnTimer testTimer;
    public Transform PopUpGO;
    DamagePopUp damgeInstance;
    IEnumerator co_routine;
    // Start is called before the first frame update
    private void Start()
    {
        damgeInstance = FindObjectOfType<DamagePopUp>();
        testTimer = new TurnTimer(300, 500);


    }


    IEnumerator delyayedAction(DamagePopUp textItem,string ValueasString,bool isCrit, int delay)
    {
        for (int i = 0;i<delay; i++)
        {   
            yield return null;
        }

        textItem.setText(ValueasString, isCrit);
    }
    // Update is called once per frame
 void Update()


    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            testTimer.tick();
            print(testTimer.timeleft);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            testTimer.AddTime(500);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {

            bool isCriticalHit = Random.Range(0, 100) < 30;
            Transform newPopUp =  Instantiate(PopUpGO);



            co_routine = delyayedAction(newPopUp.gameObject.GetComponent<DamagePopUp>(),"Hit",isCriticalHit, 4);
            StartCoroutine(co_routine);


        }
        
         
    }
}
