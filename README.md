# MS-70-483-Training

お世話になっているサイト
https://www.itshiken.jp/70-483-shiken.html

## Question.1

You write the following method (line numbers are included for reference only):

You need to ensure that the method extracts a list of URLs that match the following pattern:
@http://(www\.)?([^\.]+)\.com;
Which code should you insert at code?

※ 該当のコードは、Program.cs/Main の Q1 を参照してください。

---

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

---

**Answer: A **

**Explanation: **

doubleキーワードは、64ビット浮動小数点値を格納する単純型を示します。
floatキーワードは、32ビット浮動小数点値を格納する単純型を示します。
参照：double（C＃リファレンス）

# Question.6

You have the following code (line numbers are included for reference only):
You need to ensure that new instances of Connection can be created only by other classes by calling the Create method. 
The solution must allow classes to inherit from Connection.
What should you do?

---

**Answer: D**

**Exlanation:**

※ [Issue#4](https://github.com/meri25/MS-70-483-Training/issues/4)を参照。

設問の条件は、下記2点。
1. Createメソッドを呼び出して、Connectionの新しいインスタンスを他のクラスでのみ作成できるようにする必要があります。
2. ソリューションでは、クラスがConnectionから継承できるようにする必要があります。

**静的クラスの役割**
- 静的メンバーのみが含まれる
- インスタンス化できない
- シールされている
- インスタンス コンストラクターを含めることができない

**Option.1**

抽象クラスは直接インスタンス化することはできない。

[参照](https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/#inheritance)

**Option.2**

静的クラスを new キーワードでインスタンス化することはできない。

[参照](https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/#static-types)

**Option.3**

設問の条件2を満たしていない。
親クラスのコンストラクターが `private` なため、子クラスから親クラスのコンストラクターが呼べない。
そもそもコンパイルエラーになる。

**Option.4**

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
|-------------------------------------------------------------------------------------------------------------------------|-------|------|
| If you call Method1 from an instance of Class 2, an exception will be thrown.   |     |    |
| If you cast an instance of Class1 in INewInstance, an exception will be thrown. |     |    |
| Class2 uses an implicit implementation of INewInstance.                         |     |    |

---

| ステートメント| はい     | いいえ |
| --------------------------------------------------------------------------------------------------------------------------------------------- | ------------ | --------- |
| クラス 2 のインスタンスから Method1 を呼び出すと、例外がスローされます。　　　　　　　　　　　 | 　　　　 | 　　　 |
| INewInstance で Class1 のインスタンスをキャストすると、例外がスローされます。 　　　　　　　   | 　　　　 | 　　　 |
| Class2 は、INewInstance の暗黙的な実装を使用します。 　　　　　　　　　　　　　　　　　　　    | 　　　　 | 　　　 |

---

**Answer:**

| Statement                                                                       | Yes | No |
|-------------------------------------------------------------------------------------------------------------------------|-------|------|
| If you call Method1 from an instance of Class 2, an exception will be thrown.   |  X  |    |
| If you cast an instance of Class1 in INewInstance, an exception will be thrown. |     | X  |
| Class2 uses an implicit implementation of INewInstance.                         |     | X  |

**Explanation:**

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

---

**Answer:**
**Explanation:**

**Option.A**

**Option.B**

System.InvalidCastException: 'Unable to cast object of type 'System.Single' to type 'System.Int32'.'
System.Single（float）のオブジェクトを System.Int32 (int)にキャストできないエラーが発生する。

**Option.C** 

# Question.1-2
You are creating a console application by using C#.
You need to access the application assembly.
Which code segment should you use?

---

C＃を使用してコンソールアプリケーションを作成しています。
アプリケーションアセンブリにアクセスする必要があります。
どのコードセグメントを使用する必要がありますか？

**Option.A**

`Assembly.GetAssembly(this);`

**Option.B**

`this.GetType();`

**Option.C**

`Assembly.Load();`

**Option.D**

`Assembly.GetExecutingAssembly();`

---

**Answer: A**
**Exception:**

[Assembly クラス](https://docs.microsoft.com/ja-jp/dotnet/api/system.reflection.assembly?view=netframework-4.8)

**Option.A**

`Assembly.GetAssembly();`

指定した型が定義されている、現在読み込み済みのアセンブリを取得する。

**Option.B**

`this.GetType();`

指定された型を表す Type オブジェクトを取得する。

**Option.C**

`Assembly.Load();`

アセンブリを読み込む。

**Option.D**

`Assembly.GetExecutingAssembly();`

現在実行中のコードを格納しているアセンブリを取得する。

# Qustion.1-3

You use the Task.Run() method to launch a long-running data processing operation. 
The data processing operation often fails in times of heavy network congestion.
If the data processing operation fails, a second operation must clean up any results of the first operation.
You need to ensure that the second operation is invoked only if the data processing operation throws an unhandled exception.
What should you do?

**A.** Create a TaskCompletionSource<T> object and call the TrySetException() method of the object.

**B.** Create a task by calling the Task.ContinueWith() method.

**C.** Examine the Task.Status property immediately after the call to the Task.Run() method.

**D.** Create a task inside the existing Task.Run() method by using the AttachedToParent option.

---

Task.Run（）メソッドを使用して、長時間実行されるデータ処理操作を起動します。 
データ処理操作は、ネットワークが重いときに失敗することがよくあります。混雑。
データ処理操作が失敗した場合、2番目の操作で最初の操作の結果をクリーンアップする必要があります。
データ処理操作で未処理の例外がスローされた場合にのみ、2番目の操作が呼び出されるようにする必要があります。
あなたは何をするべきか？

**A.** TaskCompletionSource <T>オブジェクトを作成し、オブジェクトのTrySetException（）メソッドを呼び出します。

**B.** Task.ContinueWith（）メソッドを呼び出してタスクを作成します。

**C.** Task.Run（）メソッドを呼び出した直後にTask.Statusプロパティを調べます。

**D.** AttachedToParentオプションを使用して、既存のTask.Run（）メソッド内にタスクを作成します。

---

**Answer: B**

**Explanation:**

**Taskクラス**

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

**Optiopn.A**

`TaskCompletionSouce<TResult>.TrySetException()`
[TaskCompletionSource<TResult>.TrySetException メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.taskcompletionsource-1.trysetexception?view=netframework-4.8)

**Option.B**

`Task.ContinureWith()`
ターゲットの `Task` が完了したときに非同期に実行する継続タスクを作成する
[Task.ContinueWith メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task.continuewith?view=netframework-4.8)

**Option.C**

上記、Task クラスを参照。

**Option.D**

[アタッチされた子タスクとデタッチされた子タスク](https://docs.microsoft.com/ja-jp/dotnet/standard/parallel-programming/attached-and-detached-child-tasks)

# Question.1-4

You are modifying an application that processes leases. 
The following code defines the Lease class. 
(Line numbers are included for reference only.)

You need to implement the notification mechanism.
Which two actions should you perform? 
(Each correct answer presents part of the solution. Choose two.)

---

リースを処理するアプリケーションを変更しています。
次のコードは、Leaseクラスを定義しています。
（行番号は参照用にのみ含まれています。）

通知メカニズムを実装する必要があります。
実行すべき2つのアクションはどれですか？ 
（各正解はソリューションの一部を示します。2つ選択してください。）

※ Question1_4.cs を参照すること。

**Answer: A, B**

**Explanation:**

`value`

- コンテクストキーワード `value` は、`set` アクセサーの propaty と indexer の宣言で利用される。
- メソッドの入力パラメータ~のような振る舞いをする。

`event`

- パブリッシャークラス内にイベントを宣言する。

# Question.1-5
You are developing an application that uses structured exception handling.
The application includes a class named ExceptionLogger.
The ExceptionLogger class implements a method named LogException by using the following code segment:

`public static void LogException(Exception ex)`

You have the following requirements:
Log all exceptions by using the LogException() method of the ExceptionLogger class.
Rethrow the original exception, including the entire exception stack.
You need to meet the requirements.
Which code segment should you use?

---

構造化例外処理を使用するアプリケーションを開発しています。 
アプリケーションには、ExceptionLoggerという名前のクラスが含まれています。
ExceptionLoggerクラスは、次のコードセグメントを使用してLogExceptionというメソッドを実装します。

`public static void LogException(Exception ex)`

次の要件があります。
ExceptionLoggerクラスのLogException（）メソッドを使用して、すべての例外を記録します。
例外スタック全体を含む元の例外を再スローします。
要件を満たす必要があります。
どのコードセグメントを使用する必要がありますか？

※ Question1_5.cs を参照すること。

**Answer: A**

**Explanation:**

例外がスローされたときに伝わる情報の一部はスタックトレース。
スタックトレースは、次のメソッドで始まるメソッド呼び出し階層のリスト。
つまり、例外をスローし、例外をキャッチするメソッドで終了する。
`throw` ステートメントで例外を指定して例外を再スローすると、スタックトレースが再開され、
例外を再スローした元のメソッドと現在のメソッドの間のメソッド呼び出し部分の情報が失われる。
以上より、例外を含むスタックトレース情報を保つためには、例外を指定せずに `throw` ステートメントを私用する。

**構造化例外処理（SEH: Structured Exception Handling）**

- ハードウェア障害がど、の特例の例外コードの状況を適切に処理するための、C に対する Microsoft の拡張機能。
- 例外が発生した場合に...[参考](https://www.keicode.com/windows/windows_exception_handling.php)
	- その例外発生スレッドの処理に割り込む。
	- そのスレッドの実行コンテキスト情報を保存する。
	- 例外ハンドラ or 終了ハンドラを実行する...?

**Option.A**

正解。

**Option.B**

`throw` ステートメントに例外を指定しているので不適。

**Option.C**

発生した例外ではなく、新しく例外を生成しているので不適。

**Option.D**

Opction.C と同じ。

# Question.1-6

You are developing an application that includes a class named UserTracker. 
The application includes the following code segment. (Line numbers are included for reference only.)

You need to add a user to the UserTracker instance.
What should you do?
---

UserTrackerという名前のクラスを含むアプリケーションを開発しています。 
アプリケーションには、次のコードセグメントが含まれています。 （行番号は参照のみ。）

UserTrackerインスタンスにユーザーを追加する必要があります。
あなたは何をするべきか？

---

**Answer: D**

**Explanation:**

**Option.A**

- 文法エラー

`現在のコンテキストに...は存在しません。`

**Option.B**

- 文法エラーはない

**Option.C**

- 文法エラーはない

**Option.D**

**Delegate クラス**

- デリゲートとは静的メソッドを参照するデータ構造、またはクラスのインスタンスメソッドを参照するデータ構造

[Delegate クラス](https://docs.microsoft.com/ja-jp/dotnet/api/system.delegate?view=netframework-4.8)

**String クラス**

- テキストを一連の UFT-16 コード単位として表現する

**String と string の違い**

- `string`　は予約語として定義されている識別子であり、`System.String` の別名である。
- コンパイルすれば、`String` も `string` も同じものになる。
- エイリアスを予約語に定義しているものの例
	- `bool`:`System.Boolean`
	- `int`:`System.Int32`
- 使い分けるとき
	- `String`:String クラスのメソッドを呼び出す場合
	- `string`:字列の変数を定義する場合

**入れ子にされた型**

[入れ子にされた型 (C# プログラミング ガイド)](https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/nested-types)

```c#
public class Container
{
	class Nested
	{
		Nested() { }
	}
}
```_

- 外側のクラス、構造体、入れ子にされた方のいずれであっても、入れ子にされた型は規定で `private` になり、それが含まれる型からのみアクセス可能となる。
	- 前の例では、`Nested` クラスは外部の型にアクセスできない。
- 外側の型がクラスの場合、入れ子にされた型は...	`public`、`protected`、`internal`、`protected internal`、`private`、`private protected`になれる
- 外側の型が構造体の場合、入れ子にされた型は...`public`、`internal`、`private`になれる
- 入れ子にされた型は、外側の型にアクセスできる。
	- アクセスするには、その型を引数として入れ子の型のコンストラクターに渡す。

```c#
public class Container
{
	public Class Nested
	{
		private Container parent;
		public Nested()
		{
		}
		public Nested(Container parent)
		{
			this.parent = parent;
		}
	}
}
```

# Question.1-7

You are adding a public method named UpdateScore to a public class named ScoreCard.
The code region that updates the score field must meet the following requirements:
- It must be accessed by only one thread at a time.
- It must not be vulnerable to a deadlock situation.
You need to implement the UpdateScore() method.
What should you do?

**A.** Place the code region inside the following lock statement:

**B.** Add a private object named `lockObject` to the `ScoreCard` class. Place the code region inside the following lock statement:

**C.** Apply the following attributbe to the `UpdateScore()` method signature:

**D.** Add a public static object named `lockObject` to the `Scored` class. Place the code Region inside the following lock statement: 
---

UpdateScoreという名前のパブリックメソッドをScoreCardという名前のパブリッククラスに追加しています。
スコアフィールドを更新するコード領域は、次の要件を満たしている必要があります。
- 一度に1つのスレッドのみがアクセスする必要があります。
- デッドロック状態に対して脆弱であってはなりません。
UpdateScore（）メソッドを実装する必要があります。
あなたは何をするべきか？

**A.** 次のロックステートメント内にコード領域を配置します。

```c#
lock (this)
{
	...
}
```

**B.** `lockObject`という名前のプライベートオブジェクトを` ScoreCard`クラスに追加します。 コード領域を次のロックステートメント内に配置します。

```c#
lock (lockObject)
{
	...
}
```

**C.** 次の属性を `UpdateScore()` メソッドシグネチャに適用します。

```c#
[MethodImp(MethodlOptions.Synchronized)]
```

**D.**  `lockObject`という名前のパブリック静的オブジェクトを` Scored`クラスに追加します。 次のロックステートメント内にコードRegionを配置します。

```c#
lock (typeof(ScoreCard))
{
	...
}
```

---

**Answer:**

**Exception:**

