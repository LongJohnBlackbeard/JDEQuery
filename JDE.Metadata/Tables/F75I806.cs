using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I806 - .
/// </summary>
public class F75I806 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HSI75CATTY.
        /// </summary>
        public const string HSI75CATTY = "HSI75CATTY";

        /// <summary>
        /// HSI75CATCO.
        /// </summary>
        public const string HSI75CATCO = "HSI75CATCO";

        /// <summary>
        /// HSI75CATVL.
        /// </summary>
        public const string HSI75CATVL = "HSI75CATVL";

        /// <summary>
        /// HSI75CATDS.
        /// </summary>
        public const string HSI75CATDS = "HSI75CATDS";

        /// <summary>
        /// HSI75GSTRA.
        /// </summary>
        public const string HSI75GSTRA = "HSI75GSTRA";

        /// <summary>
        /// HSUSER.
        /// </summary>
        public const string HSUSER = "HSUSER";

        /// <summary>
        /// HSPID.
        /// </summary>
        public const string HSPID = "HSPID";

        /// <summary>
        /// HSJOBN.
        /// </summary>
        public const string HSJOBN = "HSJOBN";

        /// <summary>
        /// HSUPMT.
        /// </summary>
        public const string HSUPMT = "HSUPMT";

        /// <summary>
        /// HSUPMJ.
        /// </summary>
        public const string HSUPMJ = "HSUPMJ";

        /// <summary>
        /// HSDATF01.
        /// </summary>
        public const string HSDATF01 = "HSDATF01";

        /// <summary>
        /// HSDEPFUT2.
        /// </summary>
        public const string HSDEPFUT2 = "HSDEPFUT2";

        /// <summary>
        /// HSACTFU1.
        /// </summary>
        public const string HSACTFU1 = "HSACTFU1";

        /// <summary>
        /// HSFLAG.
        /// </summary>
        public const string HSFLAG = "HSFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I806";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HSI75CATTY", "HSI75CATTY", JdeDataType.String, 6, true, true),
        new JdeField("HSI75CATCO", "HSI75CATCO", JdeDataType.Numeric, null, true, true),
        new JdeField("HSI75CATVL", "HSI75CATVL", JdeDataType.String, 40),
        new JdeField("HSI75CATDS", "HSI75CATDS", JdeDataType.String, 60),
        new JdeField("HSI75GSTRA", "HSI75GSTRA", JdeDataType.String, 4),
        new JdeField("HSUSER", "HSUSER", JdeDataType.String, 20),
        new JdeField("HSPID", "HSPID", JdeDataType.String, 20),
        new JdeField("HSJOBN", "HSJOBN", JdeDataType.String, 20),
        new JdeField("HSUPMT", "HSUPMT", JdeDataType.Numeric),
        new JdeField("HSUPMJ", "HSUPMJ", JdeDataType.Numeric),
        new JdeField("HSDATF01", "HSDATF01", JdeDataType.Numeric),
        new JdeField("HSDEPFUT2", "HSDEPFUT2", JdeDataType.String, 60),
        new JdeField("HSACTFU1", "HSACTFU1", JdeDataType.String, 2),
        new JdeField("HSFLAG", "HSFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I806_0", "Primary Key on HSI75CATTY, HSI75CATCO", new[] { "HSI75CATTY", "HSI75CATCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I806_2", "Index on HSI75CATTY, HSI75CATVL", new[] { "HSI75CATTY", "HSI75CATVL" })
    };
}
