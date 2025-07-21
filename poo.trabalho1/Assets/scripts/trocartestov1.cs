using UnityEngine;
using TMPro;
public class TrocarTextoV1 : MonoBehaviour
{
    public string texto;
    public TextMeshProUGUI textoUI;

    public void TrocarTestoUI()
    {
        textoUI.text = texto;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
