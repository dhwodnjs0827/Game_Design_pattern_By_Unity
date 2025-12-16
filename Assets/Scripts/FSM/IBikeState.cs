/// <summary>
/// 구체적인 상태 클래스가 구현할 기본 인터페이스
/// </summary>
public interface IBikeState
{
    void Handle(BikeController controller);
}