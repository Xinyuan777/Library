using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static onlinestore.Models.BorrowModel;

namespace onlinestore.Controllers
{
    public class BorrowController : Controller
    {
        // GET: Borrow
        public ActionResult DoBorrow(DoBorrow inModel)
        {
            SqlConnection conn = null;
            // 資料庫連線
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            conn = new SqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();

            String sql = @"INSERT INTO Book (Name,Member,Time01,Time02,Status) VALUES (@Name,@Member,@Time01,@Time02,@Status)";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            // 使用參數化填值
            cmd.Parameters.AddWithValue("@Name", inModel.Name); // 雜湊運算後密碼
            cmd.Parameters.AddWithValue("@Member", Session["UserID"]);
            cmd.Parameters.AddWithValue("@Time01", new DateTime().ToString());
            cmd.Parameters.AddWithValue("@Time02", "");
            cmd.Parameters.AddWithValue("@Status", "已借閱");

            // 執行資料庫更新動作
            cmd.ExecuteNonQuery();

            return View();
        }

        public ActionResult viewBorrow(DoBorrow inModel)
        {
            DoBorrow outModel = new DoBorrow();
            SqlConnection conn = null;
            // 資料庫連線
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            conn = new SqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();

            String sql = @"SELECT * FROM Book ";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            // 執行資料庫查詢動作
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            DataTable dt = ds.Tables[0];
            
            // 使用參數化填值
            if (dt.Rows.Count > 0)
            {
                // 將資料回傳給前端
                outModel.Name = dt.Rows[0]["Name"].ToString();
            }
            ViewBag.Message = dt;
            ViewBag.test = "coco";
            return View();
        }
    }
}