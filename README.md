
# Merge Sort 

**Task:** Sorting in parallel 

**The programming language:** C# 

**The systems and/or frameworks used:**

    .Net
    System.Diagnostics ( Provides classes that allow you
    to interact with system processes, event logs, and
    performance counters )

    Benchmarck ( BenchmarkDotNet helps you to
    transform methods into benchmarks, track their
    performance, and share reproducible measurement
    experiments )

    Parallel LINQ and Task Parallel Library

**Experimental results**

Squential version: 1 Miliseconds

Squential version: 19758 Ticks
##

PLINQ version: 69 Miliseconds

PLINQ version: 696138 Ticks
##

TaskParallel version: 2 Miliseconds

TaskParallel version: 25681 Ticksliseconds

**Info about the machines on which I ran the code:**

    Processor 
    11th Gen Intel(R) Core(TM) i7-11850 2.50GHz

    Ram 
    16.0 GB

    System type 
    64-bit operating system, x64-based processor

    Windows specifications 
    Windows 10 Enterprise

    Graphics
    NVIDIA RTX A2000 8GB