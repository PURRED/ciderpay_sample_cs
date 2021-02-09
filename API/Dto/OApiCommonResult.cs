using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciderpaysample.API.Dto
{
    public class OApiCommonResult
    {
        /**
		 * 성공 여부
		 */
        public bool success;

        /**
		 * 에러 타입
		 */
        public string errorType;

        /**
		 * 메시지
		 */
        public string message;

        /**
		 * 추가 변수 1
		 */
        public string var1;

        /**
		 * 추가 변수 2
		 */
        public string var2;
    }
}
