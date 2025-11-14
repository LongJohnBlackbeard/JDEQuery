using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D111 - .
/// </summary>
public class F80D111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FQSSBID.
        /// </summary>
        public const string FQSSBID = "FQSSBID";

        /// <summary>
        /// FQCO.
        /// </summary>
        public const string FQCO = "FQCO";

        /// <summary>
        /// FQBLISTID.
        /// </summary>
        public const string FQBLISTID = "FQBLISTID";

        /// <summary>
        /// FQALISTID.
        /// </summary>
        public const string FQALISTID = "FQALISTID";

        /// <summary>
        /// FQBDOWLD.
        /// </summary>
        public const string FQBDOWLD = "FQBDOWLD";

        /// <summary>
        /// FQDATEFT.
        /// </summary>
        public const string FQDATEFT = "FQDATEFT";

        /// <summary>
        /// FQCDR.
        /// </summary>
        public const string FQCDR = "FQCDR";

        /// <summary>
        /// FQBODO.
        /// </summary>
        public const string FQBODO = "FQBODO";

        /// <summary>
        /// FQUSER.
        /// </summary>
        public const string FQUSER = "FQUSER";

        /// <summary>
        /// FQPID.
        /// </summary>
        public const string FQPID = "FQPID";

        /// <summary>
        /// FQMKEY.
        /// </summary>
        public const string FQMKEY = "FQMKEY";

        /// <summary>
        /// FQUTIME.
        /// </summary>
        public const string FQUTIME = "FQUTIME";

        /// <summary>
        /// FQURCD.
        /// </summary>
        public const string FQURCD = "FQURCD";

        /// <summary>
        /// FQURDT.
        /// </summary>
        public const string FQURDT = "FQURDT";

        /// <summary>
        /// FQODA.
        /// </summary>
        public const string FQODA = "FQODA";

        /// <summary>
        /// FQURAT.
        /// </summary>
        public const string FQURAT = "FQURAT";

        /// <summary>
        /// FQURAB.
        /// </summary>
        public const string FQURAB = "FQURAB";

        /// <summary>
        /// FQURRF.
        /// </summary>
        public const string FQURRF = "FQURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FQSSBID", "FQSSBID", JdeDataType.String, 16, true, true),
        new JdeField("FQCO", "FQCO", JdeDataType.String, 10),
        new JdeField("FQBLISTID", "FQBLISTID", JdeDataType.String, 24),
        new JdeField("FQALISTID", "FQALISTID", JdeDataType.String, 24),
        new JdeField("FQBDOWLD", "FQBDOWLD", JdeDataType.Numeric),
        new JdeField("FQDATEFT", "FQDATEFT", JdeDataType.Numeric),
        new JdeField("FQCDR", "FQCDR", JdeDataType.Numeric),
        new JdeField("FQBODO", "FQBODO", JdeDataType.Numeric),
        new JdeField("FQUSER", "FQUSER", JdeDataType.String, 20),
        new JdeField("FQPID", "FQPID", JdeDataType.String, 20),
        new JdeField("FQMKEY", "FQMKEY", JdeDataType.String, 30),
        new JdeField("FQUTIME", "FQUTIME", JdeDataType.Date),
        new JdeField("FQURCD", "FQURCD", JdeDataType.String, 4),
        new JdeField("FQURDT", "FQURDT", JdeDataType.Numeric),
        new JdeField("FQODA", "FQODA", JdeDataType.Numeric),
        new JdeField("FQURAT", "FQURAT", JdeDataType.Numeric),
        new JdeField("FQURAB", "FQURAB", JdeDataType.Numeric),
        new JdeField("FQURRF", "FQURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D111_0", "Primary Key on FQSSBID", new[] { "FQSSBID" }, isUnique: true, isPrimaryKey: true)
    };
}
