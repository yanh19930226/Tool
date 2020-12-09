using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tool.Models
{
    public partial class testContext : DbContext
    {
        public testContext()
        {
        }

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CouponList> CouponLists { get; set; }
        public virtual DbSet<DiyGroup> DiyGroups { get; set; }
        public virtual DbSet<DiyMaterial> DiyMaterials { get; set; }
        public virtual DbSet<DiyScheduled> DiyScheduleds { get; set; }
        public virtual DbSet<DiySkin> DiySkins { get; set; }
        public virtual DbSet<DiyUserImage> DiyUserImages { get; set; }
        public virtual DbSet<DiyWork> DiyWorks { get; set; }
        public virtual DbSet<DiyWorsImage> DiyWorsImages { get; set; }
        public virtual DbSet<DiyWorsText> DiyWorsTexts { get; set; }
        public virtual DbSet<GoodsBaseInfo> GoodsBaseInfos { get; set; }
        public virtual DbSet<GoodsDummy> GoodsDummies { get; set; }
        public virtual DbSet<GoodsKeyVal> GoodsKeyVals { get; set; }
        public virtual DbSet<GoodsLink> GoodsLinks { get; set; }
        public virtual DbSet<GoodsPicBase> GoodsPicBases { get; set; }
        public virtual DbSet<GoodsReduction> GoodsReductions { get; set; }
        public virtual DbSet<GoodsReview> GoodsReviews { get; set; }
        public virtual DbSet<GoodsReviewStatistic> GoodsReviewStatistics { get; set; }
        public virtual DbSet<GoodsSku> GoodsSkus { get; set; }
        public virtual DbSet<GoodsSort> GoodsSorts { get; set; }
        public virtual DbSet<LogError> LogErrors { get; set; }
        public virtual DbSet<LogOperating> LogOperatings { get; set; }
        public virtual DbSet<LogisticsConfig> LogisticsConfigs { get; set; }
        public virtual DbSet<MailList> MailLists { get; set; }
        public virtual DbSet<MetaArea> MetaAreas { get; set; }
        public virtual DbSet<OrderBilling> OrderBillings { get; set; }
        public virtual DbSet<OrderCalculator> OrderCalculators { get; set; }
        public virtual DbSet<OrderCart> OrderCarts { get; set; }
        public virtual DbSet<OrderDetailed> OrderDetaileds { get; set; }
        public virtual DbSet<OrderLogistic> OrderLogistics { get; set; }
        public virtual DbSet<OrderPrimary> OrderPrimaries { get; set; }
        public virtual DbSet<PayCurrency> PayCurrencies { get; set; }
        public virtual DbSet<PayMode> PayModes { get; set; }
        public virtual DbSet<PropertyDelimit> PropertyDelimits { get; set; }
        public virtual DbSet<PropertyList> PropertyLists { get; set; }
        public virtual DbSet<SysAccount> SysAccounts { get; set; }
        public virtual DbSet<SysPage> SysPages { get; set; }
        public virtual DbSet<SysSetting> SysSettings { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserMail> UserMails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=test;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<CouponList>(entity =>
            {
                entity.HasKey(e => e.CouponId);

                entity.ToTable("Coupon_List");

                entity.Property(e => e.CouponId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.EndTime).HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_DIY_GROUP");

                entity.ToTable("Diy_Group");

                entity.HasComment("Diy_Group - 定制分组");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CoverFile)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyMaterial>(entity =>
            {
                entity.HasKey(e => e.MaterialId)
                    .HasName("PK_DIY_MATERIAL");

                entity.ToTable("Diy_Material");

                entity.Property(e => e.MaterialId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyScheduled>(entity =>
            {
                entity.HasKey(e => e.ScheduledId)
                    .HasName("PK_DIY_SCHEDULED");

                entity.ToTable("Diy_Scheduled");

                entity.Property(e => e.ScheduledId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.BorderMaterialId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Font)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FontMaterialId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShirtNum)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiySkin>(entity =>
            {
                entity.HasKey(e => e.SkinId)
                    .HasName("PK_DIY_SKIN");

                entity.ToTable("Diy_Skin");

                entity.HasComment("Diy_Skin - 定制皮肤");

                entity.Property(e => e.SkinId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Back)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.BackInfo).HasMaxLength(50);

                entity.Property(e => e.Demo)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.Front)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyUserImage>(entity =>
            {
                entity.HasKey(e => e.UserImageId)
                    .HasName("PK_DIY_USERIMAGE");

                entity.ToTable("Diy_UserImage");

                entity.HasComment("Diy_UserImage - 定制用户上传的图片");

                entity.Property(e => e.UserImageId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.ImageFile)
                    .IsRequired()
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.ImageMiniFile)
                    .IsRequired()
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyWork>(entity =>
            {
                entity.HasKey(e => e.WorksId)
                    .HasName("PK_DIY_WORKS");

                entity.ToTable("Diy_Works");

                entity.HasComment("Diy_Works - 定制作品");

                entity.Property(e => e.WorksId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Back)
                    .IsRequired()
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.CoverFile)
                    .IsRequired()
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.Front)
                    .IsRequired()
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .IsRequired()
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.SkinList)
                    .HasMaxLength(720)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyWorsImage>(entity =>
            {
                entity.HasKey(e => e.WorsImageId)
                    .HasName("PK_DIY_WORSIMAGE");

                entity.ToTable("Diy_WorsImage");

                entity.HasComment("Diy_WorsImage - 定制用户作品选用图片");

                entity.Property(e => e.WorsImageId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.ImageFile)
                    .IsRequired()
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.UserImageId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyWorsText>(entity =>
            {
                entity.HasKey(e => e.WorsTextId)
                    .HasName("PK_DIY_WORSTEXT");

                entity.ToTable("Diy_WorsText");

                entity.HasComment("Diy_WorsText - 定制用户作品选用");

                entity.Property(e => e.WorsTextId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Border)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.TextVal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksId)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsBaseInfo>(entity =>
            {
                entity.HasKey(e => e.GoodsId)
                    .HasName("PK_GOODS_BASEINFO");

                entity.ToTable("Goods_BaseInfo");

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.Introduction).HasColumnType("text");

                entity.Property(e => e.Js)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialList).HasColumnType("text");

                entity.Property(e => e.OldPrice).HasColumnType("money");

                entity.Property(e => e.Option1Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Option2Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ScheduledList).HasColumnType("text");

                entity.Property(e => e.SortId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Tags)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(300);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsDummy>(entity =>
            {
                entity.HasKey(e => e.GoodsId);

                entity.ToTable("Goods_Dummy");

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsKeyVal>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK_GOODS_KEYVAL");

                entity.ToTable("Goods_KeyVal");

                entity.HasComment("Goods_KeyVal -  商品关联");

                entity.Property(e => e.RowId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.KeyId)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsLink>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("Goods_Link");

                entity.Property(e => e.LinkId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.LinkGoodsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsPicBase>(entity =>
            {
                entity.HasKey(e => e.PicId)
                    .HasName("PK_GOODS_PICBASE");

                entity.ToTable("Goods_PicBase");

                entity.HasComment("Goods_PicBase -  图案相关图片");

                entity.Property(e => e.PicId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.FileId)
                    .HasMaxLength(336)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.Val)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsReduction>(entity =>
            {
                entity.HasKey(e => e.ReductionId);

                entity.ToTable("Goods_Reduction");

                entity.Property(e => e.ReductionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReductionAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsReview>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PK_GOODS_REVIEW");

                entity.ToTable("Goods_Review");

                entity.HasComment("Goods_Review -  商品评论");

                entity.Property(e => e.ReviewId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PicList)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsReviewStatistic>(entity =>
            {
                entity.HasKey(e => e.StatisticsId)
                    .HasName("PK_GOODS_REVIEWSTATISTICS");

                entity.ToTable("Goods_ReviewStatistics");

                entity.HasComment("Goods_ReviewStatistics -  商品评论统计");

                entity.Property(e => e.StatisticsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Average).HasColumnType("money");

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.StatisticsTime).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsSku>(entity =>
            {
                entity.HasKey(e => e.SkuId)
                    .HasName("PK_GOODS_SKU");

                entity.ToTable("Goods_Sku");

                entity.HasComment("Goods_Sku - 商品基础");

                entity.Property(e => e.SkuId)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.OldPrice).HasColumnType("money");

                entity.Property(e => e.Option1)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Option2)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsSort>(entity =>
            {
                entity.HasKey(e => e.SortId)
                    .HasName("PK_GOODS_SORT");

                entity.ToTable("Goods_Sort");

                entity.HasComment("Goods_Sort -  商品分类表");

                entity.Property(e => e.SortId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(360);

                entity.Property(e => e.Sno).HasComment("商品分类排序 ，按从小到大排序，序号越小越前面");

                entity.Property(e => e.SortName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SuperiorsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK_LOG_ERROR");

                entity.ToTable("Log_Error");

                entity.HasComment("Log_Error - 异常日志");

                entity.Property(e => e.ErrorId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Detailed).HasMaxLength(3000);

                entity.Property(e => e.ErrorTime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.LevelNum).HasComment("1  提示   Prompt\r\n   2  警告   Warning\r\n   3  普通  Ordinary\r\n   4  严重  Serious");

                entity.Property(e => e.Msg).HasMaxLength(300);

                entity.Property(e => e.Pager).HasMaxLength(300);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogOperating>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_LOG_OPERATING");

                entity.ToTable("Log_Operating");

                entity.HasComment("Log_Operating - 操作日志");

                entity.Property(e => e.LogId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ModelId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.OpPagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpTime).HasColumnType("datetime");

                entity.Property(e => e.OpType).HasComment("1  添加商品  AddGoods \r\n   2  发布商品  PubGoods");

                entity.Property(e => e.ToUserId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Val)
                    .HasMaxLength(600)
                    .HasComment("Json格式");

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsConfig>(entity =>
            {
                entity.HasKey(e => e.ConfigId)
                    .HasName("PK_LOGISTICS_CONFIG");

                entity.ToTable("Logistics_Config");

                entity.HasComment("Express_Config - 快递配置");

                entity.Property(e => e.ConfigId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Based).HasColumnType("money");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FreePrice).HasColumnType("money");

                entity.Property(e => e.FreeQuantity).HasColumnType("money");

                entity.Property(e => e.Status).HasComment("1  可用 Open\r\n   2  不可用 Close\r\n   ");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MailList>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_Mail");

                entity.ToTable("MailList");

                entity.Property(e => e.Rowid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rowid");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.Mail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<MetaArea>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PK_META_AREA");

                entity.ToTable("Meta_Area");

                entity.HasComment("Meta_Area - 国家地区");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("关联语言表");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(360)
                    .IsUnicode(false);

                entity.Property(e => e.SuperiorsId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Types).HasComment("1   国家  Country\r\n   2   地区  Area\r\n   3   城市  City");

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderBilling>(entity =>
            {
                entity.HasKey(e => e.BillingId)
                    .HasName("PK_ORDER_BILLING");

                entity.ToTable("Order_Billing");

                entity.HasComment("Order_Billing 账单地址");

                entity.Property(e => e.BillingId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("账单地址ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("订单ID");

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderCalculator>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK_ORDER_CALCULATOR");

                entity.ToTable("Order_Calculator");

                entity.HasComment("Order_Calculator - 订单计数器");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.PrimaryId)
                    .HasMaxLength(36)
                    .HasComment("订单ID");
            });

            modelBuilder.Entity<OrderCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK_ORDER_CART");

                entity.ToTable("Order_Cart");

                entity.HasComment("Order_Cart - 购物车");

                entity.Property(e => e.CartId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("商品ID");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasComment("商品次要属性JSON");

                entity.Property(e => e.SkuId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("主要颜色");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("用户ID");

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetailed>(entity =>
            {
                entity.HasKey(e => e.DetailedId)
                    .HasName("PK_ORDER_DETAILED");

                entity.ToTable("Order_Detailed");

                entity.Property(e => e.DetailedId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DisId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("-1 表示无折扣信息");

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldPrice).HasColumnType("money");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasComment("包含设计费运费");

                entity.Property(e => e.PrimaryId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SkuId)
                    .IsRequired()
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasComment("商品Sku");

                entity.Property(e => e.SkuName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderLogistic>(entity =>
            {
                entity.HasKey(e => e.LogisticsId)
                    .HasName("PK_ORDER_LOGISTICS");

                entity.ToTable("Order_Logistics");

                entity.HasComment("Order_Logistics - 物流信息");

                entity.Property(e => e.LogisticsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appellation).HasComment("1  Mr  Mr\r\n   2  Mrs  Mrs\r\n   3  Ms Ms");

                entity.Property(e => e.AreaId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BasedMoney)
                    .HasColumnType("money")
                    .HasComment("复制过来的数据");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsShip).HasComment("与订单主表的状态有关");

                entity.Property(e => e.LogisticsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTime).HasColumnType("datetime");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Villages)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderPrimary>(entity =>
            {
                entity.HasKey(e => e.PrimaryId)
                    .HasName("PK_ORDER_PRIMARY");

                entity.ToTable("Order_Primary");

                entity.Property(e => e.PrimaryId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdminRemark).HasMaxLength(800);

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("订单总金额含邮费优惠金额折扣金额");

                entity.Property(e => e.CouponId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CouponReduction).HasColumnType("money");

                entity.Property(e => e.CouponUserId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.DesignPrice)
                    .HasColumnType("money")
                    .HasComment("美金");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExchangeRate).HasColumnType("money");

                entity.Property(e => e.IsSync).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogisticsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ModeId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("支付方式");

                entity.Property(e => e.OrderMoney)
                    .HasColumnType("money")
                    .HasComment("订单总金额含邮费 减去优惠卷金额");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.PayCurrencyId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.PayModelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayMoney)
                    .HasColumnType("money")
                    .HasComment("含邮费 单位实际支付币种");

                entity.Property(e => e.PayPostage)
                    .HasColumnType("money")
                    .HasComment("含邮费 单位实际支付币种");

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostTime).HasColumnType("datetime");

                entity.Property(e => e.Postage).HasColumnType("money");

                entity.Property(e => e.Reduction).HasColumnType("money");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasComment("1  未付款  Unpaid\r\n   2  已付款  Paid\r\n   3  订单暂停 Pause\r\n   4  已发货  Shipped\r\n   5  订单完成 Ok\r\n   7  关闭订单  Close\r\n   ");

                entity.Property(e => e.SyncTime).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.UserRemark).HasMaxLength(800);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WebId)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyCodeId);

                entity.ToTable("Pay_Currency");

                entity.Property(e => e.CurrencyCodeId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayMode>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK_PAY_MODE");

                entity.ToTable("Pay_Mode");

                entity.Property(e => e.ModeId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.FileId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModeName)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.PayArgs)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PayUrl).HasMaxLength(200);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PropertyDelimit>(entity =>
            {
                entity.HasKey(e => e.DelimitId)
                    .HasName("PK_PROPERTY_DELIMIT");

                entity.ToTable("Property_Delimit");

                entity.HasComment("Property_Delimit -  商品属性定义表");

                entity.Property(e => e.DelimitId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.BackName).HasMaxLength(200);

                entity.Property(e => e.PropertyId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ShowName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Val)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("可空，颜色标准：#FFFFFF");

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PropertyList>(entity =>
            {
                entity.HasKey(e => e.PropertyId)
                    .HasName("PK_PROPERTY_LIST");

                entity.ToTable("Property_List");

                entity.HasComment("Property_List -  商品属性表");

                entity.Property(e => e.PropertyId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.BackName).HasMaxLength(200);

                entity.Property(e => e.ShowName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysAccount>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK_SYS_ACCOUNT");

                entity.ToTable("Sys_Account");

                entity.HasComment("Sys_Account - 管理员表");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(36);

                entity.Property(e => e.Mail).HasMaxLength(100);

                entity.Property(e => e.PurviewId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(36);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysPage>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.ToTable("Sys_Pages");

                entity.Property(e => e.PageId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Introduction).HasColumnType("text");

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysSetting>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_SYS_SETTINGS");

                entity.ToTable("Sys_Settings");

                entity.HasComment("Sys_Settings - 网站设置");

                entity.Property(e => e.Rowid)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Types).HasMaxLength(30);

                entity.Property(e => e.Val).HasMaxLength(800);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.Account)
                    .HasName("PK_user_ACCOUNT");

                entity.ToTable("User_Account");

                entity.Property(e => e.Account).HasMaxLength(100);

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User_Mail");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Details).HasMaxLength(500);

                entity.Property(e => e.DisTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Ip).HasMaxLength(200);

                entity.Property(e => e.MailId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
