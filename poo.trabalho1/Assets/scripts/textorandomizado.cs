using System;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
public class textorandomizado : MonoBehaviour
{
    public string novotexto;

    public TextMeshProUGUI UITexto;

    public int numero;

    private void Start()
    {
        UITexto.text = novotexto + " " + numero;
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numero > 0 )
        {
            numero--;
            UITexto.text = novotexto + "" + numero;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            numero++;
            UITexto.text = novotexto + "" + numero;
        }
    }

   
    
}
