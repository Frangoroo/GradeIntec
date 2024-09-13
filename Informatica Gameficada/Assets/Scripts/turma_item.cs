using UnityEngine;
using TMPro;

public class turma_item : MonoBehaviour
{
    [SerializeField] TMP_Text turma_txt;

    public void Init(string st)
    {
        turma_txt.text = st;
    }

    public void SelectTurma(string st)
    {
        Manager.Instance.ChangeTurma(st);
    }
}
