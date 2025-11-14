using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B220 - .
/// </summary>
public class F76B220 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DWB76COID.
        /// </summary>
        public const string DWB76COID = "DWB76COID";

        /// <summary>
        /// DWBRG.
        /// </summary>
        public const string DWBRG = "DWBRG";

        /// <summary>
        /// DWB76DWC.
        /// </summary>
        public const string DWB76DWC = "DWB76DWC";

        /// <summary>
        /// DWJOBN.
        /// </summary>
        public const string DWJOBN = "DWJOBN";

        /// <summary>
        /// DWUSER.
        /// </summary>
        public const string DWUSER = "DWUSER";

        /// <summary>
        /// DWPID.
        /// </summary>
        public const string DWPID = "DWPID";

        /// <summary>
        /// DWUPMJ.
        /// </summary>
        public const string DWUPMJ = "DWUPMJ";

        /// <summary>
        /// DWUPMT.
        /// </summary>
        public const string DWUPMT = "DWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B220";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DWB76COID", "DWB76COID", JdeDataType.String, 18, true, true),
        new JdeField("DWBRG", "DWBRG", JdeDataType.String, 18, true, true),
        new JdeField("DWB76DWC", "DWB76DWC", JdeDataType.String, 4),
        new JdeField("DWJOBN", "DWJOBN", JdeDataType.String, 20),
        new JdeField("DWUSER", "DWUSER", JdeDataType.String, 20),
        new JdeField("DWPID", "DWPID", JdeDataType.String, 20),
        new JdeField("DWUPMJ", "DWUPMJ", JdeDataType.Numeric),
        new JdeField("DWUPMT", "DWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B220_0", "Primary Key on DWB76COID, DWBRG", new[] { "DWB76COID", "DWBRG" }, isUnique: true, isPrimaryKey: true)
    };
}
