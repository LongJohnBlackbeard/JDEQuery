using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1792 - .
/// </summary>
public class F1792 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPCOVGR.
        /// </summary>
        public const string CPCOVGR = "CPCOVGR";

        /// <summary>
        /// CPCOST.
        /// </summary>
        public const string CPCOST = "CPCOST";

        /// <summary>
        /// CPPCOVR.
        /// </summary>
        public const string CPPCOVR = "CPPCOVR";

        /// <summary>
        /// CPCRTU.
        /// </summary>
        public const string CPCRTU = "CPCRTU";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPUPMJ.
        /// </summary>
        public const string CPUPMJ = "CPUPMJ";

        /// <summary>
        /// CPUPMT.
        /// </summary>
        public const string CPUPMT = "CPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1792";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPCOVGR", "CPCOVGR", JdeDataType.String, 16, true, true),
        new JdeField("CPCOST", "CPCOST", JdeDataType.String, 6, true, true),
        new JdeField("CPPCOVR", "CPPCOVR", JdeDataType.Numeric),
        new JdeField("CPCRTU", "CPCRTU", JdeDataType.String, 20),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPUPMJ", "CPUPMJ", JdeDataType.Numeric),
        new JdeField("CPUPMT", "CPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1792_0", "Primary Key on CPCOVGR, CPCOST", new[] { "CPCOVGR", "CPCOST" }, isUnique: true, isPrimaryKey: true)
    };
}
