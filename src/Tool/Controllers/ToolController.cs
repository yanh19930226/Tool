using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tool.Models;

namespace Tool.Controllers
{
    [Route("Api/Tool")]
    [ApiController]
    public class ToolController : Controller
    {
        /// <summary>
        /// Uploade1
        /// </summary>
        /// <returns></returns>
        [Route("Uploade1")]
        [HttpGet]
        public  IActionResult Uploade1()
        {

            var ct = new DDDContext();

            var PrimaliList = ct.Primaries.ToList();

            //foreach (var item in collection)
            //{

            //}

            foreach (var item in PrimaliList)
            {
                var orderPrimary = new OrderPrimary()
                {
                    PrimaryId=item.PrimaryId,
                  
                    PaymentCode = null,
                    WebId = "NewTemp01",
                    UserId=null,
                    Email =item.Email,
                    //1未付款2已付款
                    Status = item.PayTime== null ? 1 : 2,
                    CurrencyId = item.Currency,
                    Amount =Convert.ToDecimal(item.Amount),
                    Postage = 0,
                    PayPostage =0,
                    DesignPrice = 0,
                    ModeId = null,
                    CouponId = null,
                    CouponUserId = null,
                    CouponReduction = 0,
                    Reduction = 0,
                    PostTime = Convert.ToDateTime(item.PostTime),
                    PayTime = Convert.ToDateTime(item.PayTime),
                    OrderTime = null,
                    IsAddress = 1,
                    IsSync = 0,
                    SyncTime = null,
                    IsPay =0,

                    Serial = "",
                    OrderMoney = Convert.ToDecimal(item.Amount),
                    LogisticsId = "",
                    PayCurrencyId = "",
                    ExchangeRate = 1m,
                    PayMoney = Convert.ToDecimal(item.Amount),

                };

                var orderBilling = new OrderBilling()
                {
                     BillingId = Guid.NewGuid().ToString(),
                     PrimaryId =item.PrimaryId,
                     FirstName=item.Name,
                     LastName= item.Name,
                    Address1 =item.Address,
                     Address2=item.Address2,
                     City= item.City,
                    AreaId =null,
                    AreaName = item.State,
                     CountryName = item.Country,
                    CountryId = item.Country,
                     ZipCode= item.ZipCode,
                    Phone = item.Telephone,
                    Version ="",

    };
            }

            var DetailList = ct.Details.ToList();

            foreach (var item in DetailList)
            {
                var detail = new OrderDetailed()
                {
                    DetailedId=item.DetailedId,
                    Title="",
                    PrimaryId="",
                    UserId = "",
                    GoodsId = "",
                   ImageUrl = "",
                   SkuName = "",
                   SkuId = "",
                   Price = 1m,
                   OldPrice =1m,
                   DisId = "",
                   Num = 1,
                   CreateTime = DateTime.Now,
                   Remark = "",
                   Version = "",
                };
            }
            return Ok();

        }
        /// <summary>
        /// Uploade2
        /// </summary>
        /// <returns></returns>
        [Route("Uploade2")]
        [HttpGet]
        public IActionResult Uploade2()
        {

            return Ok();

        }
    }
}
