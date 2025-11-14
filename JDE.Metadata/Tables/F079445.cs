using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F079445 - .
/// </summary>
public class F079445 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHAN8.
        /// </summary>
        public const string PHAN8 = "PHAN8";

        /// <summary>
        /// PHPWPDBA.
        /// </summary>
        public const string PHPWPDBA = "PHPWPDBA";

        /// <summary>
        /// PHPDBA.
        /// </summary>
        public const string PHPDBA = "PHPDBA";

        /// <summary>
        /// PHPRTR.
        /// </summary>
        public const string PHPRTR = "PHPRTR";

        /// <summary>
        /// PHDWK.
        /// </summary>
        public const string PHDWK = "PHDWK";

        /// <summary>
        /// PHPWFRT.
        /// </summary>
        public const string PHPWFRT = "PHPWFRT";

        /// <summary>
        /// PHPWAR.
        /// </summary>
        public const string PHPWAR = "PHPWAR";

        /// <summary>
        /// PHPWHR.
        /// </summary>
        public const string PHPWHR = "PHPWHR";

        /// <summary>
        /// PHPWMULT.
        /// </summary>
        public const string PHPWMULT = "PHPWMULT";

        /// <summary>
        /// PHCKCN.
        /// </summary>
        public const string PHCKCN = "PHCKCN";

        /// <summary>
        /// PHPWCH05.
        /// </summary>
        public const string PHPWCH05 = "PHPWCH05";

        /// <summary>
        /// PHPWCH06.
        /// </summary>
        public const string PHPWCH06 = "PHPWCH06";

        /// <summary>
        /// PHPWCH07.
        /// </summary>
        public const string PHPWCH07 = "PHPWCH07";

        /// <summary>
        /// PHPWJD05.
        /// </summary>
        public const string PHPWJD05 = "PHPWJD05";

        /// <summary>
        /// PHPWJD06.
        /// </summary>
        public const string PHPWJD06 = "PHPWJD06";

        /// <summary>
        /// PHPWJD07.
        /// </summary>
        public const string PHPWJD07 = "PHPWJD07";

        /// <summary>
        /// PHPWST05.
        /// </summary>
        public const string PHPWST05 = "PHPWST05";

        /// <summary>
        /// PHPWST06.
        /// </summary>
        public const string PHPWST06 = "PHPWST06";

        /// <summary>
        /// PHPWST07.
        /// </summary>
        public const string PHPWST07 = "PHPWST07";

        /// <summary>
        /// PHPWMN05.
        /// </summary>
        public const string PHPWMN05 = "PHPWMN05";

        /// <summary>
        /// PHPWMN06.
        /// </summary>
        public const string PHPWMN06 = "PHPWMN06";

        /// <summary>
        /// PHPWMN07.
        /// </summary>
        public const string PHPWMN07 = "PHPWMN07";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F079445";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHAN8", "PHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PHPWPDBA", "PHPWPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("PHPDBA", "PHPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("PHPRTR", "PHPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("PHDWK", "PHDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("PHPWFRT", "PHPWFRT", JdeDataType.Numeric),
        new JdeField("PHPWAR", "PHPWAR", JdeDataType.String, 2),
        new JdeField("PHPWHR", "PHPWHR", JdeDataType.Numeric),
        new JdeField("PHPWMULT", "PHPWMULT", JdeDataType.Numeric),
        new JdeField("PHCKCN", "PHCKCN", JdeDataType.Numeric),
        new JdeField("PHPWCH05", "PHPWCH05", JdeDataType.String, 2),
        new JdeField("PHPWCH06", "PHPWCH06", JdeDataType.String, 2),
        new JdeField("PHPWCH07", "PHPWCH07", JdeDataType.String, 2),
        new JdeField("PHPWJD05", "PHPWJD05", JdeDataType.Numeric),
        new JdeField("PHPWJD06", "PHPWJD06", JdeDataType.Numeric),
        new JdeField("PHPWJD07", "PHPWJD07", JdeDataType.Numeric),
        new JdeField("PHPWST05", "PHPWST05", JdeDataType.String, 40),
        new JdeField("PHPWST06", "PHPWST06", JdeDataType.String, 40),
        new JdeField("PHPWST07", "PHPWST07", JdeDataType.String, 80),
        new JdeField("PHPWMN05", "PHPWMN05", JdeDataType.Numeric),
        new JdeField("PHPWMN06", "PHPWMN06", JdeDataType.Numeric),
        new JdeField("PHPWMN07", "PHPWMN07", JdeDataType.Numeric),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F079445_0", "Primary Key on PHAN8, PHPWPDBA, PHPDBA, PHPRTR, PHDWK", new[] { "PHAN8", "PHPWPDBA", "PHPDBA", "PHPRTR", "PHDWK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F079445_2", "Index on PHAN8, PHCKCN", new[] { "PHAN8", "PHCKCN" })
    };
}
