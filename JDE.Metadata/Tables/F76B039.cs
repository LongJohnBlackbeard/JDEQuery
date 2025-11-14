using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B039 - .
/// </summary>
public class F76B039 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SRKCOO.
        /// </summary>
        public const string SRKCOO = "SRKCOO";

        /// <summary>
        /// SRDOCO.
        /// </summary>
        public const string SRDOCO = "SRDOCO";

        /// <summary>
        /// SRDCTO.
        /// </summary>
        public const string SRDCTO = "SRDCTO";

        /// <summary>
        /// SRB76MOTY.
        /// </summary>
        public const string SRB76MOTY = "SRB76MOTY";

        /// <summary>
        /// SRB76URAB.
        /// </summary>
        public const string SRB76URAB = "SRB76URAB";

        /// <summary>
        /// SRB76URAT.
        /// </summary>
        public const string SRB76URAT = "SRB76URAT";

        /// <summary>
        /// SRB76URRF.
        /// </summary>
        public const string SRB76URRF = "SRB76URRF";

        /// <summary>
        /// SRB76URDT.
        /// </summary>
        public const string SRB76URDT = "SRB76URDT";

        /// <summary>
        /// SRB76URCD.
        /// </summary>
        public const string SRB76URCD = "SRB76URCD";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRJOBN.
        /// </summary>
        public const string SRJOBN = "SRJOBN";

        /// <summary>
        /// SRUPMJ.
        /// </summary>
        public const string SRUPMJ = "SRUPMJ";

        /// <summary>
        /// SRUPMT.
        /// </summary>
        public const string SRUPMT = "SRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B039";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SRKCOO", "SRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SRDOCO", "SRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SRDCTO", "SRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SRB76MOTY", "SRB76MOTY", JdeDataType.String, 4),
        new JdeField("SRB76URAB", "SRB76URAB", JdeDataType.Numeric),
        new JdeField("SRB76URAT", "SRB76URAT", JdeDataType.Numeric),
        new JdeField("SRB76URRF", "SRB76URRF", JdeDataType.String, 30),
        new JdeField("SRB76URDT", "SRB76URDT", JdeDataType.Numeric),
        new JdeField("SRB76URCD", "SRB76URCD", JdeDataType.String, 4),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRJOBN", "SRJOBN", JdeDataType.String, 20),
        new JdeField("SRUPMJ", "SRUPMJ", JdeDataType.Numeric),
        new JdeField("SRUPMT", "SRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B039_0", "Primary Key on SRKCOO, SRDOCO, SRDCTO", new[] { "SRKCOO", "SRDOCO", "SRDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
