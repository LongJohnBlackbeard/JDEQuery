using FluentAssertions;
using JDE.Abstractions.Queries;
using JDE.Providers.Oracle;

namespace JDE.Tests;

public class OracleSqlDialectTests
{
    private readonly OracleSqlDialect _dialect;

    public OracleSqlDialectTests()
    {
        _dialect = new OracleSqlDialect();
    }

    [Fact]
    public void DialectName_ShouldBeOracle()
    {
        _dialect.DialectName.Should().Be("Oracle");
    }

    [Fact]
    public void ParameterPrefix_ShouldBeColon()
    {
        _dialect.ParameterPrefix.Should().Be(":");
    }

    [Fact]
    public void QuoteIdentifier_ShouldUseDoubleQuotes()
    {
        var result = _dialect.QuoteIdentifier("ABAN8");
        result.Should().Be("\"ABAN8\"");
    }

    [Fact]
    public void QuoteIdentifier_ShouldRemoveExistingQuotes()
    {
        var result = _dialect.QuoteIdentifier("\"ABAN8\"");
        result.Should().Be("\"ABAN8\"");
    }

    [Fact]
    public void FormatParameterName_ShouldAddColonPrefix()
    {
        var result = _dialect.FormatParameterName("p0");
        result.Should().Be(":p0");
    }

    [Fact]
    public void FormatParameterName_ShouldRemoveExistingPrefix()
    {
        var result = _dialect.FormatParameterName(":p0");
        result.Should().Be(":p0");
    }

    [Fact]
    public void BuildSelectSql_WithNoColumns_ShouldSelectAll()
    {
        var sql = _dialect.BuildSelectSql(null, "F0101", "DV920");
        sql.Should().Be("SELECT * FROM \"DV920\".\"F0101\"");
    }

    [Fact]
    public void BuildSelectSql_WithColumns_ShouldSelectSpecifiedColumns()
    {
        var columns = new[] { "ABAN8", "ABALPH", "ABAT1" };
        var sql = _dialect.BuildSelectSql(columns, "F0101", "DV920");
        sql.Should().Be("SELECT \"ABAN8\", \"ABALPH\", \"ABAT1\" FROM \"DV920\".\"F0101\"");
    }

    [Fact]
    public void BuildSelectSql_WithoutSchema_ShouldNotIncludeSchema()
    {
        var sql = _dialect.BuildSelectSql(null, "F0101");
        sql.Should().Be("SELECT * FROM \"F0101\"");
    }

    [Fact]
    public void BuildSelectSql_WithWhereClause_ShouldIncludeWhere()
    {
        var sql = _dialect.BuildSelectSql(null, "F0101", "DV920", "\"ABAN8\" = :p0");
        sql.Should().Be("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABAN8\" = :p0");
    }

    [Fact]
    public void ApplyPagination_WithTakeOnly_ShouldUseFetchNext()
    {
        var baseSql = "SELECT * FROM \"F0101\"";
        var result = _dialect.ApplyPagination(baseSql, null, 100);
        result.Should().Be("SELECT * FROM \"F0101\" OFFSET 0 ROWS FETCH NEXT 100 ROWS ONLY");
    }

    [Fact]
    public void ApplyPagination_WithSkipAndTake_ShouldUseOffsetFetch()
    {
        var baseSql = "SELECT * FROM \"F0101\"";
        var result = _dialect.ApplyPagination(baseSql, 50, 100);
        result.Should().Be("SELECT * FROM \"F0101\" OFFSET 50 ROWS FETCH NEXT 100 ROWS ONLY");
    }

    [Fact]
    public void ApplyPagination_WithSkipOnly_ShouldUseOffsetWithoutFetch()
    {
        var baseSql = "SELECT * FROM \"F0101\"";
        var result = _dialect.ApplyPagination(baseSql, 50, null);
        result.Should().Be("SELECT * FROM \"F0101\" OFFSET 50 ROWS");
    }

    [Fact]
    public void ApplyPagination_WithNoPagination_ShouldReturnOriginalSql()
    {
        var baseSql = "SELECT * FROM \"F0101\"";
        var result = _dialect.ApplyPagination(baseSql, null, null);
        result.Should().Be(baseSql);
    }

    [Fact]
    public void BuildWhereClause_WithEqualOperator_ShouldGenerateEqualCondition()
    {
        var conditions = new[]
        {
            new WhereCondition("ABAN8", WhereOperator.Equal, 1001)
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABAN8\" = :p0");
    }

    [Fact]
    public void BuildWhereClause_WithGreaterThanOperator_ShouldGenerateGTCondition()
    {
        var conditions = new[]
        {
            new WhereCondition("ABAN8", WhereOperator.GreaterThan, 1000)
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABAN8\" > :p0");
    }

    [Fact]
    public void BuildWhereClause_WithLessThanOperator_ShouldGenerateLTCondition()
    {
        var conditions = new[]
        {
            new WhereCondition("ABAN8", WhereOperator.LessThan, 5000)
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABAN8\" < :p0");
    }

    [Fact]
    public void BuildWhereClause_WithGreaterThanOrEqualOperator_ShouldGenerateGTECondition()
    {
        var conditions = new[]
        {
            new WhereCondition("ABAN8", WhereOperator.GreaterThanOrEqual, 1000)
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABAN8\" >= :p0");
    }

    [Fact]
    public void BuildWhereClause_WithLessThanOrEqualOperator_ShouldGenerateLTECondition()
    {
        var conditions = new[]
        {
            new WhereCondition("ABAN8", WhereOperator.LessThanOrEqual, 5000)
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABAN8\" <= :p0");
    }

    [Fact]
    public void BuildWhereClause_WithNotEqualOperator_ShouldGenerateNotEqualCondition()
    {
        var conditions = new[]
        {
            new WhereCondition("ABAT1", WhereOperator.NotEqual, "C")
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABAT1\" <> :p0");
    }

    [Fact]
    public void BuildWhereClause_WithLikeOperator_ShouldGenerateLikeCondition()
    {
        var conditions = new[]
        {
            new WhereCondition("ABALPH", WhereOperator.Like, "ACME%")
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABALPH\" LIKE :p0");
    }

    [Fact]
    public void BuildWhereClause_WithTrimmedEqualOperator_ShouldGenerateTrimCondition()
    {
        var conditions = new[]
        {
            new WhereCondition("ABALPH", WhereOperator.TrimmedEqual, "ACME CORP")
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("TRIM(\"ABALPH\") = :p0");
    }

    [Fact]
    public void BuildWhereClause_WithNullValue_ShouldGenerateIsNull()
    {
        var conditions = new[]
        {
            new WhereCondition("ABALPH", WhereOperator.Equal, null)
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABALPH\" IS NULL");
    }

    [Fact]
    public void BuildWhereClause_WithNotEqualNull_ShouldGenerateIsNotNull()
    {
        var conditions = new[]
        {
            new WhereCondition("ABALPH", WhereOperator.NotEqual, null)
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABALPH\" IS NOT NULL");
    }

    [Fact]
    public void BuildWhereClause_WithMultipleConditions_ShouldJoinWithAND()
    {
        var conditions = new[]
        {
            new WhereCondition("ABAT1", WhereOperator.Equal, "C"),
            new WhereCondition("ABAN8", WhereOperator.GreaterThan, 1000)
        };

        var result = _dialect.BuildWhereClause(conditions);
        result.Should().Be("\"ABAT1\" = :p0 AND \"ABAN8\" > :p1");
    }

    [Fact]
    public void BuildWhereClause_WithEmptyConditions_ShouldReturnEmpty()
    {
        var conditions = Array.Empty<WhereCondition>();
        var result = _dialect.BuildWhereClause(conditions);
        result.Should().BeEmpty();
    }

    [Fact]
    public void BuildWhereClause_WithDictionary_ShouldGenerateEqualConditions()
    {
        var filters = new Dictionary<string, object?>
        {
            { "ABAN8", 1001 },
            { "ABAT1", "C" }
        };

        var result = _dialect.BuildWhereClause(filters);
        result.Should().Contain("\"ABAN8\" = :p");
        result.Should().Contain("\"ABAT1\" = :p");
        result.Should().Contain(" AND ");
    }
}
