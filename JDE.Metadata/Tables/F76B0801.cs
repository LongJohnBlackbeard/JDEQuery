using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0801 - .
/// </summary>
public class F76B0801 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMB76ATCT.
        /// </summary>
        public const string IMB76ATCT = "IMB76ATCT";

        /// <summary>
        /// IMJOBS.
        /// </summary>
        public const string IMJOBS = "IMJOBS";

        /// <summary>
        /// IMB76BLCK.
        /// </summary>
        public const string IMB76BLCK = "IMB76BLCK";

        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

        /// <summary>
        /// IMB76URAB.
        /// </summary>
        public const string IMB76URAB = "IMB76URAB";

        /// <summary>
        /// IMB76URAT.
        /// </summary>
        public const string IMB76URAT = "IMB76URAT";

        /// <summary>
        /// IMB76URRF.
        /// </summary>
        public const string IMB76URRF = "IMB76URRF";

        /// <summary>
        /// IMB76URDT.
        /// </summary>
        public const string IMB76URDT = "IMB76URDT";

        /// <summary>
        /// IMB76URCD.
        /// </summary>
        public const string IMB76URCD = "IMB76URCD";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMPID.
        /// </summary>
        public const string IMPID = "IMPID";

        /// <summary>
        /// IMJOBN.
        /// </summary>
        public const string IMJOBN = "IMJOBN";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMUPMT.
        /// </summary>
        public const string IMUPMT = "IMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0801";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMB76ATCT", "IMB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("IMJOBS", "IMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("IMB76BLCK", "IMB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMB76URAB", "IMB76URAB", JdeDataType.Numeric),
        new JdeField("IMB76URAT", "IMB76URAT", JdeDataType.Numeric),
        new JdeField("IMB76URRF", "IMB76URRF", JdeDataType.String, 30),
        new JdeField("IMB76URDT", "IMB76URDT", JdeDataType.Numeric),
        new JdeField("IMB76URCD", "IMB76URCD", JdeDataType.String, 4),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMUPMT", "IMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0801_0", "Primary Key on IMB76ATCT, IMJOBS, IMB76BLCK, IMITM", new[] { "IMB76ATCT", "IMJOBS", "IMB76BLCK", "IMITM" }, isUnique: true, isPrimaryKey: true)
    };
}
