using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77230 - .
/// </summary>
public class F77230 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J8TAXYR.
        /// </summary>
        public const string J8TAXYR = "J8TAXYR";

        /// <summary>
        /// J8HMCO.
        /// </summary>
        public const string J8HMCO = "J8HMCO";

        /// <summary>
        /// J8TAXX.
        /// </summary>
        public const string J8TAXX = "J8TAXX";

        /// <summary>
        /// J8TARA.
        /// </summary>
        public const string J8TARA = "J8TARA";

        /// <summary>
        /// J8AN8.
        /// </summary>
        public const string J8AN8 = "J8AN8";

        /// <summary>
        /// J8BOXN.
        /// </summary>
        public const string J8BOXN = "J8BOXN";

        /// <summary>
        /// J8YEID.
        /// </summary>
        public const string J8YEID = "J8YEID";

        /// <summary>
        /// J8T4PP.
        /// </summary>
        public const string J8T4PP = "J8T4PP";

        /// <summary>
        /// J8AMNT.
        /// </summary>
        public const string J8AMNT = "J8AMNT";

        /// <summary>
        /// J8T4AP.
        /// </summary>
        public const string J8T4AP = "J8T4AP";

        /// <summary>
        /// J8PRCSD.
        /// </summary>
        public const string J8PRCSD = "J8PRCSD";

        /// <summary>
        /// J8UPMJ.
        /// </summary>
        public const string J8UPMJ = "J8UPMJ";

        /// <summary>
        /// J8UPMT.
        /// </summary>
        public const string J8UPMT = "J8UPMT";

        /// <summary>
        /// J8PID.
        /// </summary>
        public const string J8PID = "J8PID";

        /// <summary>
        /// J8JOBN.
        /// </summary>
        public const string J8JOBN = "J8JOBN";

        /// <summary>
        /// J8USER.
        /// </summary>
        public const string J8USER = "J8USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77230";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J8TAXYR", "J8TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J8HMCO", "J8HMCO", JdeDataType.String, 10, true, true),
        new JdeField("J8TAXX", "J8TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J8TARA", "J8TARA", JdeDataType.String, 20, true, true),
        new JdeField("J8AN8", "J8AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J8BOXN", "J8BOXN", JdeDataType.String, 20, true, true),
        new JdeField("J8YEID", "J8YEID", JdeDataType.String, 20),
        new JdeField("J8T4PP", "J8T4PP", JdeDataType.String, 20),
        new JdeField("J8AMNT", "J8AMNT", JdeDataType.Numeric),
        new JdeField("J8T4AP", "J8T4AP", JdeDataType.String, 2),
        new JdeField("J8PRCSD", "J8PRCSD", JdeDataType.String, 2),
        new JdeField("J8UPMJ", "J8UPMJ", JdeDataType.Numeric),
        new JdeField("J8UPMT", "J8UPMT", JdeDataType.Numeric),
        new JdeField("J8PID", "J8PID", JdeDataType.String, 20),
        new JdeField("J8JOBN", "J8JOBN", JdeDataType.String, 20),
        new JdeField("J8USER", "J8USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77230_0", "Primary Key on J8TAXYR, J8HMCO, J8TAXX, J8TARA, J8AN8, J8BOXN", new[] { "J8TAXYR", "J8HMCO", "J8TAXX", "J8TARA", "J8AN8", "J8BOXN" }, isUnique: true, isPrimaryKey: true)
    };
}
