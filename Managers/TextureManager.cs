using System.Collections.Generic;

namespace StarWarsConquest;
public static class TextureManager
{
    //place all our texture locations here in the dictionary
    private static Dictionary<string,string> textureDict = new()
    {
        {"GE_RC_Corvette","GalacticEmpireRaiderClassCorvette"},
        {"GE_VC_Heavy_Cruiser","Galactic_Empire_-_Vindicator-Class_Heavy_Cruiser"},
        {"goblin","gublin"}
    };

    public static Texture2D GetTexture(string name, ContentManager contentManager)
    {
        var textureLocation = textureDict[name];
        return contentManager.Load<Texture2D>(textureLocation);
    }
}