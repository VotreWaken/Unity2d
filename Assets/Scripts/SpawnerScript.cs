using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
	[SerializeField]
	private GameObject pipePrefab;
	[SerializeField]
	private GameObject treePrefabs;
	[SerializeField]
	private GameObject[] cloudPrefabs;
	private float pipeSpawnPeriod = 4.0f;
	private float pipetimeout;
	private float envSpawnPeriod = 3.5f;
	private float envtimeout;

	void Start()
	{
		pipetimeout = pipeSpawnPeriod;
		envtimeout = envSpawnPeriod;
	}

	void Update()
	{
		pipetimeout -= Time.deltaTime;
		if (pipetimeout <= 0.0f)
		{
			SpawnPipes();
			pipetimeout = pipeSpawnPeriod;
		}

		envtimeout -= Time.deltaTime;
		if (envtimeout <= 0.0f)
		{
			SpawnTrees();
			envtimeout = envSpawnPeriod;
		}
	}

	private void SpawnPipes()
	{
		GameObject pipe = GameObject.Instantiate(pipePrefab);
		pipe.transform.position = this.transform.position + Random.Range(-2f, 2f) * Vector3.up;
	}

	private void SpawnTrees()
	{
		GameObject tree = GameObject.Instantiate(treePrefabs);
	}
}
