using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74SUI60 - .
/// </summary>
public class F74SUI60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERS74TER.
        /// </summary>
        public const string ERS74TER = "ERS74TER";

        /// <summary>
        /// ERAG.
        /// </summary>
        public const string ERAG = "ERAG";

        /// <summary>
        /// ERJOBS.
        /// </summary>
        public const string ERJOBS = "ERJOBS";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";

        /// <summary>
        /// ERS74FUT01.
        /// </summary>
        public const string ERS74FUT01 = "ERS74FUT01";

        /// <summary>
        /// ERS74FUT02.
        /// </summary>
        public const string ERS74FUT02 = "ERS74FUT02";

        /// <summary>
        /// ERS74FUT03.
        /// </summary>
        public const string ERS74FUT03 = "ERS74FUT03";

        /// <summary>
        /// ERS74FUT04.
        /// </summary>
        public const string ERS74FUT04 = "ERS74FUT04";

        /// <summary>
        /// ERS74FUT05.
        /// </summary>
        public const string ERS74FUT05 = "ERS74FUT05";
    }

    /// <inheritdoc />
    public override string TableName => "F74SUI60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERS74TER", "ERS74TER", JdeDataType.String, 40, true, true),
        new JdeField("ERAG", "ERAG", JdeDataType.Numeric),
        new JdeField("ERJOBS", "ERJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20, true, true),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric),
        new JdeField("ERS74FUT01", "ERS74FUT01", JdeDataType.Numeric),
        new JdeField("ERS74FUT02", "ERS74FUT02", JdeDataType.String, 60),
        new JdeField("ERS74FUT03", "ERS74FUT03", JdeDataType.String, 2),
        new JdeField("ERS74FUT04", "ERS74FUT04", JdeDataType.String, 2),
        new JdeField("ERS74FUT05", "ERS74FUT05", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74SUI60_0", "Primary Key on ERS74TER, ERJOBS, ERUSER", new[] { "ERS74TER", "ERJOBS", "ERUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74SUI60_2", "Index on ERJOBS, ERUSER", new[] { "ERJOBS", "ERUSER" })
    };
}
