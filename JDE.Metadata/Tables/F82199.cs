using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82199 - .
/// </summary>
public class F82199 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FUQRYG.
        /// </summary>
        public const string FUQRYG = "FUQRYG";

        /// <summary>
        /// FUQRYN.
        /// </summary>
        public const string FUQRYN = "FUQRYN";

        /// <summary>
        /// FUFID2.
        /// </summary>
        public const string FUFID2 = "FUFID2";

        /// <summary>
        /// FUVER2.
        /// </summary>
        public const string FUVER2 = "FUVER2";

        /// <summary>
        /// FUOSEQ.
        /// </summary>
        public const string FUOSEQ = "FUOSEQ";

        /// <summary>
        /// FUJD.
        /// </summary>
        public const string FUJD = "FUJD";

        /// <summary>
        /// FUBVNM.
        /// </summary>
        public const string FUBVNM = "FUBVNM";

        /// <summary>
        /// FUSHNO.
        /// </summary>
        public const string FUSHNO = "FUSHNO";

        /// <summary>
        /// FUTXLN.
        /// </summary>
        public const string FUTXLN = "FUTXLN";

        /// <summary>
        /// FUMSTP.
        /// </summary>
        public const string FUMSTP = "FUMSTP";

        /// <summary>
        /// FUDTE.
        /// </summary>
        public const string FUDTE = "FUDTE";

        /// <summary>
        /// FUTME0.
        /// </summary>
        public const string FUTME0 = "FUTME0";
    }

    /// <inheritdoc />
    public override string TableName => "F82199";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FUQRYG", "FUQRYG", JdeDataType.String, 20, true, true),
        new JdeField("FUQRYN", "FUQRYN", JdeDataType.String, 20, true, true),
        new JdeField("FUFID2", "FUFID2", JdeDataType.String, 20, true, true),
        new JdeField("FUVER2", "FUVER2", JdeDataType.String, 20, true, true),
        new JdeField("FUOSEQ", "FUOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("FUJD", "FUJD", JdeDataType.String, 100),
        new JdeField("FUBVNM", "FUBVNM", JdeDataType.String, 20),
        new JdeField("FUSHNO", "FUSHNO", JdeDataType.String, 20),
        new JdeField("FUTXLN", "FUTXLN", JdeDataType.String, 120),
        new JdeField("FUMSTP", "FUMSTP", JdeDataType.String, 2),
        new JdeField("FUDTE", "FUDTE", JdeDataType.Numeric),
        new JdeField("FUTME0", "FUTME0", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82199_0", "Primary Key on FUQRYG, FUQRYN, FUFID2, FUVER2, FUOSEQ", new[] { "FUQRYG", "FUQRYN", "FUFID2", "FUVER2", "FUOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
