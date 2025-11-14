using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N4041 - .
/// </summary>
public class FD3N4041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDCYNO.
        /// </summary>
        public const string CDCYNO = "CDCYNO";

        /// <summary>
        /// CDCNID.
        /// </summary>
        public const string CDCNID = "CDCNID";

        /// <summary>
        /// CDITM.
        /// </summary>
        public const string CDITM = "CDITM";

        /// <summary>
        /// CDLOTN.
        /// </summary>
        public const string CDLOTN = "CDLOTN";

        /// <summary>
        /// CDLOCN.
        /// </summary>
        public const string CDLOCN = "CDLOCN";

        /// <summary>
        /// CDTAOH.
        /// </summary>
        public const string CDTAOH = "CDTAOH";

        /// <summary>
        /// CDTACT.
        /// </summary>
        public const string CDTACT = "CDTACT";

        /// <summary>
        /// CDUM.
        /// </summary>
        public const string CDUM = "CDUM";

        /// <summary>
        /// CDPTUPUSER.
        /// </summary>
        public const string CDPTUPUSER = "CDPTUPUSER";

        /// <summary>
        /// CDPTUPDTTM.
        /// </summary>
        public const string CDPTUPDTTM = "CDPTUPDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N4041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDCYNO", "CDCYNO", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCNID", "CDCNID", JdeDataType.String, 40, true, true),
        new JdeField("CDITM", "CDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CDLOTN", "CDLOTN", JdeDataType.String, 60, true, true),
        new JdeField("CDLOCN", "CDLOCN", JdeDataType.String, 40),
        new JdeField("CDTAOH", "CDTAOH", JdeDataType.Numeric),
        new JdeField("CDTACT", "CDTACT", JdeDataType.Numeric),
        new JdeField("CDUM", "CDUM", JdeDataType.String, 4),
        new JdeField("CDPTUPUSER", "CDPTUPUSER", JdeDataType.String, 32),
        new JdeField("CDPTUPDTTM", "CDPTUPDTTM", JdeDataType.String, 28)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N4041_0", "Primary Key on CDCYNO, CDCNID, CDITM, CDLOTN", new[] { "CDCYNO", "CDCNID", "CDITM", "CDLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
