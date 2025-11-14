using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186402 - .
/// </summary>
public class F186402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ORLRSORID.
        /// </summary>
        public const string ORLRSORID = "ORLRSORID";

        /// <summary>
        /// ORLRSORSID.
        /// </summary>
        public const string ORLRSORSID = "ORLRSORSID";

        /// <summary>
        /// ORLRSORN.
        /// </summary>
        public const string ORLRSORN = "ORLRSORN";

        /// <summary>
        /// ORLRSORPO.
        /// </summary>
        public const string ORLRSORPO = "ORLRSORPO";

        /// <summary>
        /// ORLRSORT.
        /// </summary>
        public const string ORLRSORT = "ORLRSORT";

        /// <summary>
        /// ORUSER.
        /// </summary>
        public const string ORUSER = "ORUSER";

        /// <summary>
        /// ORPID.
        /// </summary>
        public const string ORPID = "ORPID";

        /// <summary>
        /// ORJOBN.
        /// </summary>
        public const string ORJOBN = "ORJOBN";

        /// <summary>
        /// ORUPMJ.
        /// </summary>
        public const string ORUPMJ = "ORUPMJ";

        /// <summary>
        /// ORTDAY.
        /// </summary>
        public const string ORTDAY = "ORTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ORLRSORID", "ORLRSORID", JdeDataType.Numeric, null, true, true),
        new JdeField("ORLRSORSID", "ORLRSORSID", JdeDataType.Numeric),
        new JdeField("ORLRSORN", "ORLRSORN", JdeDataType.String, 60),
        new JdeField("ORLRSORPO", "ORLRSORPO", JdeDataType.Numeric),
        new JdeField("ORLRSORT", "ORLRSORT", JdeDataType.String, 20),
        new JdeField("ORUSER", "ORUSER", JdeDataType.String, 20),
        new JdeField("ORPID", "ORPID", JdeDataType.String, 20),
        new JdeField("ORJOBN", "ORJOBN", JdeDataType.String, 20),
        new JdeField("ORUPMJ", "ORUPMJ", JdeDataType.Numeric),
        new JdeField("ORTDAY", "ORTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186402_0", "Primary Key on ORLRSORID", new[] { "ORLRSORID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186402_2", "Index on ORLRSORSID", new[] { "ORLRSORSID" })
    };
}
