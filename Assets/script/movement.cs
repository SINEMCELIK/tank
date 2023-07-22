using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float hareketHizi = 5f;
    public float donusHizi = 60f;

    void Update()
    {
        float hareketInput = Input.GetAxis("Vertical");
        float donusInput = Input.GetAxis("Horizontal");

        HareketEt(hareketInput);
        DonusYap(donusInput);
    }

    void HareketEt(float hareketInput)
    {
        Vector3 hareket = transform.forward * hareketInput * hareketHizi * Time.deltaTime;
        transform.position += hareket;
    }

    void DonusYap(float donusInput)
    {
        float donusMiktari = donusInput * donusHizi * Time.deltaTime;
        Quaternion donusAci = Quaternion.Euler(0f, donusMiktari, 0f);
        transform.rotation *= donusAci;
    }
}
