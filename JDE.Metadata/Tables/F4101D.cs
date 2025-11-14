using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101D - .
/// </summary>
public class F4101D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

        /// <summary>
        /// IMLITM.
        /// </summary>
        public const string IMLITM = "IMLITM";

        /// <summary>
        /// IMAITM.
        /// </summary>
        public const string IMAITM = "IMAITM";

        /// <summary>
        /// IMLNGP.
        /// </summary>
        public const string IMLNGP = "IMLNGP";

        /// <summary>
        /// IMDSC1.
        /// </summary>
        public const string IMDSC1 = "IMDSC1";

        /// <summary>
        /// IMDSC2.
        /// </summary>
        public const string IMDSC2 = "IMDSC2";

        /// <summary>
        /// IMSRTX.
        /// </summary>
        public const string IMSRTX = "IMSRTX";

        /// <summary>
        /// IMALN.
        /// </summary>
        public const string IMALN = "IMALN";

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
        /// IMTDAY.
        /// </summary>
        public const string IMTDAY = "IMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4101D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMLITM", "IMLITM", JdeDataType.String, 50),
        new JdeField("IMAITM", "IMAITM", JdeDataType.String, 50),
        new JdeField("IMLNGP", "IMLNGP", JdeDataType.String, 4, true, true),
        new JdeField("IMDSC1", "IMDSC1", JdeDataType.String, 60),
        new JdeField("IMDSC2", "IMDSC2", JdeDataType.String, 60),
        new JdeField("IMSRTX", "IMSRTX", JdeDataType.String, 60),
        new JdeField("IMALN", "IMALN", JdeDataType.String, 60),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101D_0", "Primary Key on IMITM, IMLNGP", new[] { "IMITM", "IMLNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4101D_1", "Index on IMLNGP, IMITM", new[] { "IMLNGP", "IMITM" }),
        new JdeIndex("F4101D_2", "Index on IMLNGP, IMALN", new[] { "IMLNGP", "IMALN" }),
        new JdeIndex("F4101D_4", "Index on IMDSC1", new[] { "IMDSC1" }),
        new JdeIndex("F4101D_5", "Index on IMLITM", new[] { "IMLITM" }),
        new JdeIndex("F4101D_6", "Index on IMAITM", new[] { "IMAITM" })
    };
}
