using AdvertiseSDK;
using AdvertiseSDK.Model;
using erp.dbmodel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tool.Controllers
{

    [Route("Api/Tool")]
    [ApiController]
    public class AdvertiseController : Controller
    {
        private readonly Client _client;

        public AdvertiseController(Client client)
        {
            _client = client;
        }
        /// <summary>
        /// 获取公司Id
        /// </summary>
        /// <param name="ShopId"></param>
        private SysShop GetCompanyId(string ShopId)
        {
            return yq.ibase.DbExec.DoRead((db) =>
            {
                yq.ibase.SQLHelper sqlcn = new yq.ibase.SQLHelper(db);
                sqlcn.AddInParameter("ShopId", System.Data.DbType.String, ShopId);
                string sql = " select sys_shop.CompanyId from sys_shop Where  ShopId=@ShopId ";
                var dt = sqlcn.ExecuteDataTable(sql);
                return new yq.ibase.ModelBase<SysShop>().GetIList(dt).ToList().FirstOrDefault();
            });
        }
        /// <summary>
        /// 获取广告费用
        /// </summary>
        /// <param name="ShopId"></param>
        /// <param name="Date"></param>
        private  string GetFeeServices(string ShopId,string Date)
        {
            var companyId=GetCompanyId(ShopId).CompanyId;
            return yq.ibase.DbExec.DoRead((db) =>
            {
                float spend_new = 0, orgspend_new = 0;
                var shopAccounts = GetShopAccount(ShopId).ToList();
                if (shopAccounts != null && shopAccounts.Count > 0)
                {
                    for (int i = 0; i < shopAccounts.Count; i++)
                    {
                        if (shopAccounts[i].State != yq.enums.BooleanType.No)
                        {
                            try
                            {
                                var res = _client.GetRequestAsync(new ReturnModelRequest(companyId)
                                {
                                    filter = shopAccounts[i].ActId,
                                    start = Date,
                                    end = Date,

                                }).Result;

                                orgspend_new += res.total.spend_new;

                                spend_new += res.total.spend_new + (res.total.spend_new * 5 / 100 * (float)shopAccounts[i].HandlingFree);
                            }
                            catch (Exception ex)
                            {

                                orgspend_new = 0;

                                spend_new = 0;

                                Console.WriteLine(ex.Message);

                                break;
                            }
                        }
                    }
                }
                return spend_new.ToString();
            });
        }

        /// <summary>
        /// 获取店铺关联的账号
        /// </summary>
        /// <param name="ShopId"></param>
        /// <returns></returns>
        private IList<SysShopAndAdvertisement> GetShopAccount(string ShopId)
        {
            return yq.ibase.DbExec.DoRead((db) =>
            {
                yq.ibase.SQLHelper sqlcn = new yq.ibase.SQLHelper(db);
                sqlcn.AddInParameter("ShopId", System.Data.DbType.String, ShopId);
                string sql = " select distinct (ActId),State from sys_shopandadvertisement where ShopId=@ShopId ";
                var dt = sqlcn.ExecuteDataTable(sql);
                return new yq.ibase.ModelBase<SysShopAndAdvertisement>().GetIList(dt);
            });
        }

        /// <summary>
        /// GetFee
        /// </summary>
        /// <param name="ShopId">店铺Id</param>
        /// <param name="Date">时间</param>
        /// <returns></returns>
        [Route("GetFee")]
        [HttpGet]
        public IActionResult GetFee(string ShopId,string Date)
        {
            var res=GetFeeServices(ShopId,Date);
            return Ok(res);
        }
    }
}
