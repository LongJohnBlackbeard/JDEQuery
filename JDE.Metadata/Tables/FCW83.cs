using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW83 - .
/// </summary>
public class FCW83 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCEV01.
        /// </summary>
        public const string PCEV01 = "PCEV01";

        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCCERS.
        /// </summary>
        public const string PCCERS = "PCCERS";

        /// <summary>
        /// PCCEFJ.
        /// </summary>
        public const string PCCEFJ = "PCCEFJ";

        /// <summary>
        /// PCCXPJ.
        /// </summary>
        public const string PCCXPJ = "PCCXPJ";

        /// <summary>
        /// PCNROU.
        /// </summary>
        public const string PCNROU = "PCNROU";

        /// <summary>
        /// PCTROU.
        /// </summary>
        public const string PCTROU = "PCTROU";

        /// <summary>
        /// PCACST.
        /// </summary>
        public const string PCACST = "PCACST";

        /// <summary>
        /// PCLTQP.
        /// </summary>
        public const string PCLTQP = "PCLTQP";

        /// <summary>
        /// PCTFRD.
        /// </summary>
        public const string PCTFRD = "PCTFRD";

        /// <summary>
        /// PCTFRQ.
        /// </summary>
        public const string PCTFRQ = "PCTFRQ";

        /// <summary>
        /// PCALTD.
        /// </summary>
        public const string PCALTD = "PCALTD";

        /// <summary>
        /// PCDAYE.
        /// </summary>
        public const string PCDAYE = "PCDAYE";

        /// <summary>
        /// PCDAYL.
        /// </summary>
        public const string PCDAYL = "PCDAYL";
    }

    /// <inheritdoc />
    public override string TableName => "FCW83";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PCEV01", "PCEV01", JdeDataType.String, 2, true, true),
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCCERS", "PCCERS", JdeDataType.String, 4),
        new JdeField("PCCEFJ", "PCCEFJ", JdeDataType.Numeric),
        new JdeField("PCCXPJ", "PCCXPJ", JdeDataType.Numeric),
        new JdeField("PCNROU", "PCNROU", JdeDataType.String, 8),
        new JdeField("PCTROU", "PCTROU", JdeDataType.String, 8),
        new JdeField("PCACST", "PCACST", JdeDataType.Numeric),
        new JdeField("PCLTQP", "PCLTQP", JdeDataType.Numeric),
        new JdeField("PCTFRD", "PCTFRD", JdeDataType.Numeric),
        new JdeField("PCTFRQ", "PCTFRQ", JdeDataType.Numeric),
        new JdeField("PCALTD", "PCALTD", JdeDataType.Numeric),
        new JdeField("PCDAYE", "PCDAYE", JdeDataType.Numeric),
        new JdeField("PCDAYL", "PCDAYL", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW83_0", "Primary Key on PCITM, PCEV01, PCAN8, PCMCU", new[] { "PCITM", "PCEV01", "PCAN8", "PCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
