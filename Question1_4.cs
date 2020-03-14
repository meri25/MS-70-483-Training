using System;
using System.Collections.Generic;
using System.Text;

namespace MS_70_483
{
    class Question1_4
    {
    }

    public class Lease
    {
        // Option.A
        public event MaximunTermReacheGandler OnMaximunTermReached;

        // Option.D
        // public string MaximumTermReachedEvent { get; set; }

        // Option.E
        // private string MaximumTermReachedEvent;

        private int _term;
        private const int MaximumTerm = 5;
        private const decimal Rate = 0.043m;
        public int Term
        {
            get
            {
                return _term;
            }
            set
            {
                if (value <= MaximumTerm)
                {
                    _term = value;
                }
                else
                {
                    // Option.B
                    /*              
                                        if (OnMaximunTermReached != null)
                                        {
                                            OnMaximumTermReached(this, new EventArgs());
                                        }
                    */

                    // Option.C
                    // value = MaximumTerm;

                    // option.F
                    // value = 5;
                }
            }
        }
        public delegate void MaximunTermReacheGandler(object source, EventArgs e);
    }

    /*
    SampleEventArgs クラスと Publisher クラスの例：
    基になるデリゲート型として eventHander を使用するイベントを宣言 & 発生させている。
    イベントは、宣言元（Publisher クラス）のクラスまたは構造体内でした呼び出せない特殊なマルチキャストデリゲート。
    他のクラスまたは構造体がイベントを受信登録した場合、Publisher クラスがイベントを発生させると、
    他のクラスまたは構造体のイベントハンドラーメソッドが呼び出される。
    */
    public class SampleEventArgs
    {
        public SampleEventArgs(string s) { Text = s; }
        public String Text { get; }
    }

    public class Publisher
    {
        // デリゲートを宣言する。（非汎用パターンを使用している場合）
        public delegate void SampleEventHandler(object sender, SampleEventArgs e);

        // イベントをデリゲートする
        public event SampleEventHandler SampleEvent;

        // protected virtual method でイベントをラップすることで、派生クラスがイベントを発生できるようにする
        protected virtual void RaiseSampleEvent()
        {
            // スレッドセーフな方法でイベントを発生させる
            SampleEvent?.Invoke(this, new SampleEventArgs("Hello"));
        }
    }
}
