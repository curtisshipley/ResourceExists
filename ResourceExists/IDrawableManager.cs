using System;
namespace ResourceExists
{
    public interface IDrawableManager
    {
        bool DoesImageExist(string path);
    }
}
