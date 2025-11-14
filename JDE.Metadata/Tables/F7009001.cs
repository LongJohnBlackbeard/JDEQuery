using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7009001 - .
/// </summary>
public class F7009001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CATAX.
        /// </summary>
        public const string CATAX = "CATAX";

        /// <summary>
        /// CAAID.
        /// </summary>
        public const string CAAID = "CAAID";

        /// <summary>
        /// CAK70PAID.
        /// </summary>
        public const string CAK70PAID = "CAK70PAID";

        /// <summary>
        /// CAK70PMCU.
        /// </summary>
        public const string CAK70PMCU = "CAK70PMCU";

        /// <summary>
        /// CAK70POBJ.
        /// </summary>
        public const string CAK70POBJ = "CAK70POBJ";

        /// <summary>
        /// CAK70PSUB.
        /// </summary>
        public const string CAK70PSUB = "CAK70PSUB";

        /// <summary>
        /// CAK70ALVL.
        /// </summary>
        public const string CAK70ALVL = "CAK70ALVL";

        /// <summary>
        /// CAK70PAID1.
        /// </summary>
        public const string CAK70PAID1 = "CAK70PAID1";

        /// <summary>
        /// CAK70PAID2.
        /// </summary>
        public const string CAK70PAID2 = "CAK70PAID2";

        /// <summary>
        /// CAK70PAID3.
        /// </summary>
        public const string CAK70PAID3 = "CAK70PAID3";

        /// <summary>
        /// CAK70PAID4.
        /// </summary>
        public const string CAK70PAID4 = "CAK70PAID4";

        /// <summary>
        /// CAK70PAID5.
        /// </summary>
        public const string CAK70PAID5 = "CAK70PAID5";

        /// <summary>
        /// CAK70PAID6.
        /// </summary>
        public const string CAK70PAID6 = "CAK70PAID6";

        /// <summary>
        /// CAK70PAID7.
        /// </summary>
        public const string CAK70PAID7 = "CAK70PAID7";

        /// <summary>
        /// CAK70AGRP.
        /// </summary>
        public const string CAK70AGRP = "CAK70AGRP";

        /// <summary>
        /// CAK70ALTP.
        /// </summary>
        public const string CAK70ALTP = "CAK70ALTP";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";

        /// <summary>
        /// CAUPMT.
        /// </summary>
        public const string CAUPMT = "CAUPMT";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F7009001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CATAX", "CATAX", JdeDataType.String, 40),
        new JdeField("CAAID", "CAAID", JdeDataType.String, 16, true, true),
        new JdeField("CAK70PAID", "CAK70PAID", JdeDataType.String, 16),
        new JdeField("CAK70PMCU", "CAK70PMCU", JdeDataType.String, 24),
        new JdeField("CAK70POBJ", "CAK70POBJ", JdeDataType.String, 12),
        new JdeField("CAK70PSUB", "CAK70PSUB", JdeDataType.String, 16),
        new JdeField("CAK70ALVL", "CAK70ALVL", JdeDataType.String, 2),
        new JdeField("CAK70PAID1", "CAK70PAID1", JdeDataType.String, 16),
        new JdeField("CAK70PAID2", "CAK70PAID2", JdeDataType.String, 16),
        new JdeField("CAK70PAID3", "CAK70PAID3", JdeDataType.String, 16),
        new JdeField("CAK70PAID4", "CAK70PAID4", JdeDataType.String, 16),
        new JdeField("CAK70PAID5", "CAK70PAID5", JdeDataType.String, 16),
        new JdeField("CAK70PAID6", "CAK70PAID6", JdeDataType.String, 16),
        new JdeField("CAK70PAID7", "CAK70PAID7", JdeDataType.String, 16),
        new JdeField("CAK70AGRP", "CAK70AGRP", JdeDataType.String, 20),
        new JdeField("CAK70ALTP", "CAK70ALTP", JdeDataType.String, 20),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20),
        new JdeField("CAUPMT", "CAUPMT", JdeDataType.Numeric),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7009001_0", "Primary Key on CAAID", new[] { "CAAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7009001_2", "Index on CATAX", new[] { "CATAX" })
    };
}
