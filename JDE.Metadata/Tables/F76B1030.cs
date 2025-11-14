using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B1030 - .
/// </summary>
public class F76B1030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMBNNF.
        /// </summary>
        public const string EMBNNF = "EMBNNF";

        /// <summary>
        /// EMBSER.
        /// </summary>
        public const string EMBSER = "EMBSER";

        /// <summary>
        /// EMN001.
        /// </summary>
        public const string EMN001 = "EMN001";

        /// <summary>
        /// EMDCT.
        /// </summary>
        public const string EMDCT = "EMDCT";

        /// <summary>
        /// EMAN8.
        /// </summary>
        public const string EMAN8 = "EMAN8";

        /// <summary>
        /// EM76BODANF.
        /// </summary>
        public const string EM76BODANF = "EM76BODANF";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";

        /// <summary>
        /// EMJOBN.
        /// </summary>
        public const string EMJOBN = "EMJOBN";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B1030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMBNNF", "EMBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("EMBSER", "EMBSER", JdeDataType.String, 4, true, true),
        new JdeField("EMN001", "EMN001", JdeDataType.Numeric, null, true, true),
        new JdeField("EMDCT", "EMDCT", JdeDataType.String, 4, true, true),
        new JdeField("EMAN8", "EMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EM76BODANF", "EM76BODANF", JdeDataType.String, 2),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20),
        new JdeField("EMJOBN", "EMJOBN", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B1030_0", "Primary Key on EMBNNF, EMBSER, EMN001, EMDCT, EMAN8", new[] { "EMBNNF", "EMBSER", "EMN001", "EMDCT", "EMAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
