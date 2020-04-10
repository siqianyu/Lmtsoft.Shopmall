using Lmtsoft.Shopmall.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lmtsoft.Shopmall.Interface
{
    public interface IBaseManagerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<BaseManager> Query();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BaseManager QueryById(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        BaseManager QueryByName(string name);

        /// <summary>
        /// 模糊 查询
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        IEnumerable<BaseManager> Search(BaseManager user);
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        RspResult SignIn(BaseManager user);
        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        RspResult SignOut(BaseManager user);

        /// <summary>
        /// 保存 修改
        /// </summary>
        /// <returns></returns>
        RspResult Save(BaseManager user);
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        int Delete(BaseManager user);
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
