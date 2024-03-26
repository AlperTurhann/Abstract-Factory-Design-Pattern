using UnityEngine;

public class RangedSoldierFactory : MonoBehaviour, ISoldierFactory
{
	[Header("References")]
	[SerializeField] GameObject rangedSoldier;
	
	public ISoldier CreateSoldier(Transform parent)
	{
		GameObject soldier = Instantiate(rangedSoldier);
		soldier.transform.SetParent(parent, false);
		return soldier.GetComponent<ISoldier>();
	}
}
