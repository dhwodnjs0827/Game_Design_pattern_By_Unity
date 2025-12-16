public class BikeStateContext
{
    public IBikeState CurrentState
    {
        get; set;
    }
    
    private readonly BikeController bikeController;

    public BikeStateContext(BikeController bikeController)
    {
        this.bikeController = bikeController;
    }

    /// <summary>
    /// 연결된 상태를 순환하는 용도의 메서드(반드시 필요한 방식은 아님)
    /// </summary>
    public void Transition()
    {
        CurrentState.Handle(bikeController);
    }

    public void Transition(IBikeState state)
    {
        CurrentState = state;
        CurrentState.Handle(bikeController);
    }
}