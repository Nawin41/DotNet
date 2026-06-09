

CREATE PROCEDURE GetCustomersByCountry
    @Country NVARCHAR(50)
AS
BEGIN
    SELECT CustomerID, CompanyName, Country
    FROM Customers
    WHERE Country = @Country
END

