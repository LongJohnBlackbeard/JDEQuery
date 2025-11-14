using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB01C - .
/// </summary>
public class F90CB01C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPLEADID.
        /// </summary>
        public const string LPLEADID = "LPLEADID";

        /// <summary>
        /// LPPRAN8.
        /// </summary>
        public const string LPPRAN8 = "LPPRAN8";

        /// <summary>
        /// LPSTSUDT.
        /// </summary>
        public const string LPSTSUDT = "LPSTSUDT";

        /// <summary>
        /// LPACTIND.
        /// </summary>
        public const string LPACTIND = "LPACTIND";

        /// <summary>
        /// LPUSER.
        /// </summary>
        public const string LPUSER = "LPUSER";

        /// <summary>
        /// LPPID.
        /// </summary>
        public const string LPPID = "LPPID";

        /// <summary>
        /// LPVID.
        /// </summary>
        public const string LPVID = "LPVID";

        /// <summary>
        /// LPMKEY.
        /// </summary>
        public const string LPMKEY = "LPMKEY";

        /// <summary>
        /// LPUDTTM.
        /// </summary>
        public const string LPUDTTM = "LPUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB01C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPLEADID", "LPLEADID", JdeDataType.Numeric, null, true, true),
        new JdeField("LPPRAN8", "LPPRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LPSTSUDT", "LPSTSUDT", JdeDataType.Date),
        new JdeField("LPACTIND", "LPACTIND", JdeDataType.String, 2),
        new JdeField("LPUSER", "LPUSER", JdeDataType.String, 20),
        new JdeField("LPPID", "LPPID", JdeDataType.String, 20),
        new JdeField("LPVID", "LPVID", JdeDataType.String, 20),
        new JdeField("LPMKEY", "LPMKEY", JdeDataType.String, 30),
        new JdeField("LPUDTTM", "LPUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB01C_0", "Primary Key on LPLEADID, LPPRAN8", new[] { "LPLEADID", "LPPRAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
