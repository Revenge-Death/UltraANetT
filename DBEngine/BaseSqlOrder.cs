using System.Collections.Generic;
using NHibernate;
using NHibernate.SqlCommand;

namespace DBEngine
{
    /// <summary>
    /// 基础存储实现方法
    /// </summary>
    public  class BaseSqlOrder
    {
        #region 查询指令
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="queryStr">指定查询条件</param>
        /// <returns>返回查询队形</returns>
        public static IList<object[]> GetQuery(string queryStr)
        {
            using (var session = NHelper.OpenSession())
            {
                IList<object[]> products = session
                    .CreateSQLQuery(queryStr)
                    .List<object[]>();
                session.Flush();
                session.Clear();
                session.BeginTransaction().Commit();
                return products;
            }
        }
        #endregion

        #region 添加指令
        /// <summary>
        /// 添加指令
        /// </summary>
        /// <param name="listProduct">被添加对象</param>
        public static void Add(List<VehicelAuthorization> listProduct)
        {
            List<VehicelAuthorization> copyList = new List<VehicelAuthorization>();
            copyList.AddRange(listProduct);

            using (var session = NHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                foreach (var model in copyList)
                {
                    session.Save(model);
                    session.Flush();
                    session.Clear();
                }
                transaction.Commit();
            }
        }
        #endregion

        #region 删除指令
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="delStr">删除条件</param>
        public void Del(string delStr)
        {
            using (var session = NHelper.OpenSession())
            {
                session.CreateSQLQuery(delStr).ExecuteUpdate();
                session.Flush();
                session.Clear();
                session.BeginTransaction().Commit();
            }
        }
        #endregion

        #region 更新指令
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="updateStr">删除条件</param>
        public void Update(string updateStr)
        {
            using (var session = NHelper.OpenSession())
            {
                session.CreateSQLQuery(updateStr).ExecuteUpdate();
                session.Flush();
                session.Clear();
                session.BeginTransaction().Commit();
            }
        }
        #endregion

        #region MyRegion
        public bool IsExist(string queryStr)
        {
            using (ISession session = NHelper.OpenSession())
            {
                IList<object[]> products = session
                    .CreateSQLQuery(queryStr)
                    .List<object[]>();
                session.Flush();
                session.Clear();
                session.BeginTransaction().Commit();
                return products != null && products.Count > 0;
            }
        }
        #endregion

    }
}
