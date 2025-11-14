using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77110 - .
/// </summary>
public class F77110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J9TAXYR.
        /// </summary>
        public const string J9TAXYR = "J9TAXYR";

        /// <summary>
        /// J9FORMSID.
        /// </summary>
        public const string J9FORMSID = "J9FORMSID";

        /// <summary>
        /// J9CO.
        /// </summary>
        public const string J9CO = "J9CO";

        /// <summary>
        /// J9TAXX.
        /// </summary>
        public const string J9TAXX = "J9TAXX";

        /// <summary>
        /// J9FTSEQ.
        /// </summary>
        public const string J9FTSEQ = "J9FTSEQ";

        /// <summary>
        /// J9LTSEQ.
        /// </summary>
        public const string J9LTSEQ = "J9LTSEQ";

        /// <summary>
        /// J9CTSEQ.
        /// </summary>
        public const string J9CTSEQ = "J9CTSEQ";

        /// <summary>
        /// J9PFCNO.
        /// </summary>
        public const string J9PFCNO = "J9PFCNO";

        /// <summary>
        /// J9SFCNO.
        /// </summary>
        public const string J9SFCNO = "J9SFCNO";

        /// <summary>
        /// J9EV01.
        /// </summary>
        public const string J9EV01 = "J9EV01";

        /// <summary>
        /// J9EV02.
        /// </summary>
        public const string J9EV02 = "J9EV02";

        /// <summary>
        /// J9EV03.
        /// </summary>
        public const string J9EV03 = "J9EV03";

        /// <summary>
        /// J9UPMJ.
        /// </summary>
        public const string J9UPMJ = "J9UPMJ";

        /// <summary>
        /// J9UPMT.
        /// </summary>
        public const string J9UPMT = "J9UPMT";

        /// <summary>
        /// J9PID.
        /// </summary>
        public const string J9PID = "J9PID";

        /// <summary>
        /// J9JOBN.
        /// </summary>
        public const string J9JOBN = "J9JOBN";

        /// <summary>
        /// J9USER.
        /// </summary>
        public const string J9USER = "J9USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J9TAXYR", "J9TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J9FORMSID", "J9FORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("J9CO", "J9CO", JdeDataType.String, 10),
        new JdeField("J9TAXX", "J9TAXX", JdeDataType.String, 40),
        new JdeField("J9FTSEQ", "J9FTSEQ", JdeDataType.Numeric),
        new JdeField("J9LTSEQ", "J9LTSEQ", JdeDataType.Numeric),
        new JdeField("J9CTSEQ", "J9CTSEQ", JdeDataType.Numeric),
        new JdeField("J9PFCNO", "J9PFCNO", JdeDataType.Numeric),
        new JdeField("J9SFCNO", "J9SFCNO", JdeDataType.Numeric),
        new JdeField("J9EV01", "J9EV01", JdeDataType.String, 2),
        new JdeField("J9EV02", "J9EV02", JdeDataType.String, 2),
        new JdeField("J9EV03", "J9EV03", JdeDataType.String, 2),
        new JdeField("J9UPMJ", "J9UPMJ", JdeDataType.Numeric),
        new JdeField("J9UPMT", "J9UPMT", JdeDataType.Numeric),
        new JdeField("J9PID", "J9PID", JdeDataType.String, 20),
        new JdeField("J9JOBN", "J9JOBN", JdeDataType.String, 20),
        new JdeField("J9USER", "J9USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77110_0", "Primary Key on J9TAXYR, J9FORMSID", new[] { "J9TAXYR", "J9FORMSID" }, isUnique: true, isPrimaryKey: true)
    };
}
