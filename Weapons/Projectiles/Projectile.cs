
using System;

namespace StarWarsConquest;

public class Projectile : Sprite
{
    public Vector2 velocity;
    private float speed;
    private Vector2 startPoint;
    private Vector2 endPoint;

    public Projectile(Vector2 velocity, Vector2 startPoint, Vector2 endPoint, float speed, Texture2D texture, float SCALE) : base(texture, SCALE)
    {
        this.velocity = velocity;
        this.startPoint = startPoint;
        this.endPoint = endPoint;
        this.speed = speed;

        CalculateVelocity();
    }

    public void CalculateVelocity()
    {
        double theta = Math.Atan2((endPoint.Y-startPoint.Y),(endPoint.X-startPoint.X));
        rotation = (float)theta; //might not be the proper way to implement this, but it (should) work
        velocity.X = (float)(speed*Math.Cos(theta));
        velocity.Y = (float)(speed*Math.Sin(theta));
    }

    
}