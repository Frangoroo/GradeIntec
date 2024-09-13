using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Bloco_Item : MonoBehaviour
{
    [SerializeField] TMP_Text materia_txt;
    [SerializeField] TMP_Text horario_txt;

    void SetarMateria(string _mat, string _horario) 
    {
        materia_txt.text = _mat;
        horario_txt.text = _horario;
    }


}
