using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LegendaScript : MonoBehaviour
{
    public Text legendaText;

    void Start()
    {
        // Iniciar a rotina de exibicao de legendas
        StartCoroutine(ExibirLegendas());
    }

    IEnumerator ExibirLegendas()
    {
        yield return new WaitForSeconds(5f);
        AtualizarLegenda("Bom dia");

        yield return new WaitForSeconds(10f);
        AtualizarLegenda("Boa tarde");

        yield return new WaitForSeconds(17f);
        AtualizarLegenda("Boa noite");

        yield return new WaitForSeconds(48f);
        AtualizarLegenda("Como esta?");
    }

    void AtualizarLegenda(string texto)
    {
        legendaText.text = texto;
    }
}


//Crie um objeto de texto (UI Text) em sua cena Unity e atribua-o à variável legendaText no Inspector.
