using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using FWC;
using System;

public class Manager : MonoBehaviour
{

    [SerializeField] Bloco_Item bloco_prefab;

    [SerializeField] turma_item turma_btn_prefab;

    [SerializeField] int dia;
    [SerializeField] string turma;

    public Turno turno;

    [SerializeField] Transform turmas_holder;

    public static Manager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public string lastMenu;

    public List<turma_item> turma_items = new List<turma_item>();

    public void ChangeDia(int _d) 
    {
        dia = _d;

        MenuManager.Instance.OpenMenu("turno");
    }

    public void ChangeTurno(int _turno)
    {
        char _turnoChar= ' ';

        switch (_turno)
        {
            case 0:
                _turnoChar = 'M';
                turno = Turno.Manha;

                break;

            case 1:
                _turnoChar = 'T';
                turno = Turno.Tarde;

                break;
        }

        foreach (turma_item t_i in turma_items) 
        {
            Destroy(t_i.gameObject);
        }

        turma_items.Clear();

        for (int i = 0; i < 6; i++)
        {
            turma_item _turmaItem = Instantiate(turma_btn_prefab, turmas_holder);

            _turmaItem.Init($"{dia+1}0{i+1}{_turnoChar}");

            turma_items.Add(_turmaItem);
        }


        MenuManager.Instance.OpenMenu("turma");
    }

    public void ChangeTurma(string _turma) 
    {
        turma = _turma;

        DateTime originalDate = new DateTime(2024, 9, 16);

        DateTime currentDate = new Date
    }

    public void GoToLastMenu()
    {
        MenuManager.Instance.OpenMenu(lastMenu);
    }
}

public enum Turno { Manha, Tarde }
