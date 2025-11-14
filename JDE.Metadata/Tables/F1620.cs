using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1620 - .
/// </summary>
public class F1620 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTABT1.
        /// </summary>
        public const string CTABT1 = "CTABT1";

        /// <summary>
        /// CTDL01.
        /// </summary>
        public const string CTDL01 = "CTDL01";

        /// <summary>
        /// CTCMER.
        /// </summary>
        public const string CTCMER = "CTCMER";

        /// <summary>
        /// CTFILE.
        /// </summary>
        public const string CTFILE = "CTFILE";

        /// <summary>
        /// CTDTAI.
        /// </summary>
        public const string CTDTAI = "CTDTAI";

        /// <summary>
        /// CTVALR.
        /// </summary>
        public const string CTVALR = "CTVALR";

        /// <summary>
        /// CTCMVL.
        /// </summary>
        public const string CTCMVL = "CTCMVL";

        /// <summary>
        /// CTSY.
        /// </summary>
        public const string CTSY = "CTSY";

        /// <summary>
        /// CTRT.
        /// </summary>
        public const string CTRT = "CTRT";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1620";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTABT1", "CTABT1", JdeDataType.String, 2, true, true),
        new JdeField("CTDL01", "CTDL01", JdeDataType.String, 60),
        new JdeField("CTCMER", "CTCMER", JdeDataType.String, 2),
        new JdeField("CTFILE", "CTFILE", JdeDataType.String, 20),
        new JdeField("CTDTAI", "CTDTAI", JdeDataType.String, 20),
        new JdeField("CTVALR", "CTVALR", JdeDataType.String, 4),
        new JdeField("CTCMVL", "CTCMVL", JdeDataType.String, 20),
        new JdeField("CTSY", "CTSY", JdeDataType.String, 8),
        new JdeField("CTRT", "CTRT", JdeDataType.String, 4),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1620_0", "Primary Key on CTABT1", new[] { "CTABT1" }, isUnique: true, isPrimaryKey: true)
    };
}
