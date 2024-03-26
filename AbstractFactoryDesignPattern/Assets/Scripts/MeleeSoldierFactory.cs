using UnityEngine;

public class MeleeSoldierFactory : MonoBehaviour, ISoldierFactory
{
	[Header("References")]
	[SerializeField] GameObject meleeSoldier;
	
	public ISoldier CreateSoldier(Transform parent)
	{
		GameObject soldier = Instantiate(meleeSoldier);
		soldier.transform.SetParent(parent, false);
		return soldier.GetComponent<ISoldier>();
	}
}
