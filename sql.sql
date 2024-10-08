USE [QLY_TiemCuoi]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 5/6/2024 7:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[Ma_Don] [nvarchar](50) NOT NULL,
	[Ma_DV] [nvarchar](50) NOT NULL,
	[So_Luong] [int] NULL,
	[Don_Gia] [float] NULL,
	[Tong_Tien] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[Ma_Don] ASC,
	[Ma_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ds_CDVCT]    Script Date: 5/6/2024 7:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ds_CDVCT](
	[Ma_DV] [nvarchar](50) NOT NULL,
	[Ten_DV] [nvarchar](50) NULL,
	[Don_Gia] [float] NULL,
 CONSTRAINT [PK_ds_CDVCT_1] PRIMARY KEY CLUSTERED 
(
	[Ma_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/6/2024 7:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Ma_Don] [nvarchar](50) NOT NULL,
	[Ma_DV] [nvarchar](50) NOT NULL,
	[Ngay_Thue] [date] NULL,
	[Ten_KH] [nvarchar](50) NULL,
	[Ma_KH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HoaDon_1] PRIMARY KEY CLUSTERED 
(
	[Ma_Don] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/6/2024 7:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Ma_KH] [nvarchar](50) NOT NULL,
	[Ten_KH] [nvarchar](50) NULL,
	[Dia_Chi] [nvarchar](50) NULL,
	[SoDienThoai] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Ma_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qly_Taikhoan]    Script Date: 5/6/2024 7:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qly_Taikhoan](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Qly_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThaiDichVu]    Script Date: 5/6/2024 7:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiDichVu](
	[Ma_DV] [nvarchar](50) NOT NULL,
	[Trang_Thai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrangThaiDichVu] PRIMARY KEY CLUSTERED 
(
	[Ma_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD01', N'DV01', 3, 2000, 6000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD02', N'DV02', 2, 4000, 8000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD03', N'DV03', 1, 2500, 2500)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD04', N'DV04', 4, 3000, 12000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD05', N'DV05', 2, 3500, 7000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD06', N'DV06', 3, 4000, 12000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD07', N'DV07', 2, 4500, 9000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD08', N'DV08', 1, 5000, 5000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD09', N'DV09', 3, 5500, 16500)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD10', N'DV10', 2, 6000, 12000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD11', N'DV11', 4, 6500, 26000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD12', N'DV12', 1, 7000, 7000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD13', N'DV13', 3, 7500, 22500)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD14', N'DV14', 2, 8000, 16000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD15', N'DV15', 1, 8500, 8500)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD16', N'DV16', 3, 9000, 27000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD17', N'DV17', 2, 9500, 19000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD18', N'DV18', 1, 10000, 10000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD19', N'DV03', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD19', N'DV04', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD19', N'DV05', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD19', N'DV06', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD19', N'DV13', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD19', N'DV15', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD19', N'DV17', 40, 50000, 2000000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD19', N'DV19', 8, 4000, 32000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV02', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV03', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV04', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV06', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV08', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV10', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV12', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV13', 2, 2000, 4000)
INSERT [dbo].[ChiTietHoaDon] ([Ma_Don], [Ma_DV], [So_Luong], [Don_Gia], [Tong_Tien]) VALUES (N'MD20', N'DV17', 2, 2000, 4000)
GO
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV01', N'Thuê váy cưới', 2000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV02', N'Chụp hình cưới', 4000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV03', N'Thuê rạp ', 2500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV04', N'Thuê xe cưới', 3000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV05', N'Bê tráp', 3500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV06', N'Trang điểm dâu', 4000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV07', N'Trang trí bàn gia tiên', 4500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV08', N'Trang trí cổng', 5000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV09', N'Làm hoa ', 5500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV10', N'Thuê phụ kiện', 6000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV100', N'Thuê bàn ghế', 100000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV11', N'Thuê vest', 6500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV12', N'In thiệp', 7000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV13', N'Trái cây ngũ quả', 7500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV14', N'Trầu tiêm bao hỷ', 8000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV15', N'Bánh phu thê', 8500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV16', N'Bánh kem cưới', 9000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV17', N'Rượu cưới', 9500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV18', N'Thuê ban nhạc', 10000)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV19', N'Trang điểm xui gia', 10500)
INSERT [dbo].[ds_CDVCT] ([Ma_DV], [Ten_DV], [Don_Gia]) VALUES (N'DV20', N'Quay chụp truyền thống', 11000)
GO
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD01', N'DV02', CAST(N'2005-11-09' AS Date), N'Nguyen Van Anh', N'KH01')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD02', N'DV02', CAST(N'2000-11-11' AS Date), N'Nguyen Thi B', N'KH02')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD03', N'DV03', CAST(N'2024-04-03' AS Date), N'Nguyen Van C', N'KH03')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD04', N'DV04', CAST(N'2024-04-04' AS Date), N'Tran Van D', N'KH04')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD05', N'DV05', CAST(N'2024-04-05' AS Date), N'Le Thi E', N'KH05')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD06', N'DV06', CAST(N'2024-04-06' AS Date), N'Pham Van F', N'KH06')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD07', N'DV07', CAST(N'2024-04-07' AS Date), N'Hoang Thi G', N'KH07')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD08', N'DV08', CAST(N'2024-04-08' AS Date), N'Vu Van H', N'KH08')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD09', N'DV09', CAST(N'2024-04-09' AS Date), N'Ngo Thi I', N'KH09')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD10', N'DV10', CAST(N'2024-04-10' AS Date), N'Do Van K', N'KH10')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD11', N'DV11', CAST(N'2024-04-11' AS Date), N'Bui Thi L', N'KH11')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD12', N'DV12', CAST(N'2024-04-12' AS Date), N'Trinh Van M', N'KH12')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD13', N'DV13', CAST(N'2024-04-13' AS Date), N'Mai Thi N', N'KH13')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD14', N'DV14', CAST(N'2024-04-14' AS Date), N'Le Van O', N'KH14')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD15', N'DV15', CAST(N'2024-04-15' AS Date), N'Nguyen Thi P', N'KH15')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD16', N'DV16', CAST(N'2024-04-16' AS Date), N'Tran Van Q', N'KH16')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD17', N'DV17', CAST(N'2024-04-17' AS Date), N'Ho Thi R', N'KH17')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD18', N'DV18', CAST(N'2024-04-18' AS Date), N'Pham Van S', N'KH18')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD19', N'DV19', CAST(N'2024-04-16' AS Date), N'Pham Van S', N'KH18')
INSERT [dbo].[HoaDon] ([Ma_Don], [Ma_DV], [Ngay_Thue], [Ten_KH], [Ma_KH]) VALUES (N'MD20', N'DV17', CAST(N'2024-04-27' AS Date), N'Ho Thi R', N'KH17')
GO
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH01', N'Nguyen Van Anh', N'Ha Noi', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH02', N'Nguyen Thi BBBB', N'Da Nang', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH03', N'Nguyen Van C', N'Lai Chau', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH04', N'Tran Van D', N'Hai Phong', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH05', N'Le Thi E', N'Quang Nammm', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH06', N'Pham Van F', N'Can Tho', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH07', N'Hoang Thi G', N'Dong Thap', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH08', N'Vu Van H', N'Lang Son', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH09', N'Ngo Thi I', N'Bac Ninh', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH10', N'Do Van K', N'Quang Binh', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH100', N'100', N'100', 100)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH101', N'Le Huu', N'HN', 355355355)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH11', N'Bui Thi L', N'Thai Binh', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH12', N'Trinh Van M', N'Tien Giang', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH13', N'Mai Thi N', N'Ben Tre', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH14', N'Le Van O', N'Vinh Long', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH15', N'Nguyen Thi P', N'Phu Yen', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH16', N'Tran Van Q', N'Kien Giang', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH17', N'Ho Thi R', N'Long An', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH18', N'Pham Van S', N'An Giang', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH19', N'Nguyen Thi T', N'Tra Vinh', 987654321)
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [Dia_Chi], [SoDienThoai]) VALUES (N'KH20', N'Le Van U', N'Dak Lak', 987654321)
GO
INSERT [dbo].[Qly_Taikhoan] ([username], [password]) VALUES (N'1', N'1')
INSERT [dbo].[Qly_Taikhoan] ([username], [password]) VALUES (N'2', N'1')
INSERT [dbo].[Qly_Taikhoan] ([username], [password]) VALUES (N'admin', N'admin')
INSERT [dbo].[Qly_Taikhoan] ([username], [password]) VALUES (N'admin1', N'admin11')
INSERT [dbo].[Qly_Taikhoan] ([username], [password]) VALUES (N'admin1admin1', N'admin1')
INSERT [dbo].[Qly_Taikhoan] ([username], [password]) VALUES (N'ha', N'ha')
INSERT [dbo].[Qly_Taikhoan] ([username], [password]) VALUES (N'hi', N'hi')
GO
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV01', N'Yes')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV02', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV03', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV04', N'Yes')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV05', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV06', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV07', N'Yes')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV08', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV09', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV10', N'Yes')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV11', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV12', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV13', N'Yes')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV14', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV15', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV16', N'Yes')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV17', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV18', N'No')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV19', N'Yes')
INSERT [dbo].[TrangThaiDichVu] ([Ma_DV], [Trang_Thai]) VALUES (N'DV20', N'No')
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_ds_CDVCT] FOREIGN KEY([Ma_DV])
REFERENCES [dbo].[ds_CDVCT] ([Ma_DV])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_ds_CDVCT]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([Ma_Don])
REFERENCES [dbo].[HoaDon] ([Ma_Don])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([Ma_KH])
REFERENCES [dbo].[KhachHang] ([Ma_KH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_TrangThaiDichVu] FOREIGN KEY([Ma_DV])
REFERENCES [dbo].[TrangThaiDichVu] ([Ma_DV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_TrangThaiDichVu]
GO
