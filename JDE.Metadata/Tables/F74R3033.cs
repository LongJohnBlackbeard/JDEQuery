using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R3033 - .
/// </summary>
public class F74R3033 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DFKCO.
        /// </summary>
        public const string DFKCO = "DFKCO";

        /// <summary>
        /// DFDCT.
        /// </summary>
        public const string DFDCT = "DFDCT";

        /// <summary>
        /// DFDOC.
        /// </summary>
        public const string DFDOC = "DFDOC";

        /// <summary>
        /// DFSEQ.
        /// </summary>
        public const string DFSEQ = "DFSEQ";

        /// <summary>
        /// DFR74DCD.
        /// </summary>
        public const string DFR74DCD = "DFR74DCD";

        /// <summary>
        /// DFR74DCDN.
        /// </summary>
        public const string DFR74DCDN = "DFR74DCDN";

        /// <summary>
        /// DFUOM.
        /// </summary>
        public const string DFUOM = "DFUOM";

        /// <summary>
        /// DFR74CDC.
        /// </summary>
        public const string DFR74CDC = "DFR74CDC";

        /// <summary>
        /// DFR74CSN.
        /// </summary>
        public const string DFR74CSN = "DFR74CSN";

        /// <summary>
        /// DFORIG.
        /// </summary>
        public const string DFORIG = "DFORIG";

        /// <summary>
        /// DFUSER.
        /// </summary>
        public const string DFUSER = "DFUSER";

        /// <summary>
        /// DFPID.
        /// </summary>
        public const string DFPID = "DFPID";

        /// <summary>
        /// DFJOBN.
        /// </summary>
        public const string DFJOBN = "DFJOBN";

        /// <summary>
        /// DFUPMT.
        /// </summary>
        public const string DFUPMT = "DFUPMT";

        /// <summary>
        /// DFUPMJ.
        /// </summary>
        public const string DFUPMJ = "DFUPMJ";

        /// <summary>
        /// DFURCD.
        /// </summary>
        public const string DFURCD = "DFURCD";

        /// <summary>
        /// DFURDT.
        /// </summary>
        public const string DFURDT = "DFURDT";

        /// <summary>
        /// DFURAT.
        /// </summary>
        public const string DFURAT = "DFURAT";

        /// <summary>
        /// DFURAB.
        /// </summary>
        public const string DFURAB = "DFURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F74R3033";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DFKCO", "DFKCO", JdeDataType.String, 10, true, true),
        new JdeField("DFDCT", "DFDCT", JdeDataType.String, 4, true, true),
        new JdeField("DFDOC", "DFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DFSEQ", "DFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DFR74DCD", "DFR74DCD", JdeDataType.String, 6),
        new JdeField("DFR74DCDN", "DFR74DCDN", JdeDataType.String, 20),
        new JdeField("DFUOM", "DFUOM", JdeDataType.String, 4),
        new JdeField("DFR74CDC", "DFR74CDC", JdeDataType.Numeric),
        new JdeField("DFR74CSN", "DFR74CSN", JdeDataType.String, 40),
        new JdeField("DFORIG", "DFORIG", JdeDataType.String, 6),
        new JdeField("DFUSER", "DFUSER", JdeDataType.String, 20),
        new JdeField("DFPID", "DFPID", JdeDataType.String, 20),
        new JdeField("DFJOBN", "DFJOBN", JdeDataType.String, 20),
        new JdeField("DFUPMT", "DFUPMT", JdeDataType.Numeric),
        new JdeField("DFUPMJ", "DFUPMJ", JdeDataType.Numeric),
        new JdeField("DFURCD", "DFURCD", JdeDataType.String, 4),
        new JdeField("DFURDT", "DFURDT", JdeDataType.Numeric),
        new JdeField("DFURAT", "DFURAT", JdeDataType.Numeric),
        new JdeField("DFURAB", "DFURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R3033_0", "Primary Key on DFKCO, DFDCT, DFDOC, DFSEQ", new[] { "DFKCO", "DFDCT", "DFDOC", "DFSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
