using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalShopApp2020
{
    public enum BaseMode
    {
        NONE,           // 기본 상태
        INSERT,         // 입력 상태
        UPDATE,       // 수정 상태
        DELETE,       // 삭제
        SELECT
    }
    public class Commons
    {
        //공통 DB 연결문자열
        public static readonly string CONNSTR = 
            "Data Source=localhost;Port=3306;DataBase=bookrentalshop;Uid=root;Password=mysql_p@ssw0rd";

        
    }
}
