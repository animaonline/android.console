using System;
using System.Text;

namespace Animaonline.Android.Console.Code
{
    public class ConsoleBuffer
    {
        public ConsoleBuffer(int maxLines = 200)
        {
            _buffer = new StringBuilder();
            _maxLines = maxLines;
        }

        private StringBuilder _buffer;
        private readonly int _maxLines;
        private int _lineCount = 0;
        private readonly object sync_lock = new object();

        public string Buffer
        {
            get
            {
                _maintainConstraints();
                return this._buffer.ToString();
            }
        }

        public void Clear()
        {
            lock (sync_lock)
            {
                _buffer.Clear();
                _lineCount = 0;
            }
        }

        public void Write(string value)
        {
            lock (sync_lock)
            {
                _maintainConstraints();

                _buffer.Append(value);

                _lineCount += value.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
            }
        }

        public void WriteLine(string line)
        {
            lock (sync_lock)
            {
                _maintainConstraints();

                _buffer.AppendFormat("{0}{1}", line, Environment.NewLine);

                _lineCount++;
            }
        }

        public void WriteLine()
        {
            lock (sync_lock)
            {
                _maintainConstraints();

                _buffer.AppendLine();

                _lineCount++;
            }
        }

        private void _maintainConstraints()
        {
            lock (sync_lock)
            {
                if (_lineCount > _maxLines)
                {
                    _buffer = _buffer.Remove(0, _buffer.Length / 2);
                    _lineCount = _lineCount / 2; 
                }
            }
        }
    }
}
