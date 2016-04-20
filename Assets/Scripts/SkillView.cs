using UnityEngine;
using UnityEngine.UI;

public class SkillView : MonoBehaviour
{
	public int currentMana = 1;
	public int skillMana = 5;
	public Text skillCostText;
	public Image barImage;
	public Image mainBarImage;
	public Image skillImage;

	void Start()
	{
		if (skillCostText == null) Debug.LogError("SkillView(" + gameObject.name + "):skillCostText == null");
		if (barImage == null) Debug.LogError("SkillView(" + gameObject.name + "):barImage == null");
		if (mainBarImage == null) Debug.LogError("SkillView(" + gameObject.name + "):mainBarImage == null");
		if (skillImage == null) Debug.LogError("SkillView(" + gameObject.name + "):skillImage == null");
		mainBarImage.enabled = true;
	}

	void Update()
	{
		skillCostText.text = ""+ skillMana.ToString();
		if (!CanActivated())
		{
			skillCostText.color = new Color(1f, 0f, 0f, 1f);
			barImage.fillAmount = Mathf.Max(Mathf.Min((currentMana*1f / skillMana*1f), 1f), 0f);
			skillImage.color = new Color(1f,1f,1f,0.3f);
			Outline outline = skillImage.GetComponent<Outline>();
			outline.enabled = false;
			mainBarImage.enabled = true;
		}
		else
		{
			skillCostText.color = new Color(0f, 0f, 0f, 1f);
			skillImage.color = new Color(1f, 1f, 1f, 1f);
			barImage.fillAmount = 0f;
			Outline outline = skillImage.GetComponent<Outline>();
			outline.enabled = true;
			mainBarImage.enabled = false;
		}
	}

	public bool CanActivated()
	{
		if (currentMana >= skillMana) return true;
		return false;
	}
}
