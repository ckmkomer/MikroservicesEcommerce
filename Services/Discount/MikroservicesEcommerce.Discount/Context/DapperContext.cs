using Microsoft.EntityFrameworkCore;

namespace MikroservicesEcommerce.Discount.Context
{
    public class DapperContext :DbContext
    {
        private readonly IConfiguration _configuration;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
