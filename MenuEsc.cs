using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Работа з інтерфейсами
using UnityEngine.SceneManagement; //Работа зі сценами
using UnityEngine.Audio; //Робота з аудіо

public class MenuEsc : MonoBehaviour
{
	public bool isOpened = false; //Відкрито чи меню
	public float volume = 0; //Гучність
	public int quality = 0; //Якіс
	public bool isFullscreen = false; //Повно екранний режим
	public AudioMixer audioMixer; //регулятор гучності
	public Dropdown resolutionDropdown; //Список з роширенями доступних для гри
	private Resolution[] resolutions; //Список доступних розширень
	private int currResolutionIndex = 0; //Зарашнє розширення
	public void ShowHideMenu()
	{
		isOpened = !isOpened;
		GetComponent<Canvas>().enabled = isOpened; //
	}
	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{	
			ShowHideMenu();
			 
		}
	}
	public void ChangeVolume(float val) //Зміна звука
	{
		volume = val;
	}

	public void ChangeResolution(int index) //Зміна розширення
	{
		currResolutionIndex = index;
	}

	public void ChangeFullscreenMode(bool val) //Включення чи виключення повноекранного режиму
	{
		isFullscreen = val;
	}

	public void ChangeQuality(int index) //Зміна якосі
	{
		quality = index;
	}
}

