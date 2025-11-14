using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05842 - .
/// </summary>
public class F05842 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATAN8.
        /// </summary>
        public const string ATAN8 = "ATAN8";

        /// <summary>
        /// ATANPA.
        /// </summary>
        public const string ATANPA = "ATANPA";

        /// <summary>
        /// ATLVEL.
        /// </summary>
        public const string ATLVEL = "ATLVEL";

        /// <summary>
        /// ATAPPTY.
        /// </summary>
        public const string ATAPPTY = "ATAPPTY";

        /// <summary>
        /// ATANAB.
        /// </summary>
        public const string ATANAB = "ATANAB";

        /// <summary>
        /// ATAPPST.
        /// </summary>
        public const string ATAPPST = "ATAPPST";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATUPMT.
        /// </summary>
        public const string ATUPMT = "ATUPMT";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATSTCI.
        /// </summary>
        public const string ATSTCI = "ATSTCI";

        /// <summary>
        /// ATSERK.
        /// </summary>
        public const string ATSERK = "ATSERK";

        /// <summary>
        /// ATSTCTY.
        /// </summary>
        public const string ATSTCTY = "ATSTCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F05842";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATAN8", "ATAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ATANPA", "ATANPA", JdeDataType.Numeric),
        new JdeField("ATLVEL", "ATLVEL", JdeDataType.Numeric, null, true, true),
        new JdeField("ATAPPTY", "ATAPPTY", JdeDataType.String, 8, true, true),
        new JdeField("ATANAB", "ATANAB", JdeDataType.Numeric),
        new JdeField("ATAPPST", "ATAPPST", JdeDataType.String, 2),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ATUPMT", "ATUPMT", JdeDataType.Numeric),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATSTCI", "ATSTCI", JdeDataType.Numeric, null, true, true),
        new JdeField("ATSERK", "ATSERK", JdeDataType.Numeric),
        new JdeField("ATSTCTY", "ATSTCTY", JdeDataType.String, 16, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05842_0", "Primary Key on ATAN8, ATAPPTY, ATLVEL, ATUPMJ, ATSTCI, ATSTCTY", new[] { "ATAN8", "ATAPPTY", "ATLVEL", "ATUPMJ", "ATSTCI", "ATSTCTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05842_2", "Index on SYS_NC00014$, ATSTCI, ATSTCTY", new[] { "SYS_NC00014$", "ATSTCI", "ATSTCTY" }),
        new JdeIndex("F05842_3", "Index on ATSERK, ATSTCTY", new[] { "ATSERK", "ATSTCTY" })
    };
}
