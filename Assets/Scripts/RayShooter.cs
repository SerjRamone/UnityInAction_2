using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera _camera;

    void Start()
    {
        //доступ к другим компонентам, присоединённым к этому же объекту
        _camera = GetComponent<Camera>();

        //скрываем указатель мыши в центре экрана
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {

    }

    private void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        //отображает на экране символ
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }
}
