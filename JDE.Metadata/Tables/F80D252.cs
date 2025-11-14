using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D252 - .
/// </summary>
public class F80D252 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PQPRDJ.
        /// </summary>
        public const string PQPRDJ = "PQPRDJ";

        /// <summary>
        /// PQMCU.
        /// </summary>
        public const string PQMCU = "PQMCU";

        /// <summary>
        /// PQAN8.
        /// </summary>
        public const string PQAN8 = "PQAN8";

        /// <summary>
        /// PQITM.
        /// </summary>
        public const string PQITM = "PQITM";

        /// <summary>
        /// PQTNRC.
        /// </summary>
        public const string PQTNRC = "PQTNRC";

        /// <summary>
        /// PQNFRC.
        /// </summary>
        public const string PQNFRC = "PQNFRC";

        /// <summary>
        /// PQUSER.
        /// </summary>
        public const string PQUSER = "PQUSER";

        /// <summary>
        /// PQPID.
        /// </summary>
        public const string PQPID = "PQPID";

        /// <summary>
        /// PQMKEY.
        /// </summary>
        public const string PQMKEY = "PQMKEY";

        /// <summary>
        /// PQUTIME.
        /// </summary>
        public const string PQUTIME = "PQUTIME";

        /// <summary>
        /// PQURCD.
        /// </summary>
        public const string PQURCD = "PQURCD";

        /// <summary>
        /// PQURDT.
        /// </summary>
        public const string PQURDT = "PQURDT";

        /// <summary>
        /// PQURAT.
        /// </summary>
        public const string PQURAT = "PQURAT";

        /// <summary>
        /// PQURAB.
        /// </summary>
        public const string PQURAB = "PQURAB";

        /// <summary>
        /// PQURRF.
        /// </summary>
        public const string PQURRF = "PQURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D252";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PQPRDJ", "PQPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PQMCU", "PQMCU", JdeDataType.String, 24, true, true),
        new JdeField("PQAN8", "PQAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PQITM", "PQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PQTNRC", "PQTNRC", JdeDataType.Numeric),
        new JdeField("PQNFRC", "PQNFRC", JdeDataType.Numeric),
        new JdeField("PQUSER", "PQUSER", JdeDataType.String, 20),
        new JdeField("PQPID", "PQPID", JdeDataType.String, 20),
        new JdeField("PQMKEY", "PQMKEY", JdeDataType.String, 30),
        new JdeField("PQUTIME", "PQUTIME", JdeDataType.Date),
        new JdeField("PQURCD", "PQURCD", JdeDataType.String, 4),
        new JdeField("PQURDT", "PQURDT", JdeDataType.Numeric),
        new JdeField("PQURAT", "PQURAT", JdeDataType.Numeric),
        new JdeField("PQURAB", "PQURAB", JdeDataType.Numeric),
        new JdeField("PQURRF", "PQURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D252_0", "Primary Key on PQPRDJ, PQMCU, PQAN8, PQITM", new[] { "PQPRDJ", "PQMCU", "PQAN8", "PQITM" }, isUnique: true, isPrimaryKey: true)
    };
}
