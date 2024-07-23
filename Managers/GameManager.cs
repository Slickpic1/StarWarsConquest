using System.Collections.Generic;
using System.Data;

//May want to only load needed ships from library?

namespace StarWarsConquest;

public class GameManager
{
    private SceneManager sceneManager;
    private GraphicsDeviceManager graphics;
    
    public GameManager(GraphicsDeviceManager graphics)
    {
        this.graphics = graphics;
        sceneManager = new();
    }
    public void Initialize()
    {

    }

    public void Load(ContentManager contentManager)
    {
        //for the moment, we load an initial list of opposing ships (THIS IS TEMPORARY)
        List<Ship> playerFleet = new()
        {
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_VC_Heavy_Cruiser",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_VC_Heavy_Cruiser",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_VC_Heavy_Cruiser",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_VC_Heavy_Cruiser",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_VC_Heavy_Cruiser",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_VC_Heavy_Cruiser",0.05f)
        };
        List<Ship> enemyFleet = new()
        {
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_RC_Corvette",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_RC_Corvette",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_RC_Corvette",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_RC_Corvette",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_RC_Corvette",0.05f),
            new Ship(1,1,1,new List<Weapon>(),2,"fun","GE_RC_Corvette",0.05f)
        };
        List<Station> stations = new();

        //For now we load a battlescene to just test out if it works
        sceneManager.AddScene(new BattleScene(playerFleet,enemyFleet,stations,contentManager,graphics,sceneManager)); //not sure if we need this since everything is global
        sceneManager.GetCurrentScene().Load();
    }

    public void Update(GameTime gameTime)
    {
        sceneManager.GetCurrentScene().Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        sceneManager.GetCurrentScene().Draw(spriteBatch);
    }
}