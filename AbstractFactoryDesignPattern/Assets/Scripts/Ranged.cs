using UnityEngine;

public class Ranged : MonoBehaviour, ISoldier
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
		uIManager.SetProcessText("Ranged Soldier Attacked");
		StartCoroutine(gameManager.Versus());
	}

	public void Create() => uIManager.SetProcessText("Ranged Soldier Created");

	public void Dead()
	{
		uIManager.SetProcessText("Ranged Soldier & Enemy Dead");
		Destroy(gameObject);
	}
	
	public void Change() => Destroy(gameObject);
}
