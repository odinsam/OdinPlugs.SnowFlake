
using OdinPlugs.OdinInject.InjectInterface;

namespace OdinPlugs.SnowFlake.SnowFlakeInterface
{
    public interface IOdinSnowFlake : IAutoInjectWithParams
    {
        long CreateSnowFlakeId();
        string AnalyzeId(long Id);
    }
}