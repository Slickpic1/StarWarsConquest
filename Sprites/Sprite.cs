namespace StarWarsConquest;

public class Sprite
{
    public Texture2D texture {get;set;}
    public Vector2 position{get;set;}
    private readonly int SCALE;
    //public Color color; //need to find a way to default to white
    public Rectangle drect
    {
        get{
            return new Rectangle(
                (int)position.X,
                (int)position.Y,
                texture.Width*SCALE,
                texture.Height*SCALE);
        }
    }
    public Sprite(int SCALE = 1)
    {
        this.SCALE = SCALE;
    }
    public Sprite(Texture2D texture, int SCALE = 1)
    {
        this.texture = texture;
        this.SCALE = SCALE;
    }
    public Sprite(Texture2D texture, Vector2 position, int SCALE = 1)
    {   
        this.texture = texture;
        this.position = position;
        this.SCALE = SCALE;
    }

    public virtual void Update()
    {

    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture,drect,Color.White);
    }
}