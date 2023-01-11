namespace VectorUtils;

/// <summary>
/// Класс точки
/// </summary>
public class Point3d : IDrawable
{
    /// <summary>
    /// Координата X
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// Координата Y
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// Координата Z
    /// </summary>
    public int Z { get; set; }

    /// <summary>
    /// Конструктор класса Point
    /// </summary>
    /// <param name="x">Координата X</param>
    /// <param name="y">Координата Y</param>
    /// <param name="z">Координата Z</param>
    public Point3d(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Draw()
    {

    }
}
