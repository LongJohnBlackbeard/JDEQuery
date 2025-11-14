using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F460151 - .
/// </summary>
public class F460151 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSITM.
        /// </summary>
        public const string MSITM = "MSITM";

        /// <summary>
        /// MSMCU.
        /// </summary>
        public const string MSMCU = "MSMCU";

        /// <summary>
        /// MSMPGP.
        /// </summary>
        public const string MSMPGP = "MSMPGP";

        /// <summary>
        /// MSUSER.
        /// </summary>
        public const string MSUSER = "MSUSER";

        /// <summary>
        /// MSPID.
        /// </summary>
        public const string MSPID = "MSPID";

        /// <summary>
        /// MSJOBN.
        /// </summary>
        public const string MSJOBN = "MSJOBN";

        /// <summary>
        /// MSUTIME.
        /// </summary>
        public const string MSUTIME = "MSUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F460151";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSITM", "MSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MSMCU", "MSMCU", JdeDataType.String, 24, true, true),
        new JdeField("MSMPGP", "MSMPGP", JdeDataType.String, 12),
        new JdeField("MSUSER", "MSUSER", JdeDataType.String, 20),
        new JdeField("MSPID", "MSPID", JdeDataType.String, 20),
        new JdeField("MSJOBN", "MSJOBN", JdeDataType.String, 20),
        new JdeField("MSUTIME", "MSUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F460151_0", "Primary Key on MSITM, MSMCU", new[] { "MSITM", "MSMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F460151_2", "Index on MSMPGP, MSMCU, MSITM", new[] { "MSMPGP", "MSMCU", "MSITM" })
    };
}
