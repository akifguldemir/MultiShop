using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Discount.Dtos;
using MultiShop.Discount.Services;

namespace MultiShop.Discount.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountServices _discountServices;

        public DiscountsController(IDiscountServices discountServices)
        {
            _discountServices = discountServices;
        }

        [HttpGet]

        public async Task<IActionResult> DiscountCouponList()
        {
            var values = await _discountServices.GetAllDiscountCouponAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponById(int id)
        {
            var values = await _discountServices.GetByIdDiscountCouponAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDto createCouponDto)
        {
            await _discountServices.CreateDiscountCouponAsync(createCouponDto);
            return Ok("Coupon created");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountServices.DeleteDiscountCouponAsync(id);
            return Ok("Coupon deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateCouponDto)
        {
            await _discountServices.UpdateDiscountCouponAsync(updateCouponDto);
            return Ok("Coupon updated");
        }

        [HttpGet("GetCodeDetailByCode")]
        public async Task<IActionResult> GetCodeDetailByCode(string code)
        {
            var values = await _discountServices.GetCodeDetailByCodeAsync(code);
            return Ok(values);
        }

        [HttpGet("GetDiscountCouponRate")]
        public IActionResult GetDiscountCouponRate(string code)
        {
            var values = _discountServices.GetDiscountCouponRateAsync(code);
            return Ok(values);
        }

    }
}
