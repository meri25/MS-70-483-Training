# MS-70-483-Training

お世話になっているサイト
https://www.itshiken.jp/70-483-shiken.html

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

Explanation:
Class2 uses an implicit implementation of INewInstance.  
→明示的に　`INewInterface.Method1()` と定義しているので、この命題は偽。

# Question.8

You have the following class. (Line numbers are included for reference only.)
You need to complete the doOperation method to meet the following requirements:
• If AddNumb is passed as the operationName parameter, the AddNumb function is called.
• If SubNumb is passed as the operationName parameter, the SubNumb function is called.
Which code should you insert at line 16? Develop the solution by selecting and arranging the required code blocks in the correct order. 
You may not need all of the code blocks.


# Question.1-1

You are implementing a method named Calculate that performs conversions between value types and reference types. 
The following code segment implements the
method. (Line numbers are included for reference only.)

You need to ensure that the application does not throw exceptions on invalid conversions.
Which code segment should you insert at line 04?

Answer:
Esplanation:
Option.A

Option.B
System.InvalidCastException: 'Unable to cast object of type 'System.Single' to type 'System.Int32'.'
System.Single（float）のオブジェクトを System.Int32 (int)にキャストできないエラーが発生する。

Option.C 

# Question.1-2
You are creating a console application by using C#.
You need to access the application assembly.
Which code segment should you use?
--
C＃を使用してコンソールアプリケーションを作成しています。
アプリケーションアセンブリにアクセスする必要があります。
どのコードセグメントを使用する必要がありますか？

Option.A

`Assembly.GetAssembly(this);`

Option.B

`this.GetType();`

Option.C

`Assembly.Load();`

Option.D

`Assembly.GetExecutingAssembly();`

Answer:A
Exception:

[Assembly クラス](https://docs.microsoft.com/ja-jp/dotnet/api/system.reflection.assembly?view=netframework-4.8)
Option.A

`Assembly.GetAssembly();`

指定した型が定義されている、現在読み込み済みのアセンブリを取得する。

Option.B

`this.GetType();`

指定された型を表す Type オブジェクトを取得する。

Option.C

`Assembly.Load();`

アセンブリを読み込む。

Option.D

`Assembly.GetExecutingAssembly();`

現在実行中のコードを格納しているアセンブリを取得する。

# Qustion.1-3

You use the Task.Run() method to launch a long-running data processing operation. 
The data processing operation often fails in times of heavy network congestion.
If the data processing operation fails, a second operation must clean up any results of the first operation.
You need to ensure that the second operation is invoked only if the data processing operation throws an unhandled exception.
What should you do?

A. Create a TaskCompletionSource<T> object and call the TrySetException() method of the object.
B. Create a task by calling the Task.ContinueWith() method.
C. Examine the Task.Status property immediately after the call to the Task.Run() method.
D. Create a task inside the existing Task.Run() method by using the AttachedToParent option.

--

Task.Run（）メソッドを使用して、長時間実行されるデータ処理操作を起動します。 
データ処理操作は、ネットワークが重いときに失敗することがよくあります。混雑。
データ処理操作が失敗した場合、2番目の操作で最初の操作の結果をクリーンアップする必要があります。
データ処理操作で未処理の例外がスローされた場合にのみ、2番目の操作が呼び出されるようにする必要があります。
あなたは何をするべきか？

A. TaskCompletionSource <T>オブジェクトを作成し、オブジェクトのTrySetException（）メソッドを呼び出します。
B. Task.ContinueWith（）メソッドを呼び出してタスクを作成します。
C. Task.Run（）メソッドを呼び出した直後にTask.Statusプロパティを調べます。
D. AttachedToParentオプションを使用して、既存のTask.Run（）メソッド内にタスクを作成します。

Answer:B
Explanation:

*Task クラス*
- 値を返さない
- 非同期に実行する操作
- メインアプリケーションスレッドで同期的に実行されるのではなく、スレッドプールの中で非同期的に実行される。
- タスクの確認方は下記プロパティから可能。
  - Status
  - IsCanceled 
  - IsCompleted
  - Isfaulted
- ラムダ式でタスクが実行する処理を指定する

※ Question1_3.cs を参照のこと

Optiopn.A

`TaskCompletionSouce<TResult>.TrySetException()`

[TaskCompletionSource<TResult>.TrySetException メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.taskcompletionsource-1.trysetexception?view=netframework-4.8)

Option.B

`Task.ContinureWith()`

ターゲットの `Task` が完了したときに非同期に実行する継続タスクを作成する

[Task.ContinueWith メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task.continuewith?view=netframework-4.8)

Option.C
上記、Task クラスを参照。

Option.D

[アタッチされた子タスクとデタッチされた子タスク](https://docs.microsoft.com/ja-jp/dotnet/standard/parallel-programming/attached-and-detached-child-tasks)

# Question.1-4