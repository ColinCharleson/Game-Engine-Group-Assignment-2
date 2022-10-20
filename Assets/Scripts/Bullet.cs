using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
	public float lifeTime;
	private void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);

		if (other.collider.tag == "Player")
		{
			if (PlayerHealthManager.instance.health >= 1)
			{
				PlayerHealthManager.instance.health -= 1;
			}
			else
			{
				Scene scene = SceneManager.GetActiveScene();
				SceneManager.LoadScene(scene.name);
			}

		}
		else if (other.collider.tag == "Enemy")
		{
			Destroy(other.gameObject);
		}
	}

	private void Update()
	{
		lifeTime += Time.deltaTime;

		if (lifeTime > 3)
			Destroy(gameObject);
	}
}
