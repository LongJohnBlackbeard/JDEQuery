using FluentAssertions;
using JDE.Abstractions;
using JDE.Abstractions.Configuration;
using JDE.Abstractions.Queries;
using JDE.Core.Queries;
using Moq;

namespace JDE.Tests;

public class QueryBuilderTests
{
    private readonly Mock<ISqlDialect> _mockDialect;
    private readonly Mock<IDbProvider> _mockProvider;
    private readonly Mock<IJdeConfiguration> _mockConfig;

    public QueryBuilderTests()
    {
        _mockDialect = new Mock<ISqlDialect>();
        _mockProvider = new Mock<IDbProvider>();
        _mockConfig = new Mock<IJdeConfiguration>();

        _mockConfig.Setup(c => c.Schema).Returns("DV920");
        _mockDialect.Setup(d => d.ParameterPrefix).Returns(":");
    }

    [Fact]
    public void SelectFields_WithParamsArray_ShouldStoreFields()
    {
        var builder = CreateBuilder();

        var result = builder.SelectFields("ABAN8", "ABALPH", "ABAT1");

        result.Should().BeSameAs(builder);
    }

    [Fact]
    public void SelectFields_WithEmptyArray_ShouldThrowException()
    {
        var builder = CreateBuilder();

        var act = () => builder.SelectFields(Array.Empty<string>());

        act.Should().Throw<ArgumentException>()
            .WithMessage("At least one field must be specified.*");
    }

    [Fact]
    public void Where_WithSingleCondition_ShouldAddEqualCondition()
    {
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns<IEnumerable<WhereCondition>>(conditions =>
            {
                var condList = conditions.ToList();
                condList.Should().HaveCount(1);
                condList[0].FieldName.Should().Be("ABAN8");
                condList[0].Operator.Should().Be(WhereOperator.Equal);
                condList[0].Value.Should().Be(1001);
                return "\"ABAN8\" = :p0";
            });

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                "\"ABAN8\" = :p0"))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABAN8\" = :p0");

        var builder = CreateBuilder();
        var query = builder.Where("ABAN8", 1001).Build();

        query.Sql.Should().Contain("ABAN8");
    }

    [Fact]
    public void WhereGreaterThan_ShouldAddGreaterThanCondition()
    {
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns<IEnumerable<WhereCondition>>(conditions =>
            {
                var condList = conditions.ToList();
                condList[0].Operator.Should().Be(WhereOperator.GreaterThan);
                return "\"ABAN8\" > :p0";
            });

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABAN8\" > :p0");

        var builder = CreateBuilder();
        var query = builder.WhereGreaterThan("ABAN8", 1000).Build();

        query.Should().NotBeNull();
    }

    [Fact]
    public void WhereLessThan_ShouldAddLessThanCondition()
    {
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns<IEnumerable<WhereCondition>>(conditions =>
            {
                var condList = conditions.ToList();
                condList[0].Operator.Should().Be(WhereOperator.LessThan);
                return "\"ABAN8\" < :p0";
            });

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABAN8\" < :p0");

        var builder = CreateBuilder();
        var query = builder.WhereLessThan("ABAN8", 5000).Build();

        query.Should().NotBeNull();
    }

    [Fact]
    public void WhereNotEqual_ShouldAddNotEqualCondition()
    {
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns<IEnumerable<WhereCondition>>(conditions =>
            {
                var condList = conditions.ToList();
                condList[0].Operator.Should().Be(WhereOperator.NotEqual);
                return "\"ABAT1\" <> :p0";
            });

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABAT1\" <> :p0");

        var builder = CreateBuilder();
        var query = builder.WhereNotEqual("ABAT1", "C").Build();

        query.Should().NotBeNull();
    }

    [Fact]
    public void WhereLike_ShouldAddLikeCondition()
    {
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns<IEnumerable<WhereCondition>>(conditions =>
            {
                var condList = conditions.ToList();
                condList[0].Operator.Should().Be(WhereOperator.Like);
                condList[0].Value.Should().Be("ACME%");
                return "\"ABALPH\" LIKE :p0";
            });

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABALPH\" LIKE :p0");

        var builder = CreateBuilder();
        var query = builder.WhereLike("ABALPH", "ACME%").Build();

        query.Should().NotBeNull();
    }

    [Fact]
    public void WhereTrimmedEqual_ShouldAddTrimmedEqualCondition()
    {
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns<IEnumerable<WhereCondition>>(conditions =>
            {
                var condList = conditions.ToList();
                condList[0].Operator.Should().Be(WhereOperator.TrimmedEqual);
                condList[0].Value.Should().Be("ACME CORP");
                return "TRIM(\"ABALPH\") = :p0";
            });

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE TRIM(\"ABALPH\") = :p0");

        var builder = CreateBuilder();
        var query = builder.WhereTrimmedEqual("ABALPH", "ACME CORP").Build();

        query.Should().NotBeNull();
    }

    [Fact]
    public void WhereTrimmedEqual_ShouldAutomaticallyTrimUserInput()
    {
        // Test that padded input from the user is automatically trimmed
        // This handles the case where users copy values directly from the database
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns<IEnumerable<WhereCondition>>(conditions =>
            {
                var condList = conditions.ToList();
                condList[0].Operator.Should().Be(WhereOperator.TrimmedEqual);
                // The value should be trimmed automatically
                condList[0].Value.Should().Be("ACME CORP");
                return "TRIM(\"ABALPH\") = :p0";
            });

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE TRIM(\"ABALPH\") = :p0");

        var builder = CreateBuilder();
        // Pass a padded value (as if copied from the database)
        var query = builder.WhereTrimmedEqual("ABALPH", "ACME CORP                    ").Build();

        query.Should().NotBeNull();
    }

    [Fact]
    public void MultipleWhere_ShouldChainConditions()
    {
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns<IEnumerable<WhereCondition>>(conditions =>
            {
                var condList = conditions.ToList();
                condList.Should().HaveCount(2);
                condList[0].FieldName.Should().Be("ABAT1");
                condList[1].FieldName.Should().Be("ABAN8");
                return "\"ABAT1\" = :p0 AND \"ABAN8\" > :p1";
            });

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABAT1\" = :p0 AND \"ABAN8\" > :p1");

        var builder = CreateBuilder();
        var query = builder
            .Where("ABAT1", "C")
            .WhereGreaterThan("ABAN8", 1000)
            .Build();

        query.Should().NotBeNull();
    }

    [Fact]
    public void Skip_WithNegativeValue_ShouldThrowException()
    {
        var builder = CreateBuilder();

        var act = () => builder.Skip(-1);

        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Skip count cannot be negative.*");
    }

    [Fact]
    public void Take_WithZeroOrNegative_ShouldThrowException()
    {
        var builder = CreateBuilder();

        var act = () => builder.Take(0);

        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Take count must be greater than 0.*");
    }

    [Fact]
    public void Skip_AndTake_ShouldApplyPagination()
    {
        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                null))
            .Returns("SELECT * FROM \"DV920\".\"F0101\"");

        _mockDialect.Setup(d => d.ApplyPagination(
                "SELECT * FROM \"DV920\".\"F0101\"",
                50,
                100))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" OFFSET 50 ROWS FETCH NEXT 100 ROWS ONLY");

        var builder = CreateBuilder();
        var query = builder.Skip(50).Take(100).Build();

        query.Sql.Should().Contain("OFFSET");
        query.Sql.Should().Contain("FETCH NEXT");
    }

    [Fact]
    public void Build_ShouldCreateParametersFromConditions()
    {
        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns("\"ABAN8\" = :p0");

        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABAN8\" = :p0");

        var builder = CreateBuilder();
        var query = builder.Where("ABAN8", 1001).Build();

        query.Parameters.Should().NotBeNull();
        var paramDict = query.Parameters as IDictionary<string, object?>;
        paramDict.Should().ContainKey("p0");
        paramDict!["p0"].Should().Be(1001);
    }

    [Fact]
    public void Build_WithNoConditions_ShouldHaveNullParameters()
    {
        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                null))
            .Returns("SELECT * FROM \"DV920\".\"F0101\"");

        var builder = CreateBuilder();
        var query = builder.Build();

        query.Parameters.Should().BeNull();
    }

    [Fact]
    public async Task FetchSingleAsync_ShouldCallDbProvider()
    {
        _mockDialect.Setup(d => d.BuildSelectSql(
                It.IsAny<IEnumerable<string>>(),
                "F0101",
                "DV920",
                It.IsAny<string>()))
            .Returns("SELECT * FROM \"DV920\".\"F0101\" WHERE \"ABAN8\" = :p0");

        _mockDialect.Setup(d => d.BuildWhereClause(It.IsAny<IEnumerable<WhereCondition>>()))
            .Returns("\"ABAN8\" = :p0");

        _mockProvider.Setup(p => p.QuerySingleOrDefaultAsync<TestModel>(
                It.IsAny<string>(),
                It.IsAny<object>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new TestModel { Id = 1001 });

        var builder = CreateBuilder();
        var result = await builder.Where("ABAN8", 1001).FetchSingleAsync();

        result.Should().NotBeNull();
        result!.Id.Should().Be(1001);
        _mockProvider.Verify(p => p.QuerySingleOrDefaultAsync<TestModel>(
            It.IsAny<string>(),
            It.IsAny<object>(),
            It.IsAny<CancellationToken>()), Times.Once);
    }

    private QueryBuilder<T> CreateBuilder<T>()
    {
        return new QueryBuilder<T>(
            "F0101",
            _mockDialect.Object,
            _mockProvider.Object,
            _mockConfig.Object);
    }

    private QueryBuilder<TestModel> CreateBuilder()
    {
        return CreateBuilder<TestModel>();
    }

    private class TestModel
    {
        public int Id { get; set; }
    }
}
