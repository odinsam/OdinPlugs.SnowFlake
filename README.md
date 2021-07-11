# OdinPlugs.SnowFlake

**简介:**

> 用于生成和解析雪花ID

1. 注入:

```chsarp
// 4种 注入方法
services.AddSingleton<IOdinSnowFlake>(provider => new OdinSnowFlake(1, 1));
services.AddSingletonSnowFlake(1,1);
services.AddTransientSnowFlake(1,1);
services.AddScopedSnowFlake(1,1);
```

使用方法:
```csharp
//  创建雪花Id
OdinInjectCore.GetService<IOdinSnowFlake>().CreateSnowFlakeId();
//  解析雪花Id
OdinInjectCore.GetService<IOdinSnowFlake>().AnalyzeId(snowFlakeId);

```