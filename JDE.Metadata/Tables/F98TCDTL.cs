using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98TCDTL - .
/// </summary>
public class F98TCDTL : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDDOCO.
        /// </summary>
        public const string CDDOCO = "CDDOCO";

        /// <summary>
        /// CDDCTO.
        /// </summary>
        public const string CDDCTO = "CDDCTO";

        /// <summary>
        /// CDKCO.
        /// </summary>
        public const string CDKCO = "CDKCO";

        /// <summary>
        /// CDLNID.
        /// </summary>
        public const string CDLNID = "CDLNID";

        /// <summary>
        /// CDITM.
        /// </summary>
        public const string CDITM = "CDITM";

        /// <summary>
        /// CDMCU.
        /// </summary>
        public const string CDMCU = "CDMCU";

        /// <summary>
        /// CDTRQT.
        /// </summary>
        public const string CDTRQT = "CDTRQT";

        /// <summary>
        /// CDPRRC.
        /// </summary>
        public const string CDPRRC = "CDPRRC";

        /// <summary>
        /// CDAEXP.
        /// </summary>
        public const string CDAEXP = "CDAEXP";
    }

    /// <inheritdoc />
    public override string TableName => "F98TCDTL";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDDOCO", "CDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CDDCTO", "CDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CDKCO", "CDKCO", JdeDataType.String, 10, true, true),
        new JdeField("CDLNID", "CDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDITM", "CDITM", JdeDataType.Numeric),
        new JdeField("CDMCU", "CDMCU", JdeDataType.String, 24),
        new JdeField("CDTRQT", "CDTRQT", JdeDataType.Numeric),
        new JdeField("CDPRRC", "CDPRRC", JdeDataType.Numeric),
        new JdeField("CDAEXP", "CDAEXP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98TCDTL_0", "Primary Key on CDDOCO, CDDCTO, CDKCO, CDLNID", new[] { "CDDOCO", "CDDCTO", "CDKCO", "CDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
