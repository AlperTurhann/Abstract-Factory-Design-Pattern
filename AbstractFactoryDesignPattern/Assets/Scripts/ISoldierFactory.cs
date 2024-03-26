using UnityEngine;

public interface ISoldierFactory
{
	public enum SoldierType { Melee, Ranged }

	ISoldier CreateSoldier(Transform parent);
}
