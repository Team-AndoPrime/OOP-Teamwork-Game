namespace BadSanta.Interfaces
{
    public interface IMoveable
    {
        bool IsMovingLeft { get; }
        bool IsMovingRight { get; }
        bool IsMovingUp { get; }
        bool IsMovingDown { get; }

        char LastDirection { get; }

        void Move();
    }
}