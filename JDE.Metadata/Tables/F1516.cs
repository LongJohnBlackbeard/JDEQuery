using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1516 - .
/// </summary>
public class F1516 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NXDOC.
        /// </summary>
        public const string NXDOC = "NXDOC";

        /// <summary>
        /// NXLNID.
        /// </summary>
        public const string NXLNID = "NXLNID";

        /// <summary>
        /// NXLDTA.
        /// </summary>
        public const string NXLDTA = "NXLDTA";

        /// <summary>
        /// NXUSER.
        /// </summary>
        public const string NXUSER = "NXUSER";

        /// <summary>
        /// NXUPMJ.
        /// </summary>
        public const string NXUPMJ = "NXUPMJ";

        /// <summary>
        /// NXPID.
        /// </summary>
        public const string NXPID = "NXPID";

        /// <summary>
        /// NXJOBN.
        /// </summary>
        public const string NXJOBN = "NXJOBN";

        /// <summary>
        /// NXUPMT.
        /// </summary>
        public const string NXUPMT = "NXUPMT";

        /// <summary>
        /// NXKCO.
        /// </summary>
        public const string NXKCO = "NXKCO";
    }

    /// <inheritdoc />
    public override string TableName => "F1516";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NXDOC", "NXDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("NXLNID", "NXLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("NXLDTA", "NXLDTA", JdeDataType.String, 120),
        new JdeField("NXUSER", "NXUSER", JdeDataType.String, 20),
        new JdeField("NXUPMJ", "NXUPMJ", JdeDataType.Numeric),
        new JdeField("NXPID", "NXPID", JdeDataType.String, 20),
        new JdeField("NXJOBN", "NXJOBN", JdeDataType.String, 20),
        new JdeField("NXUPMT", "NXUPMT", JdeDataType.Numeric),
        new JdeField("NXKCO", "NXKCO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1516_0", "Primary Key on NXDOC, NXKCO, NXLNID", new[] { "NXDOC", "NXKCO", "NXLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
