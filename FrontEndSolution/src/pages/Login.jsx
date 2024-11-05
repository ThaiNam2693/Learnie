import React from "react";

const Login = () => {
  return (
    <div className="flex items-center justify-center min-h-screen bg-purple-600 bg-cover bg-center" style={{ backgroundImage: `url('/icon/1.jpg')` }}>
      <div className="text-center text-white">
        {/* Vòng tròn nền */}
        <div className="relative w-96 p-10 bg-purple-600 rounded-full shadow-lg">
          <h2 className="mb-5 text-3xl">Đăng nhập</h2>
          <h3 className="text-lg">Điền email vào ô bên dưới</h3>
          <form method="post" action="@Url.Action('Login', 'Account')" className="flex flex-col items-center mt-4">
            <input 
              type="email" 
              name="Email" 
              placeholder="Gmail" 
              required 
              className="w-full max-w-sm p-3 my-2 text-black placeholder-gray-500 rounded-lg focus:outline-none"
            />
            <input 
              type="password" 
              name="Password" 
              placeholder="Mật khẩu" 
              required 
              className="w-full max-w-sm p-3 my-2 text-black placeholder-gray-500 rounded-lg focus:outline-none"
            />
            <p className="mt-2 text-sm">Chưa có tài khoản?</p>
            <button 
              type="submit" 
              className="w-full max-w-xs px-8 py-3 mt-5 text-lg font-bold text-blue-800 bg-pink-400 rounded-full hover:bg-pink-500"
            >
              BẮT ĐẦU HỌC
            </button>
          </form>
        </div>
      </div>
    </div>
  );
};

export default Login;
