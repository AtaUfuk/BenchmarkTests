<b>Bu proje .Net içerisinde kullanılan kodların performans testleri için oluşturulmuştur.</b>
<h1>1. LinqSelectVsFor</h1>
<p>Bu proje 4 tane metodun performans testini barındırmaktadır.</p>
<p>Bu metodlar içerisinde linq Select, for ve foreach ile bir modelin başka bir modele aktarımı sonucunda birbirleri arasında performans farklarının ölçümünü listeler.</p>
<b>Çıktı Resmi:</b>
<img src="/LinqSelectVsFor/ResultImage/LinqSelectVsForResult.png" />

<h1>2. LinqAnyvsAll</h1>
<p>Bu proje 2 tane metodun performans testini barındırmaktadır.</p>
<p>Bu metodlar içerisinde linq any/all metodlarının birbirleri arasında performans farklarının ölçümünü listeler.</p>
<b>Çıktısı da;</b>

  ```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3037)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

```
| Method  | Mean             | Error          | StdDev         | Gen0   | Allocated |
|-------- |-----------------:|---------------:|---------------:|-------:|----------:|
| LinqAny |         29.27 ns |       0.450 ns |       0.421 ns | 0.0085 |      40 B |
| LinqAll | 46,775,485.06 ns | 699,003.081 ns | 619,648.025 ns |      - |      76 B |
