using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1533 - .
/// </summary>
public class F1533 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NMDOCO.
        /// </summary>
        public const string NMDOCO = "NMDOCO";

        /// <summary>
        /// NMDCTO.
        /// </summary>
        public const string NMDCTO = "NMDCTO";

        /// <summary>
        /// NMEPCL.
        /// </summary>
        public const string NMEPCL = "NMEPCL";

        /// <summary>
        /// NMAID.
        /// </summary>
        public const string NMAID = "NMAID";

        /// <summary>
        /// NMPCTP.
        /// </summary>
        public const string NMPCTP = "NMPCTP";

        /// <summary>
        /// NMEFTB.
        /// </summary>
        public const string NMEFTB = "NMEFTB";

        /// <summary>
        /// NMEFTE.
        /// </summary>
        public const string NMEFTE = "NMEFTE";

        /// <summary>
        /// NMUSER.
        /// </summary>
        public const string NMUSER = "NMUSER";

        /// <summary>
        /// NMUPMJ.
        /// </summary>
        public const string NMUPMJ = "NMUPMJ";

        /// <summary>
        /// NMPID.
        /// </summary>
        public const string NMPID = "NMPID";

        /// <summary>
        /// NMJOBN.
        /// </summary>
        public const string NMJOBN = "NMJOBN";

        /// <summary>
        /// NMUPMT.
        /// </summary>
        public const string NMUPMT = "NMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1533";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NMDOCO", "NMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NMDCTO", "NMDCTO", JdeDataType.String, 4),
        new JdeField("NMEPCL", "NMEPCL", JdeDataType.String, 8, true, true),
        new JdeField("NMAID", "NMAID", JdeDataType.String, 16, true, true),
        new JdeField("NMPCTP", "NMPCTP", JdeDataType.Numeric),
        new JdeField("NMEFTB", "NMEFTB", JdeDataType.Numeric),
        new JdeField("NMEFTE", "NMEFTE", JdeDataType.Numeric),
        new JdeField("NMUSER", "NMUSER", JdeDataType.String, 20),
        new JdeField("NMUPMJ", "NMUPMJ", JdeDataType.Numeric),
        new JdeField("NMPID", "NMPID", JdeDataType.String, 20),
        new JdeField("NMJOBN", "NMJOBN", JdeDataType.String, 20),
        new JdeField("NMUPMT", "NMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1533_0", "Primary Key on NMDOCO, NMEPCL, NMAID", new[] { "NMDOCO", "NMEPCL", "NMAID" }, isUnique: true, isPrimaryKey: true)
    };
}
