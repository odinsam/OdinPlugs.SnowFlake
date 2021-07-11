
using OdinPlugs.OdinInject.InjectInterface;

namespace OdinPlugs.SnowFlake.SnowFlakePlugs.ISnowFlake
{
    public interface IOdinSnowFlake : IAutoInjectWithParams
    {
        long CreateSnowFlakeId();
        string AnalyzeId(long Id);
    }
}