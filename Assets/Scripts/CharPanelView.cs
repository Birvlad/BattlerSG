using System;
using UnityEngine;
using UnityEngine.UI;

public class CharPanelView : MonoBehaviour
{
	public int currentMana = 0;
	public int maxMana = 10;
	public WeaponView weaponView;
	public SkillView skill1View;
	public SkillView skill2View;
	public Image manaProgressbarImage;

	void Start()
	{

		if (weaponView == null) Debug.LogError("CharPanelView (" + gameObject.name + "):weaponView == null");
		if (skill1View == null) Debug.LogError("CharPanelView (" + gameObject.name + "):skill1View == null");
		if (skill2View == null) Debug.LogError("CharPanelView (" + gameObject.name + "):skill2View == null");
		if (manaProgressbarImage == null) Debug.LogError("CharPanelView (" + gameObject.name + "):manaProgressbarImage == null");
	}

	void Update()
	{
		currentMana = Math.Max(Math.Min(currentMana, maxMana), 0);
		weaponView.currentMana = currentMana;
		skill1View.currentMana = currentMana;
		skill2View.currentMana = currentMana;
		manaProgressbarImage.fillAmount = Mathf.Max(Mathf.Min(currentMana * 1f / maxMana * 1f, 1f), 0); 
	}
	public void IncreaseMana()
	{
		currentMana += 1;
	}
	public void DecreaseMana()
	{
		currentMana -= 1;
	}
}
