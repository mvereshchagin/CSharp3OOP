namespace VectorUtils;

/// <summary>
/// Класс Вектора
/// </summary>
public class Vector3d : IMovable, IDrawable, IDisposable
{
    #region Свойства
    /// <summary>
    /// Проекция вектора на ось X
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// Проекция вектора на ось Y
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// Проекция вектора на ось Z
    /// </summary>
    public int Z { get; set; }

    /// <summary>
    /// Длина вектора
    /// </summary>
    public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);
    #endregion

    #region Конструкторы
    /// <summary>
    /// Конструктор класса Vector
    /// </summary>
    /// <param name="x">Проекция вектора на ось X</param>
    /// <param name="y">Проекция вектора на ось Y</param>
    /// <param name="z">Проекция вектора на ось Z</param>
    public Vector3d(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>
    /// Конструктор класса Vector
    /// </summary>
    /// <param name="startPoint">Начальная точка вектора</param>
    /// <param name="endPoint">Конечная точка вектора</param>
    public Vector3d(Point3d startPoint, Point3d endPoint) : 
        this(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y, endPoint.Z - startPoint.Z)
    { }

    #endregion

    #region static methods
    public static double GetAngle(Vector3d a, Vector3d b) =>
        Math.Acos(a * b / a.Length / b.Length);

    public static double GetAngleInDegrees(Vector3d a, Vector3d b) =>
        GetAngle(a, b) / Math.PI * 180;

    #endregion

    #region operators
    public static Vector3d operator + (Vector3d a, Vector3d b) =>
        new Vector3d(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

    public static Vector3d operator -(Vector3d a, Vector3d b) =>
        new Vector3d(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public int this[int index]
    {
        get
        {
            switch(index)
            {
                case 0:
                    return X;
                case 1:
                    return Y;
                case 2:
                    return Z;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
        set
        {
            switch(index)
            {
                case 0:
                    X = value;
                    break;
                case 1:
                    Y = value;
                    break;
                case 2:
                    Z = value;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }

    public int this[string name]
    {
        get
        {
            if (name is not null)
                name = name.ToUpper();
            switch (name)
            {
                case "X":
                    return X;
                case "Y":
                    return Y;
                case "Z":
                    return Z;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }

    public static Vector3d operator *(int number, Vector3d v) =>
        new Vector3d(v.X * number, v.Y * number, v.Z * number);

    public static Vector3d operator *(Vector3d v, int number) =>
        number * v;

    public static int operator *(Vector3d a, Vector3d b) =>
        a.X * b.X + a.Y * b.Y + a.Z * b.Z;

    public static bool operator == (Vector3d a, Vector3d b) =>
        a.X == b.X && a.Y == b.Y && a.Z == b.Z;

    public static bool operator !=(Vector3d a, Vector3d b) =>
       !(a == b);

    public static bool operator >(Vector3d a, Vector3d b) =>
        a.Length > b.Length;

    public static bool operator <(Vector3d a, Vector3d b) =>
        !(a > b);

    public static bool operator >=(Vector3d a, Vector3d b) =>
        a.Length >= b.Length;

    public static bool operator <=(Vector3d a, Vector3d b) =>
        !(a >= b);

    public static explicit operator Vector3d(Point3d p) =>
        new Vector3d(p.X, p.Y, p.Z);

    public static implicit operator Point3d(Vector3d v) =>
        new Point3d(v.X, v.Y, v.Z);
    #endregion

    #region overriden
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (ReferenceEquals(obj, null))
        {
            return false;
        }

        return this == obj;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    #endregion

    public void Move(Point3d p)
    {
        
    }

    public void Draw()
    {

    }

    private bool disposed = false;

    // реализация интерфейса IDisposable.
    public void Dispose()
    {
        // освобождаем неуправляемые ресурсы
        Dispose(true);
        // подавляем финализацию
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;
        if (disposing)
        {
            // Освобождаем управляемые ресурсы
        }
        // освобождаем неуправляемые объекты
        disposed = true;
    }

    // Деструктор
    ~Vector3d()
    {
        Dispose(false);
    }
}
