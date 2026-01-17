using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.FileOperation
{
    internal class Using: IDisposable
    {
        bool disposed = false;
        public void Dispose()
        {
            Dispose(true);//手動破棄
            GC.SuppressFinalize(this);//GCに既に破棄しました、ファイナライザーの呼び出しは不要とのことです
        }
        protected virtual void Dispose(bool disposing)//手動破棄方法(内容は自分でカスタム)
        {
            if (disposed) return;
            if (disposing)
            {   //マネージリソースの解放
                disposed = true;
            }
        }
        ~Using()//破棄方法書き忘れた時のこちらで回収
        {
            Dispose(false);
        }
    }
}
