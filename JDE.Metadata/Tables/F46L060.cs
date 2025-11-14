using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L060 - .
/// </summary>
public class F46L060 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SIMCU.
        /// </summary>
        public const string SIMCU = "SIMCU";

        /// <summary>
        /// SIAN8.
        /// </summary>
        public const string SIAN8 = "SIAN8";

        /// <summary>
        /// SILPNSL.
        /// </summary>
        public const string SILPNSL = "SILPNSL";

        /// <summary>
        /// SIHL03.
        /// </summary>
        public const string SIHL03 = "SIHL03";

        /// <summary>
        /// SILPNNO.
        /// </summary>
        public const string SILPNNO = "SILPNNO";

        /// <summary>
        /// SIASNDD.
        /// </summary>
        public const string SIASNDD = "SIASNDD";

        /// <summary>
        /// SIRFIDF.
        /// </summary>
        public const string SIRFIDF = "SIRFIDF";

        /// <summary>
        /// SIURCD.
        /// </summary>
        public const string SIURCD = "SIURCD";

        /// <summary>
        /// SIURDT.
        /// </summary>
        public const string SIURDT = "SIURDT";

        /// <summary>
        /// SIURAT.
        /// </summary>
        public const string SIURAT = "SIURAT";

        /// <summary>
        /// SIURAB.
        /// </summary>
        public const string SIURAB = "SIURAB";

        /// <summary>
        /// SIURRF.
        /// </summary>
        public const string SIURRF = "SIURRF";

        /// <summary>
        /// SIUSER.
        /// </summary>
        public const string SIUSER = "SIUSER";

        /// <summary>
        /// SIPID.
        /// </summary>
        public const string SIPID = "SIPID";

        /// <summary>
        /// SIMKEY.
        /// </summary>
        public const string SIMKEY = "SIMKEY";

        /// <summary>
        /// SISVRNAME.
        /// </summary>
        public const string SISVRNAME = "SISVRNAME";

        /// <summary>
        /// SIUPMJ.
        /// </summary>
        public const string SIUPMJ = "SIUPMJ";

        /// <summary>
        /// SITDAY.
        /// </summary>
        public const string SITDAY = "SITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46L060";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIMCU", "SIMCU", JdeDataType.String, 24, true, true),
        new JdeField("SIAN8", "SIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SILPNSL", "SILPNSL", JdeDataType.Numeric, null, true, true),
        new JdeField("SIHL03", "SIHL03", JdeDataType.String, 4),
        new JdeField("SILPNNO", "SILPNNO", JdeDataType.String, 2),
        new JdeField("SIASNDD", "SIASNDD", JdeDataType.String, 20),
        new JdeField("SIRFIDF", "SIRFIDF", JdeDataType.String, 2),
        new JdeField("SIURCD", "SIURCD", JdeDataType.String, 4),
        new JdeField("SIURDT", "SIURDT", JdeDataType.Numeric),
        new JdeField("SIURAT", "SIURAT", JdeDataType.Numeric),
        new JdeField("SIURAB", "SIURAB", JdeDataType.Numeric),
        new JdeField("SIURRF", "SIURRF", JdeDataType.String, 30),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIMKEY", "SIMKEY", JdeDataType.String, 30),
        new JdeField("SISVRNAME", "SISVRNAME", JdeDataType.String, 30),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SITDAY", "SITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L060_0", "Primary Key on SIMCU, SIAN8, SILPNSL", new[] { "SIMCU", "SIAN8", "SILPNSL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46L060_2", "Index on SIMCU, SIAN8, SIHL03", new[] { "SIMCU", "SIAN8", "SIHL03" })
    };
}
