﻿using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public interface IDiscountServices
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync();
        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto);
        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto);
        Task DeleteDiscountCouponAsync(int id);
        Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);
        Task<ResultDiscountCouponDto> GetCodeDetailByCodeAsync(string code);
        int GetDiscountCouponRateAsync(string code);

    }
}
