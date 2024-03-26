using UnityEngine;

public class Melee : MonoBehaviour, ISoldier
{
	GameManager gameManager;
	UIManager uIManager;
	
	void Awake() 
	{
		gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
		
		Create();
	}
	
	public void Attack() 
	{
		uIManager.SetProcessText("Melee Soldier Attacked");
		StartCoroutine(gameManager.Versus());
	}

	public void Create() => uIManager.SetProcessText("Melee Soldier Created");

	public void Dead()
	{
		uIManager.SetProcessText("Melee Soldier & Enemy Dead");
		Destroy(gameObject);
	}
	
	public void Change() => Destroy(gameObject);
}
