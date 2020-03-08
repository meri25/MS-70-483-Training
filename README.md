# MS-70-483-Training

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

Answer:D
Exlanation:
※ [Issue#4](https://github.com/meri25/MS-70-483-Training/issues/4)を参照。
設問の条件は、下記2点。
1. Createメソッドを呼び出して、Connectionの新しいインスタンスを他のクラスでのみ作成できるようにする必要があります。
2. ソリューションでは、クラスがConnectionから継承できるようにする必要があります。

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
設問の条件2を満たしていない。
親クラスのコンストラクターが `private` なため、子クラスから親クラスのコンストラクターが呼べない。
そもそもコンパイルエラーになる。

Option.4
設問の条件を満たす。
親クラスのコンストラクターが `protected` なため、子クラスから親クラスのコンストラクターを参照可能。
１つ目の要件として Create メソッドを経由して Connection クラスのインスタンスを生成したいとある。
Connection クラスのコンストラクターの修飾子を public にすると、Create メソッドじゃなくても new することで Connection クラスのインスタンスが生成可能になってしまう。
その為、外部から new されたくない、でも子クラスからは参照できるようにしたい、という要件を満たすために protected にする必要がある。


# Question.7

A developer designs an interface that contains the following code:

※ 対象のコードは、Question7 を参照してください。

A developer designs an interface that contains the following code:

原文
| Statement                                                                       | Yes | No |
|---------------------------------------------------------------------------------|-----|----|
| If you call Method1 from an instance of Class 2, an exception will be thrown.   |     |    |
| If you cast an instance of Class1 in INewInstance, an exception will be thrown. |     |    |
| Class2 uses an implicit implementation of INewInstance.                         |     |    |

日本語約訳
| ステートメント| はい     | いいえ |
| ---------------------------------------------------------------------------------------------- | -------- | ------ |
| クラス 2 のインスタンスから Method1 を呼び出すと、例外がスローされます。　　　　　　　　　　　 | 　　　　 | 　　　 |
| INewInstance で Class1 のインスタンスをキャストすると、例外がスローされます。 　　　　　　　   | 　　　　 | 　　　 |
| Class2 は、INewInstance の暗黙的な実装を使用します。 　　　　　　　　　　　　　　　　　　　    | 　　　　 | 　　　 |

Answer:
| Statement                                                                       | Yes | No |
|---------------------------------------------------------------------------------|-----|----|
| If you call Method1 from an instance of Class 2, an exception will be thrown.   |  X  |    |
| If you cast an instance of Class1 in INewInstance, an exception will be thrown. |     | X  |
| Class2 uses an implicit implementation of INewInstance.                         |     | X  |


