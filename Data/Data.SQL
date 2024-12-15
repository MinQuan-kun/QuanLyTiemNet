CREATE DATABASE QLTiemNet
-- DROP DATABASE QLTiemNet
-- DROP TABLE Users
-- DROP TABLE Menu
-- DROP TABLE Category
-- DROP TABLE Computers
-- DROP TABLE Cards
-- DROP TABLE Status
-- DROP TABLE Bill
-- DROP TABLE BillDetails
-- DROP TABLE ImportTable
Use QLTiemNet
GO

-- Bảng Admin
CREATE TABLE Admin(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(MAX) NOT NULL,
    Role BIT
)
-- Bảng Users
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARBINARY(MAX) NOT NULL,
    RandomKey VARCHAR(50),
    CardID INT,
    Point DECIMAL(10, 2) DEFAULT 0.00
);

-- Bảng thẻ
CREATE TABLE Cards (
    CardID INT PRIMARY KEY IDENTITY(1,1),  
    UserID INT,
    CardType NVARCHAR(500) CHECK (CardType IN (N'VIP', N'Thành viên')) NOT NULL,
    Stas NVARCHAR(500) CHECK (Stas IN (N'đang hoạt động', N'Đã khóa')),
    Balance DECIMAL(10, 2) DEFAULT 0.0
);

-- Bảng máy
CREATE TABLE Computers (
    ComputerID INT PRIMARY KEY IDENTITY(1,1),  
    ComputerName NVARCHAR(500) NOT NULL UNIQUE,
    Phankhuc NVARCHAR(500) CHECK (Phankhuc IN (N'Gaming', N'Tiêu chuẩn', N'VIP')) NOT NULL,
    Stas NVARCHAR(500) CHECK (Stas IN (N'Online', N'Bảo trì', N'Offline')) NOT NULL
);
-- Bảng menu
CREATE TABLE Menu (
    FoodID INT PRIMARY KEY IDENTITY(1,1),  
    CategoryID INT,
    FoodName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    Image Image,
    Notes TEXT
);
-- Bảng hóa đơn
CREATE TABLE Bill (
    BillID INT PRIMARY KEY IDENTITY(1,1),  
    UserID INT NOT NULL,
    TotalAmount DECIMAL(10, 2) DEFAULT 0.0, -- Tổng số tiền của hóa đơn
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
    Price DECIMAL(10, 2) NOT NULL,
    TotalPrice AS (Quantity * Price) PERSISTED,
    FOREIGN KEY (BillID) REFERENCES Bill(BillID) ON DELETE CASCADE,
    FOREIGN KEY (FoodID) REFERENCES Menu(FoodID) ON DELETE NO ACTION,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE NO ACTION
);

-- Bảng thẻ loại
CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1), 
    CategoryName NVARCHAR(500) UNIQUE
);
-- Bảng trạng thái
CREATE TABLE Status (
    StationID INT PRIMARY KEY IDENTITY(1,1),  
    ComputerID INT,
    Stas NVARCHAR(500) CHECK (Stas IN (N'Online', N'Bảo trì', N'Offline')) NOT NULL,
    CurrentUserID INT,
    StartTime DATETIME,
    RemainingTime INT,
    Notes TEXT,
    FOREIGN KEY (CurrentUserID) REFERENCES Users(UserID) ON DELETE SET NULL
);

-- Bảng nhập hàng
CREATE TABLE ImportTable (
    ImportID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    FoodID INT NOT NULL,
    CategoryID INT NOT NULL,
    Quantum INT NOT NULL DEFAULT 0,
    SumPrice DECIMAL(10, 2) NOT NULL DEFAULT 0.00,
    ImportDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CustomerID) REFERENCES Admin(ID),
    FOREIGN KEY (FoodID) REFERENCES Menu(FoodID),
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);

GO
-- Xử lý khóa ngoại cho bảng `user`
ALTER TABLE Users
    ADD CONSTRAINT FK_Card FOREIGN KEY (CardID) REFERENCES Cards(CardID);

-- Xử lý khóa ngoại cho bảng `Status`
ALTER TABLE Status
    ADD CONSTRAINT FK_Computer FOREIGN KEY (ComputerID) REFERENCES Computers(ComputerID);

-- Xử lý khóa ngoại cho bảng `Menu`
ALTER TABLE Menu
    ADD CONSTRAINT FK_Category FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID);


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
(1, N'Cơm gà', 25.000, 50),
(1, N'Cơm sườn', 25.000, 50),
(1, N'Cơm trộn hàn quốc', 25.000, 50),
(1, N'Cơm chiên trứng ốp la', 25.000, 50),
(2, N'Sting', 15.000, 70),
(2, N'Pepsi', 15.000, 70),
(2, N'Sprite', 15.000, 70),
(2, N'Coca cola', 15.000, 70),
(3, N'Snack khoai tây', 10.000, 60),
(3, N'Snack ngô', 10.000, 60),
(3, N'Snack bí đỏ', 10.000, 60),
(3, N'Snack cua', 10.000, 60),
(4, N'Mì tương đen', 25.000, 50),
(4, N'Mì ý', 25.000, 50),
(4, N'Mì ly', 10.000, 50),
(4, N'Mì trộn', 25.000, 50),
(5, N'Kem vani', 20.000, 40),
(5, N'Kem socola', 20.000, 40),
(5, N'Kem matcha', 20.000, 40),
(5, N'Kem dâu', 20.000, 40);

-- Dữ liệu cho bảng Computers
INSERT INTO Computers (ComputerName, Phankhuc, Stas)
VALUES
('Comp01', N'VIP', 'Offline'),
('Comp02', N'VIP', 'Offline'),
('Comp03', N'VIP', 'Offline'),
('Comp04', N'Gaming', 'Offline'),
('Comp05', N'Tiêu chuẩn', 'Offline'),
('Comp06', N'VIP', 'Offline'),
('Comp07', N'Gaming', 'Offline');

-- Dữ liệu cho bảng Quanly
INSERT INTO Admin (Username, Password, Role)
VALUES
('Admin', 123, 0),
('Tín', 123, 1),
('Quân',123, 1)

-- Dữ liệu cho bảng ImportTable
INSERT INTO ImportTable (CustomerID, FoodID, CategoryID, Quantum, SumPrice ,ImportDate)
VALUES
(1,	5,	2 ,2, 30000.00, '2024-12-10 22:40:34.407'),
(2,	6,	2, 4, 30000.00, '2020-12-10 20:46:34.300'),
(2,	7,	2, 6, 30000.00,	'2020-12-10 20:44:34.300'),
(1, 1, 1, 2, 50.00, '2024-12-10 23:03:13.620'),
(1, 1, 1, 1, 25.00, '2024-12-10 23:03:19.823'),
(1, 4, 1, 2, 50.00, '2024-12-10 23:05:04.053'),
(1, 3, 1, 2, 50.00, '2024-12-10 23:07:37.453'),
(1, 5, 2, 1, 15.00, '2024-12-10 23:10:57.467'),
(1, 5, 2, 1, 15.00, '2024-12-10 23:11:07.733'),
(1, 3, 1, 1, 25.00, '2024-12-10 23:11:20.520'),
(1, 6, 2, 1, 15.00, '2024-12-10 23:12:07.193'),
(1, 17, 5, 0, 0.00, '2024-12-10 23:12:17.797'),
(1, 18, 5, 0, 0.00, '2024-12-10 23:12:17.797'),
(1, 19, 5, 0, 0.00, '2024-12-10 23:12:17.800'),
(1, 20, 5, 0, 0.00, '2024-12-10 23:12:17.803'),
(1, 12, 3, 12, 120.00, '2024-12-10 23:12:36.097')

-- Dữ liệu cho bảng Users
INSERT INTO Users (Username, Password, RandomKey)
VALUES
(N'Phuongzu', 0xD1890A6CF51695D9A45BA43FDCD10A0D, 1644),
(N'Kiet', 0x5EB5B769B9DF4A8E3FAEC8E90DEB2205, 9078),
(N'Minhtin', 0xADCF328C18AC264CFDEF4424F53F0F6A, 7385)

-- Trigger cập nhật CardID
GO
CREATE TRIGGER trg_UpdateCardID
ON Cards
AFTER INSERT
AS
BEGIN
    -- Cập nhật CardID trong bảng Users
    UPDATE Users
    SET CardID = inserted.CardID
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
(1, N'Thành viên' , N'Đang hoạt động', 0.00),
(2, N'VIP' , N'Đã khóa', 0.00),
(3, N'Thành viên' , N'Đang hoạt động', 0.00)

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


GO
INSERT INTO BillDetails (BillID, UserID, FoodID, Quantity, Price)
VALUES 
-- Hóa đơn 1
(1, 1, 1, 2, 25.000), 
(1, 1, 5, 1, 15.000), 
-- Hóa đơn 2
(2, 2, 6, 2, 15.000), 
(2, 2, 13, 1, 10.000), 
-- Hóa đơn 3
(3, 3, 17, 3, 20.000), 
(3, 3, 18, 2, 20.000),
-- Hóa đơn 4
(4, 1, 1, 2, 25.000), 
(4, 1, 5, 1, 15.000);

--Truy xuất tài khoản
GO
CREATE PROC GetAccoount
@username NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Users WHERE Username = @username
END 
-- DROP PROC GetAccount;

--Truy xuất đăng nhập
GO
CREATE PROC Go_Login
@username NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Users WHERE Username = @username AND Password = @password
END
-- DROP PROC Go_Login;

--Truy xuất danh mục 
GO
CREATE PROC GetMenu
@Category NVARCHAR(500)
AS 
BEGIN
    SELECT * 
    FROM Menu M
    JOIN Category CT ON CT.CategoryID = M.CategoryID
    WHERE CT.CategoryName = @Category
END
-- DROP PROC GetMenu;

--Truy vấn món ăn
GO
CREATE PROC GetFood
@Name NVARCHAR(500)
AS
BEGIN 
    SELECT *
    FROM Menu
    WHERE FoodName = @Name
END
-- DROP PROC GetFood;

--Tạo trigger thay đổi số tiền trong ví
GO
CREATE TRIGGER Up_Money
ON Bill
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON; -- Bỏ thông báo ảnh hưởng của trigger

    -- Trừ tiền khi thêm hóa đơn mới
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE Cards
        SET Balance = Balance - i.TotalAmount
        FROM Cards w
        INNER JOIN inserted i ON w.UserID = i.UserID
        WHERE w.Stas = N'Đang hoạt động';
    END

    -- Hoàn tiền khi xóa hóa đơn
    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        UPDATE Cards
        SET Balance = Balance + d.TotalAmount
        FROM Cards w
        INNER JOIN deleted d ON w.UserID = d.UserID
        WHERE w.Stas = N'Đang hoạt động';
    END

    -- Cập nhật tiền khi sửa hóa đơn (UPDATE)
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        UPDATE Cards
        SET Balance = Balance - i.TotalAmount + d.TotalAmount
        FROM Cards w
        INNER JOIN inserted i ON w.UserID = i.UserID
        INNER JOIN deleted d ON w.UserID = d.UserID
        WHERE w.Stas = N'Đang hoạt động';
    END
END
GO
-- DROP TRIGGER Up_Money;

--TRIGGER ngăn chặn thẻ khóa nạp vào
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
    DECLARE @UserID INT, @Balance DECIMAL(10, 2), @Points DECIMAL(10, 2);

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

GO
DECLARE @ImageData VARBINARY(MAX);
--Ảnh lấy từ Resources thế vào chỗ C:user

-- Cập nhật ảnh cho món ăn "Cơm gà"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Comga.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Cơm gà';

-- Cập nhật ảnh cho món ăn "Cơm sườn"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Comsuon.PNG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Cơm sườn';

-- Cập nhật ảnh cho món ăn "Cơm trộn hàn quốc"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\ComtronHanquoc.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Cơm trộn hàn quốc';

-- Cập nhật ảnh cho món ăn "Cơm chiên trứng ốp la"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Comchientrungopla.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Cơm chiên trứng ốp la';

-- Cập nhật ảnh cho món ăn "Sting"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Sting.PNG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Sting';

-- Cập nhật ảnh cho món ăn "Pepsi"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Pepsi.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Pepsi';

-- Cập nhật ảnh cho món ăn "Sprite"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Sprite.PNG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Sprite';

-- Cập nhật ảnh cho món ăn "Coca cola"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Cocacola.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Coca cola';

-- Cập nhật ảnh cho món ăn "Snack khoai tây"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Snackkhoaitay.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Snack khoai tây';

-- Cập nhật ảnh cho món ăn "Snack ngô"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Snackngo.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Snack ngô';

-- Cập nhật ảnh cho món ăn "Snack bí đỏ"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Snackbido.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Snack bí đỏ';

-- Cập nhật ảnh cho món ăn "Snack cua"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Snackcua.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Snack cua';

-- Cập nhật ảnh cho món ăn "Mì tương đen"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Mituongden.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Mì tương đen';

-- Cập nhật ảnh cho món ăn "Mì ý"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Miy.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Mì ý';

-- Cập nhật ảnh cho món ăn "Mì ly"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Mily.PNG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Mì ly';

-- Cập nhật ảnh cho món ăn "Mì trộn"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Mitron.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Mì trộn';

-- Cập nhật ảnh cho món ăn "Kem vani"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Kemvani.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Kem vani';

-- Cập nhật ảnh cho món ăn "Kem socola"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Kemsocola.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Kem socola';

-- Cập nhật ảnh cho món ăn "Kem dâu"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Kemdau.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Kem dâu';

-- Cập nhật ảnh cho món ăn "Kem matcha"
-- Đọc ảnh từ file vào biến @ImageData
SELECT @ImageData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ASUS\Pictures\Món ăn\Kemmatcha.JPG', SINGLE_BLOB) AS img;

-- Cập nhật ảnh vào bảng Menu
UPDATE Menu
SET Image = @ImageData
WHERE FoodName = N'Kem matcha';