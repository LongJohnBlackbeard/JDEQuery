using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08214 - .
/// </summary>
public class F08214 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THUTID.
        /// </summary>
        public const string THUTID = "THUTID";

        /// <summary>
        /// THUTIR.
        /// </summary>
        public const string THUTIR = "THUTIR";

        /// <summary>
        /// THSPACUSO1.
        /// </summary>
        public const string THSPACUSO1 = "THSPACUSO1";

        /// <summary>
        /// THSPACUSO2.
        /// </summary>
        public const string THSPACUSO2 = "THSPACUSO2";

        /// <summary>
        /// THSPADUSO1.
        /// </summary>
        public const string THSPADUSO1 = "THSPADUSO1";

        /// <summary>
        /// THSPADUSO2.
        /// </summary>
        public const string THSPADUSO2 = "THSPADUSO2";

        /// <summary>
        /// THSPANUSO1.
        /// </summary>
        public const string THSPANUSO1 = "THSPANUSO1";

        /// <summary>
        /// THSPANUSO2.
        /// </summary>
        public const string THSPANUSO2 = "THSPANUSO2";

        /// <summary>
        /// THSPASUSO1.
        /// </summary>
        public const string THSPASUSO1 = "THSPASUSO1";

        /// <summary>
        /// THSPASUSO2.
        /// </summary>
        public const string THSPASUSO2 = "THSPASUSO2";

        /// <summary>
        /// THSPASUSO3.
        /// </summary>
        public const string THSPASUSO3 = "THSPASUSO3";

        /// <summary>
        /// THSPASUSO4.
        /// </summary>
        public const string THSPASUSO4 = "THSPASUSO4";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08214";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THUTID", "THUTID", JdeDataType.String, 102, true, true),
        new JdeField("THUTIR", "THUTIR", JdeDataType.String, 102),
        new JdeField("THSPACUSO1", "THSPACUSO1", JdeDataType.String, 2),
        new JdeField("THSPACUSO2", "THSPACUSO2", JdeDataType.String, 2),
        new JdeField("THSPADUSO1", "THSPADUSO1", JdeDataType.Numeric),
        new JdeField("THSPADUSO2", "THSPADUSO2", JdeDataType.Numeric),
        new JdeField("THSPANUSO1", "THSPANUSO1", JdeDataType.Numeric),
        new JdeField("THSPANUSO2", "THSPANUSO2", JdeDataType.Numeric),
        new JdeField("THSPASUSO1", "THSPASUSO1", JdeDataType.String, 60),
        new JdeField("THSPASUSO2", "THSPASUSO2", JdeDataType.String, 60),
        new JdeField("THSPASUSO3", "THSPASUSO3", JdeDataType.String, 16),
        new JdeField("THSPASUSO4", "THSPASUSO4", JdeDataType.String, 16),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08214_0", "Primary Key on THUTID", new[] { "THUTID" }, isUnique: true, isPrimaryKey: true)
    };
}
