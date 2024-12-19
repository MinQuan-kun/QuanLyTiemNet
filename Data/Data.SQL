CREATE DATABASE QLTiemNet
--DROP DATABASE QLTiemNet
-- DROP TABLE Users
-- DROP TABLE Menu
-- DROP TABLE Category
-- DROP TABLE Status
-- DROP TABLE Bill
-- DROP TABLE BillDetails
-- DROP TABLE ImportTable
-- DROP TABLE MESSAGE
-- DROP TABLE DoanhThu
-- DROP TABLE Deposits
Use QLTiemNet
GO
-- Bảng Admin
CREATE TABLE Admin(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(MAX) NOT NULL
)

-- Bảng Users
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARBINARY(MAX) NOT NULL,
    RandomKey VARCHAR(50),
    CardID INT,
    Point DECIMAL(10, 3) DEFAULT 0
);

-- Bảng thẻ
CREATE TABLE Cards (
    CardID INT PRIMARY KEY IDENTITY(1,1),  
    UserID INT,
    CardType NVARCHAR(500) CHECK (CardType IN (N'VIP', N'Thành viên')) NOT NULL,
    Stas NVARCHAR(500) CHECK (Stas IN (N'đang hoạt động', N'Đã khóa')),
    Balance DECIMAL(10, 3) DEFAULT 0,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
);

-- Bảng thẻ loại
CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1), 
    CategoryName NVARCHAR(500) UNIQUE
);

-- Bảng menu
CREATE TABLE Menu (
    FoodID INT PRIMARY KEY IDENTITY(1,1),  
    CategoryID INT,
    FoodName NVARCHAR(100) UNIQUE NOT NULL,
    Price DECIMAL(10, 3) NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    Image Image,
    Notes TEXT,
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID),
);
-- Bảng hóa đơn
CREATE TABLE Bill (
    BillID INT PRIMARY KEY IDENTITY(1,1),  
    UserID INT NOT NULL,
    TotalAmount DECIMAL(10, 3) DEFAULT 0, -- Tổng số tiền của hóa đơn
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    Status NVARCHAR(50) CHECK (Status IN (N'Đang xử lý', N'Hoàn thành')) NOT NULL DEFAULT N'Đang xử lý',
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- Bảng chi tiết hóa đơn
CREATE TABLE BillDetails (
    DetailID INT PRIMARY KEY IDENTITY(1,1),  
    BillID INT NOT NULL,
    UserID INT NOT NULL,
    FoodID INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    Price DECIMAL(10, 3) NOT NULL DEFAULT 0,
    TotalPrice AS (Quantity * Price) PERSISTED,
    FOREIGN KEY (BillID) REFERENCES Bill(BillID) ON DELETE CASCADE,
    FOREIGN KEY (FoodID) REFERENCES Menu(FoodID) ON DELETE NO ACTION,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE NO ACTION
);

-- Bảng nhập hàng
CREATE TABLE ImportTable (
    ImportID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    FoodID INT NOT NULL,
    CategoryID INT NOT NULL,
    Quantum INT NOT NULL DEFAULT 0,
    SumPrice DECIMAL(10, 3) NOT NULL DEFAULT 0,
    ImportDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CustomerID) REFERENCES Admin(ID),
    FOREIGN KEY (FoodID) REFERENCES Menu(FoodID),
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);

-- Bảng tin nhắn
CREATE TABLE Messages (
    Username VARCHAR(50) NOT NULL,
    SentTime DATETIME NOT NULL,
    Mess NVARCHAR(MAX) NOT NULL,
    Stas NVARCHAR(20) DEFAULT 'Chưa xem' CHECK (Stas IN (N'Chưa xem', N'Đã xem')) NOT NULL,
	FOREIGN KEY (Username) REFERENCES Users(Username),
    PRIMARY KEY (Username, SentTime),
);

-- Bảng nạp tiền
CREATE TABLE Deposits (
    DepositID INT IDENTITY(1,1) PRIMARY KEY, -- Khóa chính tự tăng
    UserID INT NOT NULL,
    Amount DECIMAL(10, 3) NOT NULL DEFAULT 0,
    DepositTime DATETIME NOT NULL DEFAULT GETDATE(),
	FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Thêm dữ liệu mẫu vào bảng Category
INSERT INTO Category (CategoryName)
VALUES 
(N'Cơm'),
(N'Nước uống'),
(N'Snack'),
(N'Mì'),
(N'Kem');

-- Thêm dữ liệu mẫu vào bảng Menu
INSERT INTO Menu (CategoryID, FoodName, Price, Quantity)
VALUES 
(1, N'Cơm gà', 25000, 50),
(1, N'Cơm sườn', 25000, 50),
(1, N'Cơm trộn hàn quốc', 25000, 50),
(1, N'Cơm chiên trứng ốp la', 25000, 50),
(2, N'Sting', 15000, 70),
(2, N'Pepsi', 15000, 70),
(2, N'Sprite', 15000, 70),
(2, N'Coca cola', 15000, 70),
(3, N'Snack khoai tây', 10000, 60),
(3, N'Snack ngô', 10000, 60),
(3, N'Snack bí đỏ', 10000, 60),
(3, N'Snack cua', 10000, 60),
(4, N'Mì tương đen', 25000, 50),
(4, N'Mì ý', 25000, 50),
(4, N'Mì ly', 10000, 50),
(4, N'Mì trộn', 25000, 50),
(5, N'Kem vani', 20000, 40),
(5, N'Kem socola', 20000, 40),
(5, N'Kem matcha', 20000, 40),
(5, N'Kem dâu', 20000, 40);

-- Dữ liệu cho bảng Quanly
INSERT INTO Admin (Username, Password)
VALUES
('Admin', 123),
('Tín', 123),
('Quân',123)

-- Dữ liệu cho bảng ImportTable
INSERT INTO ImportTable (CustomerID, FoodID, CategoryID, Quantum, SumPrice ,ImportDate)
VALUES
(1,	5,	2 ,2, 30000, '2024-12-10 22:40:34.407'),
(2,	6,	2, 4, 30000, '2020-12-10 20:46:34.300'),
(2,	7,	2, 6, 30000, '2020-12-10 20:44:34.300'),
(1, 1, 1, 2, 50000, '2024-12-10 23:03:13.620'),
(1, 1, 1, 1, 25000, '2024-12-10 23:03:19.823'),
(1, 4, 1, 2, 50000, '2024-12-10 23:05:04.053'),
(1, 3, 1, 2, 50000, '2024-12-10 23:07:37.453'),
(1, 5, 2, 1, 15000, '2024-12-10 23:10:57.467'),
(1, 5, 2, 1, 15000, '2024-12-10 23:11:07.733'),
(1, 3, 1, 1, 25000, '2024-12-10 23:11:20.520'),
(1, 6, 2, 1, 15000, '2024-12-10 23:12:07.193'),
(1, 12, 3, 12, 12000, '2024-12-10 23:12:36.097')

-- Dữ liệu cho bảng Users
INSERT INTO Users (Username, Password, RandomKey)
VALUES
(N'Phuongzu', 0xD1890A6CF51695D9A45BA43FDCD10A0D, 1644),
(N'Kiet', 0x5EB5B769B9DF4A8E3FAEC8E90DEB2205, 9078),
(N'Minhtin', 0xADCF328C18AC264CFDEF4424F53F0F6A, 7385)

-- Dữ liệu cho bảng Messages
INSERT INTO Messages (Username, SentTime, Mess, Stas)
VALUES
('Phuongzu', '2024-12-14 09:00:00', N'Chuột liệt rồi ad ơi', N'Chưa xem'),
('Phuongzu', '2024-12-16 14:45:45', N'Có thằng hút thuốc ad ơi', N'Chưa xem'),
('Kiet', '2024-12-14 10:15:00', N'Mẹ em hỏi thì đừng khai nha', N'Chưa xem')

-- Trigger cập nhật CardID
GO
CREATE TRIGGER trg_UpdateCardID
ON Cards
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Users
    SET Users.CardID = inserted.CardID,
        Users.Point = 0
    FROM Users
    INNER JOIN inserted ON Users.UserID = inserted.UserID;
END;
-- DROP TRIGGER trg_UpdateCardID;

-- Trigger xóa Card
GO
CREATE TRIGGER trg_DeleteUserAndCard
ON Users
AFTER DELETE
AS
BEGIN
    -- Xóa thẻ (Card) liên quan đến tài khoản bị xóa
    DELETE FROM Cards
    WHERE UserID IN (SELECT UserID FROM deleted);
END;
-- DROP TRIGGER trg_DeleteUserAndCard

-- Dữ liệu cho bảng Cards
GO
INSERT INTO Cards (UserID, CardType, Stas,  Balance)
VALUES
(1, N'Thành viên' , N'Đang hoạt động', 0),
(2, N'VIP' , N'Đã khóa', 0),
(3, N'Thành viên' , N'Đang hoạt động', 0)

-- Trigger cập nhật tổng bill
GO
CREATE OR ALTER TRIGGER trg_HandleBillDetails
ON BillDetails
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    BEGIN TRANSACTION;

    -- Thêm hóa đơn mới nếu `BillID` không tồn tại
    INSERT INTO Bill (UserID, TotalAmount)
    SELECT DISTINCT i.UserID, 0
    FROM Inserted i
    LEFT JOIN Bill b ON i.UserID = b.UserID
    WHERE b.UserID IS NULL;

    -- Cập nhật tổng số tiền của hóa đơn
    UPDATE b
    SET b.TotalAmount = (
        SELECT ISNULL(SUM(bd.Price * bd.Quantity), 0)
        FROM BillDetails bd
        WHERE bd.BillID = b.BillID
    )
    FROM Bill b
    WHERE EXISTS (
        SELECT 1
        FROM Inserted i
        WHERE i.UserID = b.UserID
    );

    -- Xóa hóa đơn nếu không còn dòng chi tiết nào
    DELETE FROM Bill
    WHERE NOT EXISTS (
        SELECT 1
        FROM BillDetails bd
        WHERE bd.BillID = Bill.BillID
    );

    COMMIT TRANSACTION;
END;

--DROP TRIGGER trg_HandleBillDetails

-- Trigger xóa hóa đơn 
GO
CREATE OR ALTER TRIGGER trg_DeleteBill
ON BillDetails
AFTER DELETE
AS
BEGIN
    BEGIN TRANSACTION;

    -- Xóa hóa đơn nếu không còn món nào liên quan trong BillDetails
    DELETE FROM Bill
    WHERE BillID IN (
        SELECT DISTINCT d.BillID
        FROM Deleted d
        LEFT JOIN BillDetails bd ON d.BillID = bd.BillID
        WHERE bd.BillID IS NULL
    );

    COMMIT TRANSACTION;
END;
-- DROP TRIGGER trg_DeleteBill

-- Trigger cập nhập số lượng tồn kho theo bill
GO
CREATE TRIGGER trg_UpdateMenuQuantity
ON Bill
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Trường hợp trạng thái chuyển từ "Đang xử lý" sang "Hoàn thành"
    IF EXISTS (
        SELECT 1
        FROM inserted i
        LEFT JOIN deleted d ON i.BillID = d.BillID
        WHERE i.Status = N'Hoàn thành' -- Trạng thái hiện tại là "Hoàn thành"
          AND d.Status = N'Đang xử lý' -- Trạng thái cũ là "Đang xử lý"
    )
    BEGIN
        -- Giảm số lượng món ăn trong Menu
        UPDATE m
        SET m.Quantity = m.Quantity - bd.Quantity
        FROM Menu m
        INNER JOIN BillDetails bd ON m.FoodID = bd.FoodID
        INNER JOIN inserted i ON bd.BillID = i.BillID
        LEFT JOIN deleted d ON i.BillID = d.BillID
        WHERE i.Status = N'Hoàn thành'
          AND d.Status = N'Đang xử lý';
    END
END;
-- DROP TRIGGER trg_UpdateMenuQuantity

-- Thêm dữ liệu mẫu cho bảng Bill
GO
INSERT INTO Bill (UserID)
VALUES 
(1),
(2),
(3),
(1)

-- Thêm dữ liệu cho bảng BillDetails
GO
INSERT INTO BillDetails (BillID, UserID, FoodID, Quantity, Price)
VALUES 
-- Hóa đơn 1
(1, 1, 1, 2, 25000), 
(1, 1, 5, 1, 15000), 
-- Hóa đơn 2
(2, 2, 6, 2, 15000), 
(2, 2, 13, 1, 10000), 
-- Hóa đơn 3
(3, 3, 17, 3, 20000), 
(3, 3, 18, 2, 20000),
-- Hóa đơn 4
(4, 1, 1, 2, 25000), 
(4, 1, 5, 1, 15000);

--TRIGGER ngăn chặn thẻ khóa nạp vào
GO
CREATE TRIGGER Prevent_LockCards
ON Cards
FOR UPDATE
AS
BEGIN
    -- Kiểm tra nếu có bất kỳ bản ghi nào trong bảng inserted có thẻ bị khóa
    IF EXISTS (SELECT 1 FROM inserted i
               JOIN Cards c ON i.CardID = c.CardID
               WHERE c.Stas = 'Đã khóa')
    BEGIN
        -- Thông báo lỗi nếu cố gắng cập nhật thẻ bị khóa
        RAISERROR('Không thể cập nhật thông tin thẻ khi thẻ bị khóa!', 16, 1);
        ROLLBACK TRANSACTION; -- Hủy bỏ giao dịch
    END
END;
-- DROP TRIGGER Prevent_LockCards

-- Trigger xử lý khi cập nhật điểm và loại thẻ
GO
CREATE TRIGGER trg_UpdatePoints
ON Cards
AFTER UPDATE
AS
BEGIN
    DECLARE @UserID INT, @Balance DECIMAL(10, 3), @Points DECIMAL(10, 3);

    -- Lấy thông tin từ bảng inserted
    SELECT @UserID = UserID, @Balance = Balance FROM inserted;

    -- Cập nhật điểm tích lũy trong bảng Users
    UPDATE Users
    SET Point = (SELECT Balance / 10000 * 20 FROM Cards WHERE Cards.UserID = Users.UserID)
    FROM Users
    INNER JOIN Cards ON Users.UserID = Cards.UserID
END;
-- DROP TRIGGER trg_UpdatePoints

-- Trigeer cập nhật số lượng tồn kho
GO
CREATE TRIGGER trg_UpdateQuantum
ON ImportTable
AFTER INSERT
AS
BEGIN
    -- Bắt đầu transaction
    BEGIN TRANSACTION;

    -- Cập nhật số lượng tồn kho trong bảng Menu
    UPDATE Menu
    SET Quantity = Quantity + i.Quantum
    FROM Menu m
    INNER JOIN Inserted i ON m.FoodID = i.FoodID;

    -- Kết thúc transaction
    COMMIT TRANSACTION;
END;
-- DROP TRIGGER trg_UpdateQuantum