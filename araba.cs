using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class araba : MonoBehaviour
{
    public WheelCollider solArkateker, sagArkateker, solOnteker, sagOnteker;
    public Joystick tus;
    public float kontrol;
  //  public Text hiztext;
    public float motorhizi, donmehizi;
    public GameObject nosb;
    public GameObject dkilitb;
    public GameObject direksiyon;
   // public GameObject elfren;
   public GameObject fpscam1;
      public GameObject tpscam1;
    public int kameraayar = 1;


    void Start()
    {
        
    }

  
    void Update()
    {
        if (kontrol == 0)
        {
            sagArkateker.motorTorque = motorhizi * Input.GetAxis("Vertical");
            solArkateker.motorTorque = motorhizi * Input.GetAxis("Vertical");
            sagOnteker.steerAngle = donmehizi * Input.GetAxis("Horizontal");
            solOnteker.steerAngle = donmehizi * Input.GetAxis("Horizontal");
        }
        else if (kontrol == 1)
        {
            //joystick kontrolleri
            sagArkateker.motorTorque = motorhizi * tus.Vertical;
            solArkateker.motorTorque = motorhizi * tus.Vertical;
            sagOnteker.steerAngle = donmehizi * tus.Horizontal;
            solOnteker.steerAngle = donmehizi * tus.Horizontal;
        }

        if (kameraayar==1)
        {
            tpscam1.gameObject.SetActive(true);
            fpscam1.gameObject.SetActive(false);
        }
        else if (kameraayar==0)
        {
            tpscam1.gameObject.SetActive(false);
            fpscam1.gameObject.SetActive(true);
        }

        //hiztext.text = sagArkateker.motorTorque.ToString();
    }


    public void nos()
    {
        motorhizi = 2050;
        donmehizi = 5;
        nosb.gameObject.SetActive(false);
    }
    public void dkilit()
    {
        motorhizi = 8500;
        donmehizi = 0;
        dkilitb.gameObject.SetActive(false);
        direksiyon.gameObject.SetActive(false);
    }

    public void relo() {
        var pos = transform.position;
        pos.y += 3f;
        transform.position = pos;
        transform.rotation = Quaternion.identity;
    }

    public void kameradegistir(){
       
if (kameraayar == 1)
{
    kameraayar -= 1;
}
else if (kameraayar == 0)
{
    kameraayar += 1;
}
    }
   
}
