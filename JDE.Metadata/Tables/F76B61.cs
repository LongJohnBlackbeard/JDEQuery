using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B61 - .
/// </summary>
public class F76B61 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IECO.
        /// </summary>
        public const string IECO = "IECO";

        /// <summary>
        /// IELITM.
        /// </summary>
        public const string IELITM = "IELITM";

        /// <summary>
        /// IEAITM.
        /// </summary>
        public const string IEAITM = "IEAITM";

        /// <summary>
        /// IETYRD.
        /// </summary>
        public const string IETYRD = "IETYRD";

        /// <summary>
        /// IEUORG.
        /// </summary>
        public const string IEUORG = "IEUORG";

        /// <summary>
        /// IEUM.
        /// </summary>
        public const string IEUM = "IEUM";

        /// <summary>
        /// IESCRP.
        /// </summary>
        public const string IESCRP = "IESCRP";

        /// <summary>
        /// IEASJ.
        /// </summary>
        public const string IEASJ = "IEASJ";

        /// <summary>
        /// IEEFTE.
        /// </summary>
        public const string IEEFTE = "IEEFTE";

        /// <summary>
        /// IEUSER.
        /// </summary>
        public const string IEUSER = "IEUSER";

        /// <summary>
        /// IEEAP.
        /// </summary>
        public const string IEEAP = "IEEAP";

        /// <summary>
        /// IEJOBN.
        /// </summary>
        public const string IEJOBN = "IEJOBN";

        /// <summary>
        /// IEUPMJ.
        /// </summary>
        public const string IEUPMJ = "IEUPMJ";

        /// <summary>
        /// IEUPMT.
        /// </summary>
        public const string IEUPMT = "IEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B61";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IECO", "IECO", JdeDataType.String, 10, true, true),
        new JdeField("IELITM", "IELITM", JdeDataType.String, 50, true, true),
        new JdeField("IEAITM", "IEAITM", JdeDataType.String, 50, true, true),
        new JdeField("IETYRD", "IETYRD", JdeDataType.String, 2),
        new JdeField("IEUORG", "IEUORG", JdeDataType.Numeric),
        new JdeField("IEUM", "IEUM", JdeDataType.String, 4),
        new JdeField("IESCRP", "IESCRP", JdeDataType.Numeric),
        new JdeField("IEASJ", "IEASJ", JdeDataType.Numeric),
        new JdeField("IEEFTE", "IEEFTE", JdeDataType.Numeric),
        new JdeField("IEUSER", "IEUSER", JdeDataType.String, 20),
        new JdeField("IEEAP", "IEEAP", JdeDataType.String, 20),
        new JdeField("IEJOBN", "IEJOBN", JdeDataType.String, 20),
        new JdeField("IEUPMJ", "IEUPMJ", JdeDataType.Numeric),
        new JdeField("IEUPMT", "IEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B61_0", "Primary Key on IECO, IELITM, IEAITM", new[] { "IECO", "IELITM", "IEAITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B61_2", "Index on IECO, IELITM", new[] { "IECO", "IELITM" })
    };
}
