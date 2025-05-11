using UnityEngine;

public interface IDesgastarArma
{
    void DesgastarArma(int cantidad);
}

public class Player : MonoBehaviour, IAtacar, IRecibirDa�o, IDesgastarArma
{
    //atributo de la clase
    #region attributes
    private string _playerName;
    private int _life = 100;
    private int _damage;
    private int _durability;
    #endregion

    //propiedad de lecturas, usando punteros
    #region getters
    public string playerName => _playerName;
    public int life => _life;
    public int damage => _damage;
    public int durability => _durability;
    #endregion


    //constructor de la clase
    #region constructor
    public Player(string PlayerName, int Life, int Damage, int durability)
    {
        _playerName = PlayerName;
        _life = Life;
        _damage = Damage;
        _durability = durability;
    }
    #endregion


    //llamada a las interfaces(metodos) que estan en el script Enemigo
    #region metodos de la interfaz
    public void Atacar()
    {
        if (_durability <= 0)
        {
            Debug.Log(_playerName + " no puede atacar. Su arma est� rota.");
            return;
        }

        Debug.Log(_playerName + " ataca con fuerza");
    }

    public void RecibirDa�o(int da�o)
    {
        _life -= da�o;
        Debug.Log(_playerName + " recibi� " + da�o + " de da�o. Vida actual: " + _life);
    }

    //interfaz creada al inicio
    public void DesgastarArma(int cantidad)
    {
        if (_durability <= 0)
        {
            Debug.Log("El arma est� rota. No se puede atacar.");
            return;
        }

        _durability -= cantidad;
        Debug.Log("El arma perdi� " + cantidad + " de durabilidad. Durabilidad actual: " + _durability);
    }

    #endregion

}
