namespace Dapper.Contracts;

public record ProductRequest
(
    string? Name,
    string? Description,
    string? Barcode,
    decimal Rate,
    DateTime AddedOn,
    DateTime ModifiedOn
);