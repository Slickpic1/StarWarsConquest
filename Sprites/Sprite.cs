namespace StarWarsConquest;

public class Sprite
{
    public Texture2D texture {get;set;}
    public Vector2 position{get;set;}
    public Vector2 origin{
        get{
            return new Vector2(
                (float)(position.X + (0.5)*texture.Width),
                (float)(position.Y + (0.5)*(texture.Height)*SCALE)
            );
        }}
    public float rotation = 0f;
    public SpriteEffects effects = SpriteEffects.None;
    public float layerDepth{get;set;}

    private readonly float SCALE;
    //public Color color; //need to find a way to default to white
    //public Rectangle drect
    //{
    //    get{
    //        return new Rectangle(
    //            (int)position.X,
    //            (int)position.Y,
    //            (int)(texture.Width*SCALE),
    //            (int)(texture.Height*SCALE));
    //    }
    //}
    public Rectangle srect  //might cause problems later, but idc for now
    {
        get{
            return new Rectangle(
                0,
                0,
                texture.Width,
                texture.Height
            );
        }
    }
    public Sprite(float SCALE = 1)
    {
        this.SCALE = SCALE;
    }
    public Sprite(Texture2D texture, float SCALE = 1)
    {
        this.texture = texture;
        this.SCALE = SCALE;
    }
    public Sprite(Texture2D texture, Vector2 position, float SCALE = 1)
    {   
        this.texture = texture;
        this.position = position;
        this.SCALE = SCALE;
    }

    //public Sprite (Texture2D texture, Vector2 position, float rotation)  //ignore for now
    //{
//
    //}

    public virtual void Update()
    {

    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture,position,srect,Color.White,rotation,origin,SCALE,effects,layerDepth);
    }
}