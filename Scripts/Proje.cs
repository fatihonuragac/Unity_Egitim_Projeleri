using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proje : MonoBehaviour
{

    void bolenleribul(int a, int b)
    {
        float[] sayilar = new float[b - a+1];
        int d = 0;
        string listsayilar = " ";
        string list2 = " ";
        string list3 = " ";
        string list4 = " ";
        string list5 = " ";
        

        for (int i = a; i <= b; i++)
        {
            sayilar[d] = i;
            listsayilar += " " + sayilar[d];
            d++;
        }
        
        
        print("Sayilar:"+listsayilar);
     
        for (int j = 0; j <= b - a; j++)
        {
            if (sayilar[j] % 2 == 0)
            {
                list2+=" "+sayilar[j];
            }
        }
        print("2'ye Bölünenler" + list2);
        for (int j = 0; j <= b - a; j++)
        {
            if (sayilar[j] % 3== 0)
            {
                list3 += " " + sayilar[j];
            }
        }
        print("3'e Bölünenler" + list3);
        for (int j = 0; j <= b - a; j++)
        {
            if (sayilar[j] % 4== 0)
            {
                list4 += " " + sayilar[j];
            }
        }
        print("4'e Bölünenler" + list4);
        for (int j = 0; j <= b - a; j++)
        {
            if (sayilar[j] % 5== 0)
            {
                list5 += " " + sayilar[j];
            }
        }
        print("5'e Bölünenler" + list5);



    }
    void Start()
    {
        bolenleribul(1,1000);
    }



}
