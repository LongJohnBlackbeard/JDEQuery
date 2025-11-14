using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5213 - .
/// </summary>
public class F5213 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G3DOCO.
        /// </summary>
        public const string G3DOCO = "G3DOCO";

        /// <summary>
        /// G3DCTO.
        /// </summary>
        public const string G3DCTO = "G3DCTO";

        /// <summary>
        /// G3KCOO.
        /// </summary>
        public const string G3KCOO = "G3KCOO";

        /// <summary>
        /// G3COCH.
        /// </summary>
        public const string G3COCH = "G3COCH";

        /// <summary>
        /// G3LNID.
        /// </summary>
        public const string G3LNID = "G3LNID";

        /// <summary>
        /// G3LIN.
        /// </summary>
        public const string G3LIN = "G3LIN";

        /// <summary>
        /// G3OPIM.
        /// </summary>
        public const string G3OPIM = "G3OPIM";

        /// <summary>
        /// G3RCOC.
        /// </summary>
        public const string G3RCOC = "G3RCOC";

        /// <summary>
        /// G3LNIX.
        /// </summary>
        public const string G3LNIX = "G3LNIX";

        /// <summary>
        /// G3PID.
        /// </summary>
        public const string G3PID = "G3PID";

        /// <summary>
        /// G3USER.
        /// </summary>
        public const string G3USER = "G3USER";

        /// <summary>
        /// G3JOBN.
        /// </summary>
        public const string G3JOBN = "G3JOBN";

        /// <summary>
        /// G3UPMJ.
        /// </summary>
        public const string G3UPMJ = "G3UPMJ";

        /// <summary>
        /// G3UPMT.
        /// </summary>
        public const string G3UPMT = "G3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5213";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G3DOCO", "G3DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("G3DCTO", "G3DCTO", JdeDataType.String, 4, true, true),
        new JdeField("G3KCOO", "G3KCOO", JdeDataType.String, 10, true, true),
        new JdeField("G3COCH", "G3COCH", JdeDataType.String, 6, true, true),
        new JdeField("G3LNID", "G3LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("G3LIN", "G3LIN", JdeDataType.Numeric, null, true, true),
        new JdeField("G3OPIM", "G3OPIM", JdeDataType.String, 30),
        new JdeField("G3RCOC", "G3RCOC", JdeDataType.String, 6),
        new JdeField("G3LNIX", "G3LNIX", JdeDataType.Numeric),
        new JdeField("G3PID", "G3PID", JdeDataType.String, 20),
        new JdeField("G3USER", "G3USER", JdeDataType.String, 20),
        new JdeField("G3JOBN", "G3JOBN", JdeDataType.String, 20),
        new JdeField("G3UPMJ", "G3UPMJ", JdeDataType.Numeric),
        new JdeField("G3UPMT", "G3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5213_0", "Primary Key on G3DOCO, G3DCTO, G3KCOO, G3COCH, G3LNID, G3LIN", new[] { "G3DOCO", "G3DCTO", "G3KCOO", "G3COCH", "G3LNID", "G3LIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5213_2", "Index on G3DOCO, G3DCTO, G3KCOO, G3COCH, G3LNID, G3RCOC", new[] { "G3DOCO", "G3DCTO", "G3KCOO", "G3COCH", "G3LNID", "G3RCOC" }),
        new JdeIndex("F5213_3", "Index on G3DOCO, G3DCTO, G3KCOO, G3RCOC, G3OPIM", new[] { "G3DOCO", "G3DCTO", "G3KCOO", "G3RCOC", "G3OPIM" }),
        new JdeIndex("F5213_4", "Index on G3DOCO, G3DCTO, G3KCOO", new[] { "G3DOCO", "G3DCTO", "G3KCOO" })
    };
}
