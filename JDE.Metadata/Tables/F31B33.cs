using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B33 - .
/// </summary>
public class F31B33 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODWVID.
        /// </summary>
        public const string ODWVID = "ODWVID";

        /// <summary>
        /// ODWDOCO.
        /// </summary>
        public const string ODWDOCO = "ODWDOCO";

        /// <summary>
        /// ODPWOPID.
        /// </summary>
        public const string ODPWOPID = "ODPWOPID";

        /// <summary>
        /// ODSWOPID.
        /// </summary>
        public const string ODSWOPID = "ODSWOPID";

        /// <summary>
        /// ODMCU.
        /// </summary>
        public const string ODMCU = "ODMCU";

        /// <summary>
        /// ODPWOPST.
        /// </summary>
        public const string ODPWOPST = "ODPWOPST";

        /// <summary>
        /// ODSWOPST.
        /// </summary>
        public const string ODSWOPST = "ODSWOPST";

        /// <summary>
        /// ODWBLOTN.
        /// </summary>
        public const string ODWBLOTN = "ODWBLOTN";

        /// <summary>
        /// ODWLDT.
        /// </summary>
        public const string ODWLDT = "ODWLDT";

        /// <summary>
        /// ODUSER.
        /// </summary>
        public const string ODUSER = "ODUSER";

        /// <summary>
        /// ODPID.
        /// </summary>
        public const string ODPID = "ODPID";

        /// <summary>
        /// ODJOBN.
        /// </summary>
        public const string ODJOBN = "ODJOBN";

        /// <summary>
        /// ODUPMJ.
        /// </summary>
        public const string ODUPMJ = "ODUPMJ";

        /// <summary>
        /// ODTDAY.
        /// </summary>
        public const string ODTDAY = "ODTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B33";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODWVID", "ODWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("ODWDOCO", "ODWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ODPWOPID", "ODPWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ODSWOPID", "ODSWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ODMCU", "ODMCU", JdeDataType.String, 24, true, true),
        new JdeField("ODPWOPST", "ODPWOPST", JdeDataType.String, 20),
        new JdeField("ODSWOPST", "ODSWOPST", JdeDataType.String, 20),
        new JdeField("ODWBLOTN", "ODWBLOTN", JdeDataType.String, 60),
        new JdeField("ODWLDT", "ODWLDT", JdeDataType.String, 2),
        new JdeField("ODUSER", "ODUSER", JdeDataType.String, 20),
        new JdeField("ODPID", "ODPID", JdeDataType.String, 20),
        new JdeField("ODJOBN", "ODJOBN", JdeDataType.String, 20),
        new JdeField("ODUPMJ", "ODUPMJ", JdeDataType.Numeric),
        new JdeField("ODTDAY", "ODTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B33_0", "Primary Key on ODWVID, ODWDOCO, ODMCU, ODPWOPID, ODSWOPID", new[] { "ODWVID", "ODWDOCO", "ODMCU", "ODPWOPID", "ODSWOPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B33_2", "Index on ODPWOPID, ODWLDT, ODSWOPID", new[] { "ODPWOPID", "ODWLDT", "ODSWOPID" }),
        new JdeIndex("F31B33_3", "Index on ODSWOPID, ODWLDT, ODPWOPID", new[] { "ODSWOPID", "ODWLDT", "ODPWOPID" }),
        new JdeIndex("F31B33_4", "Index on ODWVID, ODSWOPST, ODPWOPST", new[] { "ODWVID", "ODSWOPST", "ODPWOPST" })
    };
}
