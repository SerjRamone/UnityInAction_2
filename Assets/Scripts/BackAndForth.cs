using System.Collections;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed = 3.0f;
    public float maxZ = 16.0f; //объект движется между этими точками
    public float minZ = -16.0f;

    //направление, в котором объект движется в данный момент
    private int _direction = 1;

	// Update is called once per frame
	void Update()
    {
        transform.Translate(0, 0, _direction * speed * Time.deltaTime);

        bool bounced = false;
        if (transform.position.z > maxZ || transform.position.z < minZ)
        {
            _direction = -_direction; //меняем направление на противоположное
            bounced = true;
        }
        if (bounced) //делаем дополнительное движение в этом кадре, если объект поменял направление
        {
            transform.Translate(0, 0, _direction * speed * Time.deltaTime);
        }

	}
}
