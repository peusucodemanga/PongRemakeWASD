using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool pausado = false;
    public GameObject menu;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausado) Continuar();
            else Pause();
        }   
    }

    public void Continuar()
    {
        Debug.Log("Continuando jogo...");
        menu.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
    }

    void Pause()
    {
        Debug.Log("Pausando jogo...");
        menu.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
    }

    public void Reiniciar()
    {
        Debug.Log("Reiniciando Partida...");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void MenuInicial()
    {
        Debug.Log("Voltando ao menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Tela Inicial");
    }

    public void Sair()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
