using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadProblem : MonoBehaviour
{
    public Button prob1,prob2,prob3,prob4,prob5,prob6,prob7,prob8,prob9;

    private void Start() {
        prob1.onClick.AddListener(() => {SceneManager.LoadScene(1);});
        prob2.onClick.AddListener(() => {SceneManager.LoadScene(2);});
        prob3.onClick.AddListener(() => {SceneManager.LoadScene(3);});
        prob4.onClick.AddListener(() => {SceneManager.LoadScene(4);});
        prob5.onClick.AddListener(() => {SceneManager.LoadScene(5);});
        prob6.onClick.AddListener(() => {SceneManager.LoadScene(6);});
        prob7.onClick.AddListener(() => {SceneManager.LoadScene(7);});
        prob8.onClick.AddListener(() => {SceneManager.LoadScene(8);});
        prob9.onClick.AddListener(() => {SceneManager.LoadScene(9);});
    }
}
