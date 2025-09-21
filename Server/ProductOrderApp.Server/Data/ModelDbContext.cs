using Microsoft.EntityFrameworkCore;
using SingularSystems.ProductOrderApp.Models;

namespace SingularSystems.ProductOrderApp.Data
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// sets customers
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// ets products
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// sets orders
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// sets order items
        /// </summary>
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

       
            //an order has one customer, a customer can have many orders (not modeled here)
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany()
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            
            //an order item has one order, an order can have many order items (not modeled here)
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany()
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            //an order item has one product, a product can have many order items (not modeled here)
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    ProductId = 1,
                    ProductName = "AirPods Max",
                    ProductDescription = "Apple AirPods Max, latest 2024 model, stunning blue.",
                    ProductPrice = 12999.00M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420464/airpods_max_2024_blue_pdp_image_position_01__wwen_1.png_fynhc8.jpg"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Apple Watch Series 11",
                    ProductDescription = "Apple Watch Series 11 in elegant rose gold.",
                    ProductPrice = 9999.00M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420464/apple_watch_series_11_42mm_gps_rose_gold_aluminum_sport_band_light_blush_pdp_image_position_1__wwen_zvxhlq.jpg"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "iPhone 17 Pro",
                    ProductDescription = "iPhone 17 Pro in cosmic orange finish.",
                    ProductPrice = 25999.00M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420465/cl_iphone_17_pro_cosmic_orange_pdp_image_position_1__wwen_a0zoer.jpg"
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "iPad Pro",
                    ProductDescription = "iPad Pro in sleek space black.",
                    ProductPrice = 19999.00M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420467/ipad_pro_11_m4_cellular_space_black_pdp_image_position_1b__wwen_1_1_1_1_1_1_1_1_1_1_3_u1tyrb.png"
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "iPhone 16 Plus",
                    ProductDescription = "iPhone 16 Plus in pristine white.",
                    ProductPrice = 21999.99M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420467/iphone_16_plus_white_pdp_image_position_1__wwen_1_1_1_yyjkna.png"
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "iPhone 16 Pro",
                    ProductDescription = "iPhone 16 Pro in classic white.",
                    ProductPrice = 23999.99M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420466/iphone_16_pro_white_titanium_pdp_image_position_1__gben_1_1_1_1_tlte9z.png"
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "iPhone 17",
                    ProductDescription = "iPhone 17 in stylish sage green.",
                    ProductPrice = 25999.99M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420465/iphone_17_sage_pdp_image_position_1__wwen_ye5iqg.jpg"
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "iPhone Air",
                    ProductDescription = "iPhone Air with a light gold finish.",
                    ProductPrice = 17999.99M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420465/iphone_air_light_gold_pdp_image_position_1__wwen_vulaid.jpg"
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "MacBook Air",
                    ProductDescription = "MacBook Air in silver, lightweight and powerful.",
                    ProductPrice = 24999.99M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420466/macbook_air_13-in_m4_chip_silver_pure_front_screen__usen_1_1_1_kvqt28.jpg"
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "MacBook Pro",
                    ProductDescription = "MacBook Pro in space black, high-performance laptop.",
                    ProductPrice = 37999.00M,
                    ImageUrl = "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420467/macbook_pro_16-inch_m4_pro_or_max_chip_space_black_pdp_image_position_1__wwen_1_3_pzpp6i.png"
                }



             );
        }

    }

}





