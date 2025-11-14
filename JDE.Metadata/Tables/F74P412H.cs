using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P412H - .
/// </summary>
public class F74P412H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THKCO.
        /// </summary>
        public const string THKCO = "THKCO";

        /// <summary>
        /// THDCT.
        /// </summary>
        public const string THDCT = "THDCT";

        /// <summary>
        /// THDOC.
        /// </summary>
        public const string THDOC = "THDOC";

        /// <summary>
        /// THP74TLDJ.
        /// </summary>
        public const string THP74TLDJ = "THP74TLDJ";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P412H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THKCO", "THKCO", JdeDataType.String, 10, true, true),
        new JdeField("THDCT", "THDCT", JdeDataType.String, 4, true, true),
        new JdeField("THDOC", "THDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("THP74TLDJ", "THP74TLDJ", JdeDataType.Numeric),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P412H_0", "Primary Key on THKCO, THDCT, THDOC", new[] { "THKCO", "THDCT", "THDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
