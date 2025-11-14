using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB01D - .
/// </summary>
public class F90CB01D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LILEADID.
        /// </summary>
        public const string LILEADID = "LILEADID";

        /// <summary>
        /// LIOSTP.
        /// </summary>
        public const string LIOSTP = "LIOSTP";

        /// <summary>
        /// LIUKID.
        /// </summary>
        public const string LIUKID = "LIUKID";

        /// <summary>
        /// LIDL01.
        /// </summary>
        public const string LIDL01 = "LIDL01";

        /// <summary>
        /// LISTSUDT.
        /// </summary>
        public const string LISTSUDT = "LISTSUDT";

        /// <summary>
        /// LIACTIND.
        /// </summary>
        public const string LIACTIND = "LIACTIND";

        /// <summary>
        /// LIUSER.
        /// </summary>
        public const string LIUSER = "LIUSER";

        /// <summary>
        /// LIPID.
        /// </summary>
        public const string LIPID = "LIPID";

        /// <summary>
        /// LIVID.
        /// </summary>
        public const string LIVID = "LIVID";

        /// <summary>
        /// LIMKEY.
        /// </summary>
        public const string LIMKEY = "LIMKEY";

        /// <summary>
        /// LIUDTTM.
        /// </summary>
        public const string LIUDTTM = "LIUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB01D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LILEADID", "LILEADID", JdeDataType.Numeric, null, true, true),
        new JdeField("LIOSTP", "LIOSTP", JdeDataType.String, 6, true, true),
        new JdeField("LIUKID", "LIUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LIDL01", "LIDL01", JdeDataType.String, 60),
        new JdeField("LISTSUDT", "LISTSUDT", JdeDataType.Date),
        new JdeField("LIACTIND", "LIACTIND", JdeDataType.String, 2),
        new JdeField("LIUSER", "LIUSER", JdeDataType.String, 20),
        new JdeField("LIPID", "LIPID", JdeDataType.String, 20),
        new JdeField("LIVID", "LIVID", JdeDataType.String, 20),
        new JdeField("LIMKEY", "LIMKEY", JdeDataType.String, 30),
        new JdeField("LIUDTTM", "LIUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB01D_0", "Primary Key on LILEADID, LIOSTP, LIUKID", new[] { "LILEADID", "LIOSTP", "LIUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
