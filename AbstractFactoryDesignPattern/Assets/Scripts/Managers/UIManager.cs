using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	[Header("References")]
	[SerializeField] Button createBtn;
	[SerializeField] Button attackBtn;
	[SerializeField] TextMeshProUGUI processTxt;
	[SerializeField] GameManager gameManager;
	
	public void CreateSoldier() 
	{
		gameManager.CreateNewSoldier();
		SetAttackBtn(true);
	}
	
	public void AttackSoldier() 
	{
		gameManager.GetCurrentSoldier().Attack();
		SetCreateBtn(false);
		SetAttackBtn(false);
	}
	
	public void SetCreateBtn(bool isActive) => createBtn.interactable = isActive;
	public void SetAttackBtn(bool isActive) => attackBtn.interactable = isActive;
	public void SetProcessText(string text) => processTxt.text = text;
}
