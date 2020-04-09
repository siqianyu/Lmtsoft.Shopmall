using Lmtsoft.Shopmall.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lmtsoft.Shopmall.Interface
{
    public interface IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> Query();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User QueryById(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        User QueryByName(string name);

        /// <summary>
        /// 模糊 查询
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        IEnumerable<User> Search(User user);
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        RspResult SignIn(User user);
        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        RspResult SignOut(User user);

        /// <summary>
        /// 保存 修改
        /// </summary>
        /// <returns></returns>
        RspResult Save(User user);
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        int Delete(User user);
        /// <summary>
        /// 用户名是否存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool Exsit(string name);
        /// <summary>
        /// 判断手机验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        bool VerifyCode(string mobile, string code);
    }
}
