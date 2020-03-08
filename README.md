﻿# MS-70-483-Training

## Question.1

You write the following method (line numbers are included for reference only):

You need to ensure that the method extracts a list of URLs that match the following pattern:
@http://(www\.)?([^\.]+)\.com;
Which code should you insert at code?

※ 該当のコードは、Program.cs/Main の Q1 を参照してください。

Answer:A


# Question.4

You need to get the list of all the types defined in the assembly that is being executed currently.
How should you complete the code? To answer, 
drag the appropriate code elements to the correct targets in the answer area. Each code element may be used once, 
more than once, or not at all. You may need to drag the split bar between panes or scroll to view content.

# Question.5

You are developing an application that includes methods named ConvertAmount and TransferFunds. 
You need to ensure that the precision and range of the value in the amount variable is not lost when the TransferFunds() method is called.
Which code segment should you use?

※ 選択肢は、Question5.cs を参照してください。

Answer:A
Explanation:
doubleキーワードは、64ビット浮動小数点値を格納する単純型を示します。
floatキーワードは、32ビット浮動小数点値を格納する単純型を示します。
参照：double（C＃リファレンス）

# Question.6

You have the following code (line numbers are included for reference only):
You need to ensure that new instances of Connection can be created only by other classes by calling the Create method. 
The solution must allow classes to inherit from Connection.
What should you do?

Answer:
Exlanation:
静的クラスの役割
- 静的メンバーのみが含まれる
- インスタンス化できない
- シールされている
- インスタンス コンストラクターを含めることができない

Option.1
抽象クラスは直接インスタンス化することはできない。
[参照](https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/#inheritance)

Option.2
静的クラスを new キーワードでインスタンス化することはできない。
[参照](https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/#static-types)

Option.3
なぜ不正解なのかわからない。

Option.4
なぜ正解なのかわからない
