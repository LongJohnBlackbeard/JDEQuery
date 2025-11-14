using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49197 - .
/// </summary>
public class F49197 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OQVMCU.
        /// </summary>
        public const string OQVMCU = "OQVMCU";

        /// <summary>
        /// OQDCCD.
        /// </summary>
        public const string OQDCCD = "OQDCCD";

        /// <summary>
        /// OQOUT1.
        /// </summary>
        public const string OQOUT1 = "OQOUT1";

        /// <summary>
        /// OQOUT2.
        /// </summary>
        public const string OQOUT2 = "OQOUT2";

        /// <summary>
        /// OQOUT3.
        /// </summary>
        public const string OQOUT3 = "OQOUT3";

        /// <summary>
        /// OQFID.
        /// </summary>
        public const string OQFID = "OQFID";

        /// <summary>
        /// OQFID2.
        /// </summary>
        public const string OQFID2 = "OQFID2";

        /// <summary>
        /// OQDPCR.
        /// </summary>
        public const string OQDPCR = "OQDPCR";

        /// <summary>
        /// OQDPCA.
        /// </summary>
        public const string OQDPCA = "OQDPCA";

        /// <summary>
        /// OQDCNS.
        /// </summary>
        public const string OQDCNS = "OQDCNS";

        /// <summary>
        /// OQCO.
        /// </summary>
        public const string OQCO = "OQCO";

        /// <summary>
        /// OQEMCU.
        /// </summary>
        public const string OQEMCU = "OQEMCU";

        /// <summary>
        /// OQMCU.
        /// </summary>
        public const string OQMCU = "OQMCU";

        /// <summary>
        /// OQUSER.
        /// </summary>
        public const string OQUSER = "OQUSER";

        /// <summary>
        /// OQPID.
        /// </summary>
        public const string OQPID = "OQPID";

        /// <summary>
        /// OQJOBN.
        /// </summary>
        public const string OQJOBN = "OQJOBN";

        /// <summary>
        /// OQUPMJ.
        /// </summary>
        public const string OQUPMJ = "OQUPMJ";

        /// <summary>
        /// OQTDAY.
        /// </summary>
        public const string OQTDAY = "OQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49197";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OQVMCU", "OQVMCU", JdeDataType.String, 24, true, true),
        new JdeField("OQDCCD", "OQDCCD", JdeDataType.String, 8, true, true),
        new JdeField("OQOUT1", "OQOUT1", JdeDataType.String, 20),
        new JdeField("OQOUT2", "OQOUT2", JdeDataType.String, 20),
        new JdeField("OQOUT3", "OQOUT3", JdeDataType.String, 20),
        new JdeField("OQFID", "OQFID", JdeDataType.String, 20),
        new JdeField("OQFID2", "OQFID2", JdeDataType.String, 20),
        new JdeField("OQDPCR", "OQDPCR", JdeDataType.String, 2),
        new JdeField("OQDPCA", "OQDPCA", JdeDataType.Numeric),
        new JdeField("OQDCNS", "OQDCNS", JdeDataType.String, 2),
        new JdeField("OQCO", "OQCO", JdeDataType.String, 10),
        new JdeField("OQEMCU", "OQEMCU", JdeDataType.String, 24),
        new JdeField("OQMCU", "OQMCU", JdeDataType.String, 24),
        new JdeField("OQUSER", "OQUSER", JdeDataType.String, 20),
        new JdeField("OQPID", "OQPID", JdeDataType.String, 20),
        new JdeField("OQJOBN", "OQJOBN", JdeDataType.String, 20),
        new JdeField("OQUPMJ", "OQUPMJ", JdeDataType.Numeric),
        new JdeField("OQTDAY", "OQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49197_0", "Primary Key on OQVMCU, OQDCCD", new[] { "OQVMCU", "OQDCCD" }, isUnique: true, isPrimaryKey: true)
    };
}
