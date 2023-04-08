using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Dashboard.DAO
{
    public class DataProvider
    {
        private static string ServerName = "(local)"; //Đổi tên lại theo Server Name của SQL 
        private static string DatabaseName = "HEQUANTRICOSODULIEU"; //Tên database
        private string ConnStr = $@"Data Source={ServerName}; Initial Catalog={DatabaseName};Integrated Security=True";
        private static DataProvider instance;

        private DataProvider() { }

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } 
        }
       
        //Hàm thực thi câu lệnh sqlCommand, giá trị trả về là 1 bảng giá trị
        public DataTable ExecuteQuery(string query, object[] paramenter = null) 
        {
            DataTable data = new DataTable(); //Khai báo biến data là 1 bảng dữ liệu
            using (SqlConnection conn = new SqlConnection(ConnStr)) //đảm bảo rằng đối tượng SqlConnection được giải phóng tự động sau khi sử dụng, mà không cần phải gọi phương thức Dispose() của đối tượng
            {
                conn.Open(); //Mở kết nối
                SqlCommand cmd = new SqlCommand(query, conn); //Thực hiện truy vấn
                if(paramenter != null) 
                {
                    string[] listPara = query.Split(' '); 
                    int i = 0; //Gọi biến chạy
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, paramenter[i]);
                            i++;
                        }
                    }
                }
                /* GIẢI THÍCH ĐOẠN CODE PHÍA TRÊN: Đoạn mã trên là một điều kiện IF trong ngôn ngữ lập trình C#. Nó kiểm tra xem giá trị của biến "parameter" có khác NULL hay không. Nếu khác NULL, nó sẽ thực hiện các câu lệnh trong phần thân của IF.
                Phần thân của IF bắt đầu bằng việc tách câu truy vấn "query" thành một danh sách các chuỗi bằng cách sử dụng phương thức Split() và chia nhỏ chuỗi thành các phần tử của một mảng. Việc chia nhỏ được thực hiện bằng cách tách các chuỗi theo khoảng trắng ' '.
                Sau khi có danh sách các chuỗi, vòng lặp foreach được sử dụng để duyệt qua từng phần tử trong danh sách. Nếu phần tử đó chứa ký tự '@', nó được coi là một tham số và thêm giá trị của tham số này vào trong đối tượng SqlCommand cmd bằng cách sử dụng phương thức AddWithValue(). Tham số này được lấy từ mảng "parameter" bằng cách sử dụng biến "i" như một chỉ mục để lấy giá trị tương ứng.
                Đoạn mã này thường được sử dụng để thêm các tham số vào câu truy vấn SQL để tránh các lỗ hổng bảo mật, cũng như đảm bảo tính nhất quán và độ tin cậy của câu truy vấn.*/
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data); //Lấy dữ liệu từ một nguồn dữ liệu và đổ dữ liệu này vào một đối tượng data.
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Có lỗi rồi! \n TÊN LỖI: " + ex.Message + "\n MÃ LỖI:" + ex.ErrorCode, "ERROR!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close(); //Đóng kết nối
            }
            return data; //Trả về giá trị data
        }

        //Hàm trả về giá trị số cột
        public int ExecuteNonQuery(string query, object[] parament = null) 
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parament != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parament[i]);
                            i++;
                        }
                    }
                }
                try
                {
                    data = cmd.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Có lỗi rồi! \n TÊN LỖI: " + ex.Message + "\n MÃ LỖI:" + ex.ErrorCode, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            return data;
        }

        //Thực thi query trả về giá trị đầu tiên của kết quả
        public object ExecuteScalar(string query, object[] parament = null) 
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parament != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parament[i]);
                            i++;
                        }
                    }
                }
                try
                {
                    data = cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Có lỗi rồi! \n TÊN LỖI: " + ex.Message + "\n MÃ LỖI:" + ex.ErrorCode, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            return data;
        }

        //Trả về Datatable để load dữ liệu lên form từ view
        public DataTable LoadData(string nameView, CommandType ct = CommandType.Text)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                string query = "SELECT * FROM " + nameView;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = ct;

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }

            return dt;
        }

        //Tra ve Datatable khi thuc thi ham
        public DataTable ExecuteFunction(SqlCommand cmdFunction, ref string error)
        {
            error = "";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    cmdFunction.Connection = conn;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdFunction);
                    adapter.Fill(dt);
                }
                catch (SqlException ex)
                {
                    error = ex.Message;
                    MessageBox.Show(error);
                    dt = null;
                }
            }

            return dt;
        }

        //Tra ve bool khi thuc hien procedure
        public bool ExecuteProcedure(string sqlProcedure, CommandType ct, List<SqlParameter> parameters, ref string error)
        {
            bool f = false;
            error = "";

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = sqlProcedure;
                    cmd.CommandType = ct;
                    cmd.Parameters.Clear();
                    foreach (SqlParameter i in parameters)
                    {
                        cmd.Parameters.Add(i);
                    }

                    try
                    {
                        cmd.ExecuteNonQuery();
                        f = true;
                    }
                    catch (SqlException ex)
                    {
                        error = ex.Message;
                    }
                }
            }

            return f;
        }

        //Tra ve datatable khi thuc thi procedure
        public DataTable Procedure(string sqlProcedure, CommandType ct, List<SqlParameter> parameters, ref string error)
        {
            error = "";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlProcedure, conn))
                {
                    cmd.CommandType = ct;
                    foreach (SqlParameter i in parameters)
                    {
                        cmd.Parameters.Add(i);
                    }

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (SqlException ex)
                    {
                        error = ex.Message;
                    }
                }
            }
            return dt;
        }

    }
}
