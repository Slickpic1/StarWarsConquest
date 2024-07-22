namespace StarWarsConquest;

public class Station : Sprite
{
    private string stationName;
    public Station(Texture2D texture, Vector2 position, int SCALE) : base(texture,position,SCALE)
    {

    }

    public string GetName()
    {
        return stationName;
    }
}