using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D107A - .
/// </summary>
public class F80D107A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GTMETRIC.
        /// </summary>
        public const string GTMETRIC = "GTMETRIC";

        /// <summary>
        /// GTGDDV1.
        /// </summary>
        public const string GTGDDV1 = "GTGDDV1";

        /// <summary>
        /// GTGDDV2.
        /// </summary>
        public const string GTGDDV2 = "GTGDDV2";

        /// <summary>
        /// GTGDDV3.
        /// </summary>
        public const string GTGDDV3 = "GTGDDV3";

        /// <summary>
        /// GTGDDV4.
        /// </summary>
        public const string GTGDDV4 = "GTGDDV4";

        /// <summary>
        /// GTGDDV5.
        /// </summary>
        public const string GTGDDV5 = "GTGDDV5";

        /// <summary>
        /// GTGDDV6.
        /// </summary>
        public const string GTGDDV6 = "GTGDDV6";

        /// <summary>
        /// GTFMONTH.
        /// </summary>
        public const string GTFMONTH = "GTFMONTH";

        /// <summary>
        /// GTFYEAR.
        /// </summary>
        public const string GTFYEAR = "GTFYEAR";

        /// <summary>
        /// GTGOALVAL2.
        /// </summary>
        public const string GTGOALVAL2 = "GTGOALVAL2";

        /// <summary>
        /// GTUSER.
        /// </summary>
        public const string GTUSER = "GTUSER";

        /// <summary>
        /// GTPID.
        /// </summary>
        public const string GTPID = "GTPID";

        /// <summary>
        /// GTMKEY.
        /// </summary>
        public const string GTMKEY = "GTMKEY";

        /// <summary>
        /// GTUUPMJ.
        /// </summary>
        public const string GTUUPMJ = "GTUUPMJ";

        /// <summary>
        /// GTURCD.
        /// </summary>
        public const string GTURCD = "GTURCD";

        /// <summary>
        /// GTURDT.
        /// </summary>
        public const string GTURDT = "GTURDT";

        /// <summary>
        /// GTURAT.
        /// </summary>
        public const string GTURAT = "GTURAT";

        /// <summary>
        /// GTURAB.
        /// </summary>
        public const string GTURAB = "GTURAB";

        /// <summary>
        /// GTURRF.
        /// </summary>
        public const string GTURRF = "GTURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D107A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GTMETRIC", "GTMETRIC", JdeDataType.Numeric, null, true, true),
        new JdeField("GTGDDV1", "GTGDDV1", JdeDataType.String, 30, true, true),
        new JdeField("GTGDDV2", "GTGDDV2", JdeDataType.String, 30, true, true),
        new JdeField("GTGDDV3", "GTGDDV3", JdeDataType.String, 30, true, true),
        new JdeField("GTGDDV4", "GTGDDV4", JdeDataType.String, 30, true, true),
        new JdeField("GTGDDV5", "GTGDDV5", JdeDataType.String, 30, true, true),
        new JdeField("GTGDDV6", "GTGDDV6", JdeDataType.String, 30, true, true),
        new JdeField("GTFMONTH", "GTFMONTH", JdeDataType.Numeric, null, true, true),
        new JdeField("GTFYEAR", "GTFYEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("GTGOALVAL2", "GTGOALVAL2", JdeDataType.Numeric),
        new JdeField("GTUSER", "GTUSER", JdeDataType.String, 20),
        new JdeField("GTPID", "GTPID", JdeDataType.String, 20),
        new JdeField("GTMKEY", "GTMKEY", JdeDataType.String, 30),
        new JdeField("GTUUPMJ", "GTUUPMJ", JdeDataType.Date),
        new JdeField("GTURCD", "GTURCD", JdeDataType.String, 4),
        new JdeField("GTURDT", "GTURDT", JdeDataType.Numeric),
        new JdeField("GTURAT", "GTURAT", JdeDataType.Numeric),
        new JdeField("GTURAB", "GTURAB", JdeDataType.Numeric),
        new JdeField("GTURRF", "GTURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D107A_0", "Primary Key on GTMETRIC, GTGDDV1, GTGDDV2, GTGDDV3, GTGDDV4, GTGDDV5, GTGDDV6, GTFMONTH, GTFYEAR", new[] { "GTMETRIC", "GTGDDV1", "GTGDDV2", "GTGDDV3", "GTGDDV4", "GTGDDV5", "GTGDDV6", "GTFMONTH", "GTFYEAR" }, isUnique: true, isPrimaryKey: true)
    };
}
