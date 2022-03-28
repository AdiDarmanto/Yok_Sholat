using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiTombol : MonoBehaviour
{
    public void _Animasi()
        {
        GetComponent<Animation>().Play("New Animation");
        KumpulanSuara.instance.Panggil_Suara(0);
        }
        
}
