using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlinestore.Models
{
    public class MemberModel
    {
		/// <summary>
		/// 註冊參數
		/// </summary>
		public class DoRegisterIn
		{
			public string UserID { get; set; }
			public string UserPwd { get; set; }
			public string UserName { get; set; }
			public string UserEmail { get; set; }
		}

		/// <summary>
		/// 註冊回傳
		/// </summary>
		public class DoRegisterOut
		{
			public string ErrMsg { get; set; }
			public string ResultMsg { get; set; }
		}
	}

}