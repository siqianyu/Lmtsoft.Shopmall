using System;
using System.Linq;
using System.Collections.Generic;
using Lmtsoft.Shopmall.Interface;
using Lmtsoft.Shopmall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Lmtsoft.Shopmall.Service
{
    public class UserService : IUserService
    {
        private ShopMallContext _shopMallContext = new ShopMallContext();

        public int Delete(User user)
        {
            _shopMallContext.User.Remove(user);
            return _shopMallContext.SaveChanges();

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        public RspResult Save(User user)
        {
            if (user == null)
            {
                return new RspResult() { Code = 200, Status = -1, Msg = "用户信息不能为空" };
            }
            if (string.IsNullOrWhiteSpace(user.Name))
            {
                return new RspResult() { Code = 200, Status = -1, Msg = "用户名不能为空" };
            }
            //id=0为注册 id>0为修改无需判断 用户名
            if (user.Id == 0 && Exsit(user.Name))
            {
                return new RspResult() { Code = 200, Status = -1, Msg = "用户名已存在" };
            }
            _shopMallContext.User.Add(user);
            if (_shopMallContext.SaveChanges() > 0)
            {
                return new RspResult() { Code = 200, Status = 1, Msg = "用户插入完成" };
            }
            else
            {
                return new RspResult() { Code = 200, Status = 0, Msg = "无法插入数据" };
            }
        }

        /// <summary>
        /// 登入
        /// </summary>
        /// <returns></returns>
        public RspResult SignIn(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        public RspResult SignOut(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> Query()
        {
            return _shopMallContext.User.Where(a => a.Id > 0);
        }
        /// <summary>
        /// 精准查询
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User QueryById(int id)
        {
            var users = _shopMallContext.User.Where(a => a.Id == id);
            if (users != null)
            {
                return users.FirstOrDefault();
            }
            else
            {
                return null;
            }

        }
        /// <summary>
        /// 精准查询
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User QueryByName(string name)
        {
            var users = _shopMallContext.User.Where(a => a.Name == name);
            if (users != null)
            {
                return users.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IEnumerable<User> Search(User user)
        {
            var obj = _shopMallContext.User.Where(a => a.Id > 0);
            if (!string.IsNullOrWhiteSpace(user.Name))
            {
                obj = obj.Where(a => a.Name.Contains(user.Name));
            }
            if (!string.IsNullOrWhiteSpace(user.NickName))
            {
                obj = obj.Where(a => a.Name.Contains(user.NickName));
            }
            return obj;
        }

        public bool Exsit(string name)
        {
            var users = QueryByName(name.Trim());
            if (users != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyCode(string mobile, string code)
        {
            throw new NotImplementedException();
        }
    }
}
