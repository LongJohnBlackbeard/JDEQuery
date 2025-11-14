using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77173 - .
/// </summary>
public class F77173 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JFAN8.
        /// </summary>
        public const string JFAN8 = "JFAN8";

        /// <summary>
        /// JFALPH.
        /// </summary>
        public const string JFALPH = "JFALPH";

        /// <summary>
        /// JFCO.
        /// </summary>
        public const string JFCO = "JFCO";

        /// <summary>
        /// JFPFRQ.
        /// </summary>
        public const string JFPFRQ = "JFPFRQ";

        /// <summary>
        /// JFIPAY.
        /// </summary>
        public const string JFIPAY = "JFIPAY";

        /// <summary>
        /// JFWDT.
        /// </summary>
        public const string JFWDT = "JFWDT";

        /// <summary>
        /// JFWKDT.
        /// </summary>
        public const string JFWKDT = "JFWKDT";

        /// <summary>
        /// JFDL01.
        /// </summary>
        public const string JFDL01 = "JFDL01";

        /// <summary>
        /// JFEUSR.
        /// </summary>
        public const string JFEUSR = "JFEUSR";

        /// <summary>
        /// JFTAXX.
        /// </summary>
        public const string JFTAXX = "JFTAXX";

        /// <summary>
        /// JFMATH01.
        /// </summary>
        public const string JFMATH01 = "JFMATH01";

        /// <summary>
        /// JFJOBN.
        /// </summary>
        public const string JFJOBN = "JFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F77173";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JFAN8", "JFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JFALPH", "JFALPH", JdeDataType.String, 80),
        new JdeField("JFCO", "JFCO", JdeDataType.String, 10, true, true),
        new JdeField("JFPFRQ", "JFPFRQ", JdeDataType.String, 2),
        new JdeField("JFIPAY", "JFIPAY", JdeDataType.Numeric),
        new JdeField("JFWDT", "JFWDT", JdeDataType.Numeric),
        new JdeField("JFWKDT", "JFWKDT", JdeDataType.Numeric),
        new JdeField("JFDL01", "JFDL01", JdeDataType.String, 60),
        new JdeField("JFEUSR", "JFEUSR", JdeDataType.String, 20, true, true),
        new JdeField("JFTAXX", "JFTAXX", JdeDataType.String, 40),
        new JdeField("JFMATH01", "JFMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("JFJOBN", "JFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77173_0", "Primary Key on JFCO, JFAN8, JFMATH01, JFEUSR", new[] { "JFCO", "JFAN8", "JFMATH01", "JFEUSR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F77173_2", "Index on JFJOBN, JFEUSR", new[] { "JFJOBN", "JFEUSR" })
    };
}
