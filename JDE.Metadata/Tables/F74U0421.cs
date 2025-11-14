using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0421 - .
/// </summary>
public class F74U0421 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IOKCOO.
        /// </summary>
        public const string IOKCOO = "IOKCOO";

        /// <summary>
        /// IODOCO.
        /// </summary>
        public const string IODOCO = "IODOCO";

        /// <summary>
        /// IODCTO.
        /// </summary>
        public const string IODCTO = "IODCTO";

        /// <summary>
        /// IOUKAPNM.
        /// </summary>
        public const string IOUKAPNM = "IOUKAPNM";

        /// <summary>
        /// IODIVJ.
        /// </summary>
        public const string IODIVJ = "IODIVJ";

        /// <summary>
        /// IODSVJ.
        /// </summary>
        public const string IODSVJ = "IODSVJ";

        /// <summary>
        /// IOVINV.
        /// </summary>
        public const string IOVINV = "IOVINV";

        /// <summary>
        /// IOUSER.
        /// </summary>
        public const string IOUSER = "IOUSER";

        /// <summary>
        /// IOJOBN.
        /// </summary>
        public const string IOJOBN = "IOJOBN";

        /// <summary>
        /// IOPID.
        /// </summary>
        public const string IOPID = "IOPID";

        /// <summary>
        /// IOUPMJ.
        /// </summary>
        public const string IOUPMJ = "IOUPMJ";

        /// <summary>
        /// IOUPMT.
        /// </summary>
        public const string IOUPMT = "IOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0421";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IOKCOO", "IOKCOO", JdeDataType.String, 10, true, true),
        new JdeField("IODOCO", "IODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IODCTO", "IODCTO", JdeDataType.String, 4, true, true),
        new JdeField("IOUKAPNM", "IOUKAPNM", JdeDataType.Numeric, null, true, true),
        new JdeField("IODIVJ", "IODIVJ", JdeDataType.Numeric),
        new JdeField("IODSVJ", "IODSVJ", JdeDataType.Numeric),
        new JdeField("IOVINV", "IOVINV", JdeDataType.String, 50),
        new JdeField("IOUSER", "IOUSER", JdeDataType.String, 20),
        new JdeField("IOJOBN", "IOJOBN", JdeDataType.String, 20),
        new JdeField("IOPID", "IOPID", JdeDataType.String, 20),
        new JdeField("IOUPMJ", "IOUPMJ", JdeDataType.Numeric),
        new JdeField("IOUPMT", "IOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0421_0", "Primary Key on IOKCOO, IODOCO, IODCTO, IOUKAPNM", new[] { "IOKCOO", "IODOCO", "IODCTO", "IOUKAPNM" }, isUnique: true, isPrimaryKey: true)
    };
}
