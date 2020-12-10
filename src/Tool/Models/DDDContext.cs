using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tool.Models
{
    public partial class DDDContext : DbContext
    {
        public DDDContext()
        {
        }

        public DDDContext(DbContextOptions<DDDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CouponList> CouponLists { get; set; }
        public virtual DbSet<Detail> Details { get; set; }
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
        public virtual DbSet<Primary> Primaries { get; set; }
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
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DDD;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<CouponList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Coupon_List");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponId)
                    .IsRequired()
                    .HasMaxLength(36)
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

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Detail");

                entity.Property(e => e.Amount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailedId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Diy_Group");

                entity.Property(e => e.CoverFile)
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
                entity.HasNoKey();

                entity.ToTable("Diy_Material");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialId)
                    .IsRequired()
                    .HasMaxLength(36)
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
                entity.HasNoKey();

                entity.ToTable("Diy_Scheduled");

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

                entity.Property(e => e.ScheduledId)
                    .IsRequired()
                    .HasMaxLength(36)
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
                entity.HasNoKey();

                entity.ToTable("Diy_Skin");

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

                entity.Property(e => e.SkinId)
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

            modelBuilder.Entity<DiyUserImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Diy_UserImage");

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

                entity.Property(e => e.UserImageId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Diy_Works");

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

                entity.Property(e => e.WorksId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyWorsImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Diy_WorsImage");

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

                entity.Property(e => e.WorsImageId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiyWorsText>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Diy_WorsText");

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

                entity.Property(e => e.WorsTextId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsBaseInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Goods_BaseInfo");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

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
                entity.HasNoKey();

                entity.ToTable("Goods_Dummy");

                entity.Property(e => e.BaseId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(50)
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
                entity.HasNoKey();

                entity.ToTable("Goods_KeyVal");

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.KeyId)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RowId)
                    .IsRequired()
                    .HasMaxLength(36)
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
                entity.HasNoKey();

                entity.ToTable("Goods_Link");

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.LinkGoodsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.LinkId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsPicBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Goods_PicBase");

                entity.Property(e => e.FileId)
                    .HasMaxLength(336)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(136)
                    .IsUnicode(false);

                entity.Property(e => e.PicId)
                    .IsRequired()
                    .HasMaxLength(36)
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
                entity.HasNoKey();

                entity.ToTable("Goods_Reduction");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GoodsId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReductionAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReductionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsReview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Goods_Review");

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

                entity.Property(e => e.ReviewId)
                    .IsRequired()
                    .HasMaxLength(36)
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
                entity.HasNoKey();

                entity.ToTable("Goods_ReviewStatistics");

                entity.Property(e => e.Average).HasColumnType("money");

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.StatisticsId)
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
                entity.HasNoKey();

                entity.ToTable("Goods_Sku");

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

                entity.Property(e => e.SkuId)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsSort>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Goods_Sort");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(360);

                entity.Property(e => e.SortId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

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
                entity.HasNoKey();

                entity.ToTable("Log_Error");

                entity.Property(e => e.Detailed).HasMaxLength(3000);

                entity.Property(e => e.ErrorId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorTime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("IP");

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
                entity.HasNoKey();

                entity.ToTable("Log_Operating");

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.LogId)
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

                entity.Property(e => e.ToUserId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Val).HasMaxLength(600);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logistics_Config");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Based).HasColumnType("money");

                entity.Property(e => e.ConfigId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FreePrice).HasColumnType("money");

                entity.Property(e => e.FreeQuantity).HasColumnType("money");

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
                entity.HasNoKey();

                entity.ToTable("MailList");

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

                entity.Property(e => e.Rowid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rowid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<MetaArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Meta_Area");

                entity.Property(e => e.AreaId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

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

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderBilling>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Billing");

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

                entity.Property(e => e.BillingId)
                    .IsRequired()
                    .HasMaxLength(36)
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
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderCalculator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Calculator");

                entity.Property(e => e.Cid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CID");

                entity.Property(e => e.PrimaryId).HasMaxLength(36);
            });

            modelBuilder.Entity<OrderCart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Cart");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.CartId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.SkuId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetailed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Detailed");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DetailedId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.DisId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldPrice).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

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
                    .IsUnicode(false);

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
                entity.HasNoKey();

                entity.ToTable("Order_Logistics");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BasedMoney).HasColumnType("money");

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

                entity.Property(e => e.LogisticsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticsId)
                    .IsRequired()
                    .HasMaxLength(36)
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
                entity.HasNoKey();

                entity.ToTable("Order_Primary");

                entity.Property(e => e.AdminRemark).HasMaxLength(800);

                entity.Property(e => e.Amount).HasColumnType("money");

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

                entity.Property(e => e.DesignPrice).HasColumnType("money");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExchangeRate).HasColumnType("money");

                entity.Property(e => e.LogisticsId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ModeId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.OrderMoney).HasColumnType("money");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.PayCurrencyId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.PayModelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayMoney).HasColumnType("money");

                entity.Property(e => e.PayPostage).HasColumnType("money");

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostTime).HasColumnType("datetime");

                entity.Property(e => e.Postage).HasColumnType("money");

                entity.Property(e => e.PrimaryId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Reduction).HasColumnType("money");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

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
                entity.HasNoKey();

                entity.ToTable("Pay_Currency");

                entity.Property(e => e.CurrencyCodeId)
                    .IsRequired()
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
                entity.HasNoKey();

                entity.ToTable("Pay_Mode");

                entity.Property(e => e.FileId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModeId)
                    .IsRequired()
                    .HasMaxLength(36)
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

            modelBuilder.Entity<Primary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Primary");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Client_Ip");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("From_Url");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Invoice_Id");

                entity.Property(e => e.IsHide)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsPaid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsPaidSync)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsPostSync)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Notify_Url");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Order_No");

                entity.Property(e => e.PayPalMail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PayTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnUri)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Return_Uri");

                entity.Property(e => e.SiteTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Site_Title");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SuccessUri)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Success_Uri");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Zip_Code");
            });

            modelBuilder.Entity<PropertyDelimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Property_Delimit");

                entity.Property(e => e.BackName).HasMaxLength(200);

                entity.Property(e => e.DelimitId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ShowName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Val)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PropertyList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Property_List");

                entity.Property(e => e.BackName).HasMaxLength(200);

                entity.Property(e => e.PropertyId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ShowName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_Account");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(36);

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

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
                entity.HasNoKey();

                entity.ToTable("Sys_Pages");

                entity.Property(e => e.Introduction).HasColumnType("text");

                entity.Property(e => e.PageId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_Settings");

                entity.Property(e => e.Rowid)
                    .IsRequired()
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
                entity.HasNoKey();

                entity.ToTable("User_Account");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(100);

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
