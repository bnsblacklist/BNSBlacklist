using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNSBlacklistRecordGenerator
{
    public class ResultWrapper<T>
    {
        private T result;
        public ResultWrapper() { }
        public ResultWrapper(T init)
        {
            result = init;
        }
        public T getResult()
        {
            return result;
        }

        public void setResult(T result)
        {
            this.result = result;
        }
    }
}
