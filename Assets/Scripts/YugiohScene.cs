using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YugiohScene : MonoBehaviour
{

    public TMP_Text P1lifePoints;

    public double P1currentLifePoints = 8000;

    public Button P1Rm1000Btn;
    public Button P1Rm500Btn;
    public Button P1AddSliderBtn;
    public Button P1MinusSliderBtn;
    public Button P1Add1000Btn;
    public Button P1Add500Btn;
    public Slider P1Slider;
    public TMP_Text P1SliderValTxt;
    private int P1sliderVal;

    private int MAXTIME = 8000;



    public TMP_Text P2lifePoints;
    public double P2currentLifePoints = 8000;

    public Button P2Rm1000Btn;
    public Button P2Rm500Btn;
    public Button P2AddSliderBtn;
    public Button P2MinusSliderBtn;
    public Button P2Add1000Btn;
    public Button P2Add500Btn;
    public Slider P2Slider;
    public TMP_Text P2SliderValTxt;
    private int P2sliderVal;


    public AudioClip lPMidSound;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        P1lifePoints.text = P1currentLifePoints.ToString("0");

        //slider increase by 500
        P1sliderVal = (int)P1Slider.value * 10;


        P1SliderValTxt.text = P1sliderVal.ToString();


        P2lifePoints.text = P2currentLifePoints.ToString("0");

        P2sliderVal = (int)P2Slider.value * 10;

        P2SliderValTxt.text = P2sliderVal.ToString();


    }

    public void sliderEnter()
    {
        //currentLifePoints += p1sliderVal;
        StartCoroutine(P1addSetAmountLP(P1sliderVal));
    }

    public void sliderRemove()
    {
        //currentLifePoints += p1sliderVal;
        StartCoroutine(P1MinusSetAmountLP(P1sliderVal));
    }

    public void remove1000() 
    {
        StartCoroutine(P1MinusSetAmountLP(1000));
    }


    public void remove500()
    {
        StartCoroutine(P1MinusSetAmountLP(500));
    }

    public void add500()
    {
        StartCoroutine(P1addSetAmountLP(500));
    }



    public void add1000()
    {
        StartCoroutine(P1addSetAmountLP(1000));
    }


    IEnumerator P1addSetAmountLP(int iNum) //Increases lifepoints by input amount
    {
        double previousLifePoints = P1currentLifePoints;
        P1Rm1000Btn.enabled = false;
        P1Rm500Btn.enabled = false;
        P1Add1000Btn.enabled = false;
        P1Add500Btn.enabled = false;
        P1AddSliderBtn.enabled = false;
        P1MinusSliderBtn.enabled = false;

        if (iNum > 0)
            while (true)
            {
                yield return new WaitForSeconds((float)0.000000000001);
                P1currentLifePoints += (float)4.0;

                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().PlayOneShot(lPMidSound);

                if (P1currentLifePoints == (previousLifePoints + iNum)) //change number 
                {
                    P1Rm1000Btn.enabled = true;
                    P1Rm500Btn.enabled = true;
                    P1Add1000Btn.enabled = true;
                    P1Add500Btn.enabled = true;
                    P1AddSliderBtn.enabled = true;
                    P1MinusSliderBtn.enabled = true;
                    break;
                }
            }
    }

    IEnumerator P1MinusSetAmountLP(int iNum) //Increases lifepoints by input amount
    {
        double previousLifePoints = P1currentLifePoints;
        P1Rm1000Btn.enabled = false;
        P1Rm500Btn.enabled = false;
        P1Add1000Btn.enabled = false;
        P1Add500Btn.enabled = false;
        P1AddSliderBtn.enabled = false;
        P1MinusSliderBtn.enabled = false;

        if (iNum > 0)
            while (true)
            {
                yield return new WaitForSeconds((float)0.000000000001);
                P1currentLifePoints -= (float)4.0;

                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().PlayOneShot(lPMidSound);

                if (P1currentLifePoints == (previousLifePoints - iNum)) //change number 
                {
                    P1Rm1000Btn.enabled = true;
                    P1Rm500Btn.enabled = true;
                    P1Add1000Btn.enabled = true;
                    P1Add500Btn.enabled = true;
                    P1AddSliderBtn.enabled = true;
                    P1MinusSliderBtn.enabled = true;
                    break;
                }
            }
    }

    /*
     * Player 2 content:
     * 
     */
    public void p2SliderEnter()
    {
        //currentLifePoints += p1sliderVal;
        StartCoroutine(p2AddSetAmountLP(P1sliderVal));

    }

    public void p2Remove1000()
    {
        StartCoroutine(p2MinusSetAmountLP(1000));
    }


    public void p2Remove500()
    {
        StartCoroutine(p2MinusSetAmountLP(500));
    }

    public void p2Add500()
    {
        StartCoroutine(p2AddSetAmountLP(500));
    }



    public void p2Add1000()
    {
        StartCoroutine(p2AddSetAmountLP(1000));
    }



    IEnumerator p2AddSetAmountLP(int iNum) //Increases lifepoints by input amount
    {
        double previousLifePoints = P2currentLifePoints;
        P2Rm1000Btn.enabled = false;
        P2Rm500Btn.enabled = false;
        P2Add1000Btn.enabled = false;
        P2Add500Btn.enabled = false;
        P2AddSliderBtn.enabled = false;
        P2MinusSliderBtn.enabled = false;

        if (iNum > 0)
            while (true)
            {
                yield return new WaitForSeconds((float)0.00001);
                P2currentLifePoints += (float)1.0;

                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().PlayOneShot(lPMidSound);

                if (P2currentLifePoints == (previousLifePoints + iNum)) //change number 
                {
                    P2Rm1000Btn.enabled = true;
                    P2Rm500Btn.enabled = true;
                    P2Add1000Btn.enabled = true;
                    P2Add500Btn.enabled = true;
                    P2AddSliderBtn.enabled = true;
                    P2MinusSliderBtn.enabled = true;
                    break;
                }
            }
    }

    IEnumerator p2MinusSetAmountLP(int iNum) //Increases lifepoints by input amount
    {
        double previousLifePoints = P2currentLifePoints;
        P2Rm1000Btn.enabled = false;
        P2Rm500Btn.enabled = false;
        P2Add1000Btn.enabled = false;
        P2Add500Btn.enabled = false;
        P2AddSliderBtn.enabled = false;
        P2MinusSliderBtn.enabled = false;

        if (iNum > 0)
            while (true)
            {
                yield return new WaitForSeconds((float)0.00001);
                P2currentLifePoints -= (float)1.0;

                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().PlayOneShot(lPMidSound);

                if (P2currentLifePoints == (previousLifePoints - iNum)) //change number 
                {
                    P2Rm1000Btn.enabled = true;
                    P2Rm500Btn.enabled = true;
                    P2Add1000Btn.enabled = true;
                    P2Add500Btn.enabled = true;
                    P2AddSliderBtn.enabled = true;
                    P2MinusSliderBtn.enabled = true;
                    break;
                }
            }
    }



}
