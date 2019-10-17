using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class DamagePopUp : MonoBehaviour
{
    private  float DISAPPEAR_TIMER_MAX = 1f;
    private float DISAPPEAR_HEIGHT_MAX = 6F;
    public Vector3 RandomizeIntensity = new Vector3(4f, 2, 0);

    private Vector3 startPosition, endPosition;
    private float disappearTimer;
    private float journeyLength;
    TMP_Text theTextObject;
    // Start is called before the first frame update
    void Start()
    {
        disappearTimer = 0;
        theTextObject = GetComponentInChildren<TMP_Text>();
        startPosition = transform.position;
        endPosition = startPosition + DISAPPEAR_HEIGHT_MAX * Vector3.up;
        textColor = Color.red;
        //endPosition = new Vector3(Random.Range(-10f, 10f), 1.4f, Random.Range(-10f, 10f));
        // journeyLength = Vector3.Distance(startPosition, endPosition);

        endPosition += new Vector3(Random.Range(-RandomizeIntensity.x, RandomizeIntensity.x),
                                   Random.Range(-RandomizeIntensity.y, RandomizeIntensity.y),
                                   Random.Range(-RandomizeIntensity.z, RandomizeIntensity.z));

    }


    //  public void setup (int damageAmount, bool isCriticalHit)
    //{
    //    textMesh.SetText(damageAmount.ToString());
    //    if (!isCriticalHit)
    //    {
    //        //Normal hit
    //        textMesh.fontSize = 36;
    //        textColor = Color.red;
    //    }
    //    else
    //    {
    //        //Critical
    //        textMesh.fontSize = 45;
    //        textColor = new Color(1.0f, (165.0f / 255.0f), 0);
    //    }

    //}


    // Update is called once per frame
    void Update()
    {
        disappearTimer += Time.deltaTime;

        transform.position = Vector3.Lerp(startPosition, endPosition, disappearTimer / DISAPPEAR_TIMER_MAX);

        theTextObject.color = new Color(textColor.r, textColor.g, textColor.b, Mathf.Lerp(1,0, disappearTimer / DISAPPEAR_TIMER_MAX));

        if (disappearTimer > DISAPPEAR_TIMER_MAX) Destroy(gameObject);

    }

    private static int sortInOrder;

 

    private TextMeshPro textMesh;

    private Color textColor;
    private Vector3 moveVector;




  //void Update()
  //  {
  //      transform.position += moveVector * Time.deltaTime;
  //      moveVector -= moveVector * 8f * Time.deltaTime;

  //      if (disappearTimer) DISAPPEAR_TIMER_MAX * .5f) {
  //          float increaseScaleAmount = 1f;
  //          transform.localScale += Vector3.one * increaseScaleAmount * Time.deltaTime;
  //      } else {
  //          float decreaseScaleAmount = 1f;
  //          transform.localScale -= Vector3.one * decreaseScaleAmount * Time.deltaTime;
  //      }

  //      disappearTimer -= Time.deltaTime;
  //      if (disappearTimer < 0)
  //      {

  //          float disappearSpeed = 3f;
  //          textColor.a -= disappearSpeed * Time.deltaTime;
  //          Color TextMesh = textColor;
  //          if (textColor.a < 0)
  //          {
  //              Destroy(gameObject);
  //          }
  //      }
  //  }

    internal void setText(string v, bool isCrit)
    {
        theTextObject.text = v;

       
        if (!isCrit)
        {
            //Normal hit
            theTextObject.fontSize = 36;
            textColor = Color.red;
        }
        else
        {
            //Critical
            theTextObject.fontSize = 45;
            textColor = new Color(1.0f, (165.0f / 255.0f), 0);
        }
    }
}
