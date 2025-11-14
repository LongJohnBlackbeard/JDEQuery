using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F115 - .
/// </summary>
public class F51F115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QJ51FFID.
        /// </summary>
        public const string QJ51FFID = "QJ51FFID";

        /// <summary>
        /// QJAID.
        /// </summary>
        public const string QJAID = "QJAID";

        /// <summary>
        /// QJ51FRWID.
        /// </summary>
        public const string QJ51FRWID = "QJ51FRWID";

        /// <summary>
        /// QJ51FRWDS.
        /// </summary>
        public const string QJ51FRWDS = "QJ51FRWDS";

        /// <summary>
        /// QJ51FCTCQ.
        /// </summary>
        public const string QJ51FCTCQ = "QJ51FCTCQ";

        /// <summary>
        /// QJ51FCTCR.
        /// </summary>
        public const string QJ51FCTCR = "QJ51FCTCR";

        /// <summary>
        /// QJ51FCTCA.
        /// </summary>
        public const string QJ51FCTCA = "QJ51FCTCA";

        /// <summary>
        /// QJUM.
        /// </summary>
        public const string QJUM = "QJUM";

        /// <summary>
        /// QJ51FRMK.
        /// </summary>
        public const string QJ51FRMK = "QJ51FRMK";

        /// <summary>
        /// QJTORG.
        /// </summary>
        public const string QJTORG = "QJTORG";

        /// <summary>
        /// QJENTJ.
        /// </summary>
        public const string QJENTJ = "QJENTJ";

        /// <summary>
        /// QJTENT.
        /// </summary>
        public const string QJTENT = "QJTENT";

        /// <summary>
        /// QJUSER.
        /// </summary>
        public const string QJUSER = "QJUSER";

        /// <summary>
        /// QJUPMJ.
        /// </summary>
        public const string QJUPMJ = "QJUPMJ";

        /// <summary>
        /// QJUPMT.
        /// </summary>
        public const string QJUPMT = "QJUPMT";

        /// <summary>
        /// QJJOBN.
        /// </summary>
        public const string QJJOBN = "QJJOBN";

        /// <summary>
        /// QJPID.
        /// </summary>
        public const string QJPID = "QJPID";

        /// <summary>
        /// QJMKEY.
        /// </summary>
        public const string QJMKEY = "QJMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F51F115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QJ51FFID", "QJ51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("QJAID", "QJAID", JdeDataType.String, 16, true, true),
        new JdeField("QJ51FRWID", "QJ51FRWID", JdeDataType.Numeric, null, true, true),
        new JdeField("QJ51FRWDS", "QJ51FRWDS", JdeDataType.String, 160),
        new JdeField("QJ51FCTCQ", "QJ51FCTCQ", JdeDataType.Numeric),
        new JdeField("QJ51FCTCR", "QJ51FCTCR", JdeDataType.Numeric),
        new JdeField("QJ51FCTCA", "QJ51FCTCA", JdeDataType.Numeric),
        new JdeField("QJUM", "QJUM", JdeDataType.String, 4),
        new JdeField("QJ51FRMK", "QJ51FRMK", JdeDataType.String, 160),
        new JdeField("QJTORG", "QJTORG", JdeDataType.String, 20),
        new JdeField("QJENTJ", "QJENTJ", JdeDataType.Numeric),
        new JdeField("QJTENT", "QJTENT", JdeDataType.Numeric),
        new JdeField("QJUSER", "QJUSER", JdeDataType.String, 20),
        new JdeField("QJUPMJ", "QJUPMJ", JdeDataType.Numeric),
        new JdeField("QJUPMT", "QJUPMT", JdeDataType.Numeric),
        new JdeField("QJJOBN", "QJJOBN", JdeDataType.String, 20),
        new JdeField("QJPID", "QJPID", JdeDataType.String, 20),
        new JdeField("QJMKEY", "QJMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F115_0", "Primary Key on QJ51FFID, QJAID, QJ51FRWID", new[] { "QJ51FFID", "QJAID", "QJ51FRWID" }, isUnique: true, isPrimaryKey: true)
    };
}
