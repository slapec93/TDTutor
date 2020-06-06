using UnityEngine;

public class BuildManager : MonoBehaviour
{
	public static BuildManager instance;

	public GameObject standardTurretPrefab;
	GameObject turretToBuild;

	void Awake()
	{
		if (instance != null)
		{
			return;
		}
		instance = this;
	}

	public GameObject GetTurretToBuild()
	{
		return turretToBuild;
	}

	public void SetTurretToBuild(GameObject turret)
	{
		turretToBuild = turret;
	}
}
