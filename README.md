# OdinPlugs.SnowFlake

[![Nuget](https://img.shields.io/nuget/v/OdinPlugs.SnowFlake)](https://www.nuget.org/packages/OdinPlugs.SnowFlake/) ![Nuget](https://img.shields.io/nuget/dt/OdinPlugs.SnowFlake) ![](https://img.shields.io/badge/version-1.0.5-brightgreen.svg) [![Build Status](https://travis-ci.com/odinsam/OdinPlugs.SnowFlake.svg?branch=master)](https://travis-ci.com/odinsam/OdinPlugs.SnowFlake) ![](https://img.shields.io/github/issues/odinsam/OdinPlugs.SnowFlake) ![](https://img.shields.io/github/forks/odinsam/OdinPlugs.SnowFlake) ![](https://img.shields.io/github/stars/odinsam/OdinPlugs.SnowFlake) ![](https://img.shields.io/badge/platform-.Net_Core_5.0-brightgreen.svg) ![](https://img.shields.io/github/license/odinsam/OdinPlugs.SnowFlake) [![](https://img.shields.io/badge/Blog-odinsam.com-blue.svg)](https://odinsam.com)

**简介:**

> 用于生成和解析雪花 ID

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
