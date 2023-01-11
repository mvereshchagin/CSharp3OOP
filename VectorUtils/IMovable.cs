using System;

namespace VectorUtils;

public interface IMovable
{
    void Move(Point3d p);
}

public interface IDrawable
{
    void Draw();
}