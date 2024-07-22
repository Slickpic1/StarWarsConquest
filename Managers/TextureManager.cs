using System.Collections.Generic;

namespace StarWarsConquest;
public static class TextureManager
{
    //place all our texture locations here in the dictionary
    private static Dictionary<string,string> textureDict;

    public static Texture2D GetTexture(string name, ContentManager contentManager)
    {
        var textureLocation = textureDict[name];
        return contentManager.Load<Texture2D>(textureLocation);
    }
}