using System.Collections.Generic;

namespace Portal.Domain
{
    public class Board
    {
        public Board()
        {
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.One
            });
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.Two
            });
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.Three
            });
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.Four
            });
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.Five
            });
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.Six
            });
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.Seven
            });
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.Eight
            });
            Positions.Add(new Position
            {
                State = PositionState.None,
                Type = PositionType.Nine
            });
        }
        public IList<Position> Positions { get; set; }
    }
}
