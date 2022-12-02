using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
    public float CD;
    public KeyCode ReleaseKey;
    public Image CDMask;
    public Text SecondsText;
    [Tooltip("if the skill hase not lasting time,the LastingTime should be 0")]
    public float LastingTime;

    private float _sustainedTime;// the time of the skill has sustained
    private float _coldTime;//
    private bool _canRelease = true;
    private bool _isLasting = false;
    protected virtual void effect() { }
    protected virtual void undo() { }

    private void Update()
    {
        if (Input.GetKeyDown(ReleaseKey) && _canRelease)
        {
            effect();
            _coldTime = CD;
            _sustainedTime = LastingTime;
            _canRelease = false;
            _isLasting = true;
            CDMask.fillAmount = 1;
            SecondsText.text = System.Math.Round(CD, 2).ToString();
        }
        if (!_canRelease)// _canRelease is false represents the skill is in the cold time
            CalculateCd();
        if (_isLasting)
            CalculateSustain();

    }

    private void CalculateSustain()
    {
        _sustainedTime -= Time.deltaTime;
        if (_sustainedTime <= 0)
        {
            _isLasting = false;
            undo();
        }
    }
    private void CalculateCd()
    {
        _coldTime -= Time.deltaTime;
        CDMask.fillAmount = _coldTime / CD;
        SecondsText.text = System.Math.Round(_coldTime, 2).ToString();
        if (_coldTime <= 0)
        {
            SecondsText.text = "";
            CDMask.fillAmount = 0;
            _canRelease = true;
        }
    }





}
