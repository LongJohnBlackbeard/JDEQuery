using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B036 - .
/// </summary>
public class F76B036 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JRBNNF.
        /// </summary>
        public const string JRBNNF = "JRBNNF";

        /// <summary>
        /// JRBSER.
        /// </summary>
        public const string JRBSER = "JRBSER";

        /// <summary>
        /// JRN001.
        /// </summary>
        public const string JRN001 = "JRN001";

        /// <summary>
        /// JRDCT.
        /// </summary>
        public const string JRDCT = "JRDCT";

        /// <summary>
        /// JRB76JPID.
        /// </summary>
        public const string JRB76JPID = "JRB76JPID";

        /// <summary>
        /// JRB76SCID.
        /// </summary>
        public const string JRB76SCID = "JRB76SCID";

        /// <summary>
        /// JRB76VRID.
        /// </summary>
        public const string JRB76VRID = "JRB76VRID";

        /// <summary>
        /// JRB76URAB.
        /// </summary>
        public const string JRB76URAB = "JRB76URAB";

        /// <summary>
        /// JRB76URAT.
        /// </summary>
        public const string JRB76URAT = "JRB76URAT";

        /// <summary>
        /// JRB76URRF.
        /// </summary>
        public const string JRB76URRF = "JRB76URRF";

        /// <summary>
        /// JRB76URDT.
        /// </summary>
        public const string JRB76URDT = "JRB76URDT";

        /// <summary>
        /// JRB76URCD.
        /// </summary>
        public const string JRB76URCD = "JRB76URCD";

        /// <summary>
        /// JRUSER.
        /// </summary>
        public const string JRUSER = "JRUSER";

        /// <summary>
        /// JRPID.
        /// </summary>
        public const string JRPID = "JRPID";

        /// <summary>
        /// JRJOBN.
        /// </summary>
        public const string JRJOBN = "JRJOBN";

        /// <summary>
        /// JRUPMJ.
        /// </summary>
        public const string JRUPMJ = "JRUPMJ";

        /// <summary>
        /// JRUPMT.
        /// </summary>
        public const string JRUPMT = "JRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B036";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JRBNNF", "JRBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("JRBSER", "JRBSER", JdeDataType.String, 4, true, true),
        new JdeField("JRN001", "JRN001", JdeDataType.Numeric, null, true, true),
        new JdeField("JRDCT", "JRDCT", JdeDataType.String, 4, true, true),
        new JdeField("JRB76JPID", "JRB76JPID", JdeDataType.String, 80, true, true),
        new JdeField("JRB76SCID", "JRB76SCID", JdeDataType.String, 512, true, true),
        new JdeField("JRB76VRID", "JRB76VRID", JdeDataType.String, 4, true, true),
        new JdeField("JRB76URAB", "JRB76URAB", JdeDataType.Numeric),
        new JdeField("JRB76URAT", "JRB76URAT", JdeDataType.Numeric),
        new JdeField("JRB76URRF", "JRB76URRF", JdeDataType.String, 30),
        new JdeField("JRB76URDT", "JRB76URDT", JdeDataType.Numeric),
        new JdeField("JRB76URCD", "JRB76URCD", JdeDataType.String, 4),
        new JdeField("JRUSER", "JRUSER", JdeDataType.String, 20),
        new JdeField("JRPID", "JRPID", JdeDataType.String, 20),
        new JdeField("JRJOBN", "JRJOBN", JdeDataType.String, 20),
        new JdeField("JRUPMJ", "JRUPMJ", JdeDataType.Numeric),
        new JdeField("JRUPMT", "JRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B036_0", "Primary Key on JRBNNF, JRBSER, JRN001, JRDCT, JRB76JPID, JRB76SCID, JRB76VRID", new[] { "JRBNNF", "JRBSER", "JRN001", "JRDCT", "JRB76JPID", "JRB76SCID", "JRB76VRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B036_2", "Index on JRB76JPID", new[] { "JRB76JPID" })
    };
}
