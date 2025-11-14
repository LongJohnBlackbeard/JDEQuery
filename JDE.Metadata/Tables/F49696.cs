using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49696 - .
/// </summary>
public class F49696 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DJCO.
        /// </summary>
        public const string DJCO = "DJCO";

        /// <summary>
        /// DJEMCU.
        /// </summary>
        public const string DJEMCU = "DJEMCU";

        /// <summary>
        /// DJMCU.
        /// </summary>
        public const string DJMCU = "DJMCU";

        /// <summary>
        /// DJDCT.
        /// </summary>
        public const string DJDCT = "DJDCT";

        /// <summary>
        /// DJDOC.
        /// </summary>
        public const string DJDOC = "DJDOC";

        /// <summary>
        /// DJKCO.
        /// </summary>
        public const string DJKCO = "DJKCO";

        /// <summary>
        /// DJSEQN.
        /// </summary>
        public const string DJSEQN = "DJSEQN";

        /// <summary>
        /// DJDCCD.
        /// </summary>
        public const string DJDCCD = "DJDCCD";

        /// <summary>
        /// DJVMCU.
        /// </summary>
        public const string DJVMCU = "DJVMCU";

        /// <summary>
        /// DJLDNM.
        /// </summary>
        public const string DJLDNM = "DJLDNM";

        /// <summary>
        /// DJSHPN.
        /// </summary>
        public const string DJSHPN = "DJSHPN";

        /// <summary>
        /// DJRSSN.
        /// </summary>
        public const string DJRSSN = "DJRSSN";

        /// <summary>
        /// DJDOCO.
        /// </summary>
        public const string DJDOCO = "DJDOCO";

        /// <summary>
        /// DJDCTO.
        /// </summary>
        public const string DJDCTO = "DJDCTO";

        /// <summary>
        /// DJKCOO.
        /// </summary>
        public const string DJKCOO = "DJKCOO";

        /// <summary>
        /// DJLNID.
        /// </summary>
        public const string DJLNID = "DJLNID";

        /// <summary>
        /// DJSRCO.
        /// </summary>
        public const string DJSRCO = "DJSRCO";

        /// <summary>
        /// DJURCD.
        /// </summary>
        public const string DJURCD = "DJURCD";

        /// <summary>
        /// DJURDT.
        /// </summary>
        public const string DJURDT = "DJURDT";

        /// <summary>
        /// DJURAT.
        /// </summary>
        public const string DJURAT = "DJURAT";

        /// <summary>
        /// DJURAB.
        /// </summary>
        public const string DJURAB = "DJURAB";

        /// <summary>
        /// DJURRF.
        /// </summary>
        public const string DJURRF = "DJURRF";

        /// <summary>
        /// DJUSER.
        /// </summary>
        public const string DJUSER = "DJUSER";

        /// <summary>
        /// DJPID.
        /// </summary>
        public const string DJPID = "DJPID";

        /// <summary>
        /// DJJOBN.
        /// </summary>
        public const string DJJOBN = "DJJOBN";

        /// <summary>
        /// DJUPMJ.
        /// </summary>
        public const string DJUPMJ = "DJUPMJ";

        /// <summary>
        /// DJTDAY.
        /// </summary>
        public const string DJTDAY = "DJTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49696";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DJCO", "DJCO", JdeDataType.String, 10, true, true),
        new JdeField("DJEMCU", "DJEMCU", JdeDataType.String, 24, true, true),
        new JdeField("DJMCU", "DJMCU", JdeDataType.String, 24, true, true),
        new JdeField("DJDCT", "DJDCT", JdeDataType.String, 4, true, true),
        new JdeField("DJDOC", "DJDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DJKCO", "DJKCO", JdeDataType.String, 10, true, true),
        new JdeField("DJSEQN", "DJSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("DJDCCD", "DJDCCD", JdeDataType.String, 8),
        new JdeField("DJVMCU", "DJVMCU", JdeDataType.String, 24),
        new JdeField("DJLDNM", "DJLDNM", JdeDataType.Numeric),
        new JdeField("DJSHPN", "DJSHPN", JdeDataType.Numeric),
        new JdeField("DJRSSN", "DJRSSN", JdeDataType.Numeric),
        new JdeField("DJDOCO", "DJDOCO", JdeDataType.Numeric),
        new JdeField("DJDCTO", "DJDCTO", JdeDataType.String, 4),
        new JdeField("DJKCOO", "DJKCOO", JdeDataType.String, 10),
        new JdeField("DJLNID", "DJLNID", JdeDataType.Numeric),
        new JdeField("DJSRCO", "DJSRCO", JdeDataType.String, 2),
        new JdeField("DJURCD", "DJURCD", JdeDataType.String, 4),
        new JdeField("DJURDT", "DJURDT", JdeDataType.Numeric),
        new JdeField("DJURAT", "DJURAT", JdeDataType.Numeric),
        new JdeField("DJURAB", "DJURAB", JdeDataType.Numeric),
        new JdeField("DJURRF", "DJURRF", JdeDataType.String, 30),
        new JdeField("DJUSER", "DJUSER", JdeDataType.String, 20),
        new JdeField("DJPID", "DJPID", JdeDataType.String, 20),
        new JdeField("DJJOBN", "DJJOBN", JdeDataType.String, 20),
        new JdeField("DJUPMJ", "DJUPMJ", JdeDataType.Numeric),
        new JdeField("DJTDAY", "DJTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49696_0", "Primary Key on DJCO, DJEMCU, DJMCU, DJDCT, DJDOC, DJKCO, DJSEQN", new[] { "DJCO", "DJEMCU", "DJMCU", "DJDCT", "DJDOC", "DJKCO", "DJSEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49696_2", "Index on DJDCCD, DJDOCO, DJDCTO, DJKCOO, DJLNID", new[] { "DJDCCD", "DJDOCO", "DJDCTO", "DJKCOO", "DJLNID" })
    };
}
