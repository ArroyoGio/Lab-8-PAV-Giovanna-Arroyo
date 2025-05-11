using System;
using UnityEngine;

public class ArmaRotaException : Exception
{
    public ArmaRotaException() : base("El arma est� rota. No puedes atacar.")
    {
    }
}
public class GameManager : MonoBehaviour
{
    //creamos el objeto
    public Player player;
    public Ogro ogro;

    void Start()
    {
        //instanciamos
        player = new Player("jugador", 100, 20, 10);
        ogro = new Ogro("Shrek", 100, 30, 2, true);

        Debug.Log("El juego comenzo, gogogo.");
        Debug.Log("Jugador: " + player.playerName + ", Vida: " + player.life + ", Da�o: " + player.damage);
        Debug.Log("Enemigo: " + ogro.GetNombre() + ", Vida: " + ogro.GetVida() + ", Da�o: " + ogro.GetDa�o());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            try
            {
                if (player.durability <= 0)
                {
                    throw new ArmaRotaException();
                }

                int da�oJugador = UnityEngine.Random.Range(10, 21);
                int da�oOgro = UnityEngine.Random.Range(5, 16);

                // Desgaste aleatorio entre 1 y 3
                int desgaste = UnityEngine.Random.Range(1, 4);

                player.Atacar();
                ogro.Atacar();

                player.RecibirDa�o(da�oOgro);
                ogro.RecibirDa�o(da�oJugador);

                if (player.life <= 0)
                {
                    Debug.Log(player.playerName + " ha muerto. GAME OVER.");
                }

                player.DesgastarArma(desgaste);
            }
            catch (ArmaRotaException error)
            {
                Debug.LogError("ERROR: " + error.Message);
            }
        }
    }
}
