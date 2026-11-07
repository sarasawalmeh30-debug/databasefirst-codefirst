CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    NameC VARCHAR(50),
    DescriptionC VARCHAR(250)
);

CREATE TABLE Suppliers (
    Id INT PRIMARY KEY,
    NameS VARCHAR(50),
    Email VARCHAR(250),
    Phone VARCHAR(30)
);

CREATE TABLE Products (
    Id INT PRIMARY KEY,
    NameP VARCHAR(50),
    Price DECIMAL(10,3),
    Quantity INT,
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
    SupplierId INT FOREIGN KEY REFERENCES Suppliers(Id)
);

CREATE TABLE PurchaseOrders (
    Id INT PRIMARY KEY,
    OrderDate DATE,
    Statuss VARCHAR(50),
    SupplierId INT FOREIGN KEY REFERENCES Suppliers(Id)
);

CREATE TABLE PurchaseOrderItems (
    Id INT PRIMARY KEY,
    PurchaseOrderId INT FOREIGN KEY REFERENCES PurchaseOrders(Id),
    ProductId INT FOREIGN KEY REFERENCES Products(Id),
    Quantity INT,
    UnitPrice DECIMAL(10,3)
);