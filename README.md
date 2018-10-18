# The ultimatiegame
[![Build Status](https://bkucheriavyi.visualstudio.com/Ultimate%20Game/_apis/build/status/bkucheriavyi.ultimategame)](https://bkucheriavyi.visualstudio.com/Ultimate%20Game/_build/latest?definitionId=5)

## Prerequisites
Packed version of application requires only .NET Core 2.1 runtime installed and latest .NET Core CLI tools.

Aplication files it's ```core.dll``` and ```tests.dll```.

### To list available tests command:
```
dotnet vstest tests.dll -lt
```
##### Output :
```
The following Tests are available:
    TestPlay_ShouldReturnCorrectResut("MRMLMRM","22E")
    TestPlay_ShouldReturnCorrectResut("RMMMLMM","32N")
    TestPlay_ShouldReturnCorrectResut("MMMM","04N")
    TestPlay_ShouldReturnCorrectResut("RLLRMRRMMRM","00S")
    TestMove_ExistingPicedMovedAndReturned
    TestMove_MoveOutTheBoard_LatestValidPositionReturned
    Test_Map_Throws("RRRRRRRR")
    Test_Map_Throws("RLRLRLR")
    Test_Map_Throws("LLLLLLLL")
    TestMap_CorrectInput_MappingIntoCoordinates("NMEMNMEM","(0;1),(1;0),(0;1),(1;0)")
    TestMap_CorrectInput_MappingIntoCoordinates("EMEMEMNMNM","(1;0),(1;0),(1;0),(0;1),(0;1)")
    TestMap_CorrectInput_MappingIntoCoordinates("NMNMNMNM","(0;1),(0;1),(0;1),(0;1)")
    TestMap_CorrectInput_MappingIntoCoordinates("NMSMSMWM","(0;1),(0;-1),(0;-1),(-1;0)")
    TestReduce_ReducesCommandsToAbsoluteNorthDirection("MRMLMRM","NMEMNMEM")
    TestReduce_ReducesCommandsToAbsoluteNorthDirection("RMMMLMM","EMEMEMNMNM")
    TestReduce_ReducesCommandsToAbsoluteNorthDirection("MMMM","NMNMNMNM")
    TestReduce_ReducesCommandsToAbsoluteNorthDirection("RLLRMRRMMRM","NMSMSMWM")
```
### To run test:
```
dotnet vstest tests.dll
```
##### Output :
```
Starting test execution, please wait...
Skipped  Test_Map_Throws("RRRRRRRR")
Skipped  Test_Map_Throws("RLRLRLR")
Skipped  Test_Map_Throws("LLLLLLLL")

Total tests: 17. Passed: 14. Failed: 0. Skipped: 3.
Test Run Successful.
Test execution time: 1.5251 Seconds
```
