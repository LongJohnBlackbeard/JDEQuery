using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76HUI50 - .
/// </summary>
public class F76HUI50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPH76LOPN.
        /// </summary>
        public const string LPH76LOPN = "LPH76LOPN";

        /// <summary>
        /// LPH76LECO.
        /// </summary>
        public const string LPH76LECO = "LPH76LECO";

        /// <summary>
        /// LPH76LEDT.
        /// </summary>
        public const string LPH76LEDT = "LPH76LEDT";

        /// <summary>
        /// LPH76EMS.
        /// </summary>
        public const string LPH76EMS = "LPH76EMS";

        /// <summary>
        /// LPH76SEQ.
        /// </summary>
        public const string LPH76SEQ = "LPH76SEQ";

        /// <summary>
        /// LPH76NNFR.
        /// </summary>
        public const string LPH76NNFR = "LPH76NNFR";

        /// <summary>
        /// LPH76NNTO.
        /// </summary>
        public const string LPH76NNTO = "LPH76NNTO";

        /// <summary>
        /// LPH76NN.
        /// </summary>
        public const string LPH76NN = "LPH76NN";

        /// <summary>
        /// LPH76NNST.
        /// </summary>
        public const string LPH76NNST = "LPH76NNST";

        /// <summary>
        /// LPH76QTYI.
        /// </summary>
        public const string LPH76QTYI = "LPH76QTYI";
    }

    /// <inheritdoc />
    public override string TableName => "F76HUI50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPH76LOPN", "LPH76LOPN", JdeDataType.Numeric, null, true, true),
        new JdeField("LPH76LECO", "LPH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("LPH76LEDT", "LPH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("LPH76EMS", "LPH76EMS", JdeDataType.String, 8, true, true),
        new JdeField("LPH76SEQ", "LPH76SEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LPH76NNFR", "LPH76NNFR", JdeDataType.Numeric),
        new JdeField("LPH76NNTO", "LPH76NNTO", JdeDataType.Numeric),
        new JdeField("LPH76NN", "LPH76NN", JdeDataType.Numeric),
        new JdeField("LPH76NNST", "LPH76NNST", JdeDataType.String, 2),
        new JdeField("LPH76QTYI", "LPH76QTYI", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76HUI50_0", "Primary Key on LPH76LOPN, LPH76LECO, LPH76LEDT, LPH76EMS, LPH76SEQ", new[] { "LPH76LOPN", "LPH76LECO", "LPH76LEDT", "LPH76EMS", "LPH76SEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
