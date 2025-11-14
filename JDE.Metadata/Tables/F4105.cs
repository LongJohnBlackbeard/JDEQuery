using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4105 - .
/// </summary>
public class F4105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COITM.
        /// </summary>
        public const string COITM = "COITM";

        /// <summary>
        /// COLITM.
        /// </summary>
        public const string COLITM = "COLITM";

        /// <summary>
        /// COAITM.
        /// </summary>
        public const string COAITM = "COAITM";

        /// <summary>
        /// COMCU.
        /// </summary>
        public const string COMCU = "COMCU";

        /// <summary>
        /// COLOCN.
        /// </summary>
        public const string COLOCN = "COLOCN";

        /// <summary>
        /// COLOTN.
        /// </summary>
        public const string COLOTN = "COLOTN";

        /// <summary>
        /// COLOTG.
        /// </summary>
        public const string COLOTG = "COLOTG";

        /// <summary>
        /// COLEDG.
        /// </summary>
        public const string COLEDG = "COLEDG";

        /// <summary>
        /// COUNCS.
        /// </summary>
        public const string COUNCS = "COUNCS";

        /// <summary>
        /// COCSPO.
        /// </summary>
        public const string COCSPO = "COCSPO";

        /// <summary>
        /// COCSIN.
        /// </summary>
        public const string COCSIN = "COCSIN";

        /// <summary>
        /// COURCD.
        /// </summary>
        public const string COURCD = "COURCD";

        /// <summary>
        /// COURDT.
        /// </summary>
        public const string COURDT = "COURDT";

        /// <summary>
        /// COURAT.
        /// </summary>
        public const string COURAT = "COURAT";

        /// <summary>
        /// COURAB.
        /// </summary>
        public const string COURAB = "COURAB";

        /// <summary>
        /// COURRF.
        /// </summary>
        public const string COURRF = "COURRF";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COJOBN.
        /// </summary>
        public const string COJOBN = "COJOBN";

        /// <summary>
        /// COUPMJ.
        /// </summary>
        public const string COUPMJ = "COUPMJ";

        /// <summary>
        /// COTDAY.
        /// </summary>
        public const string COTDAY = "COTDAY";

        /// <summary>
        /// COCCFL.
        /// </summary>
        public const string COCCFL = "COCCFL";

        /// <summary>
        /// COCRCS.
        /// </summary>
        public const string COCRCS = "COCRCS";

        /// <summary>
        /// COOSTC.
        /// </summary>
        public const string COOSTC = "COOSTC";

        /// <summary>
        /// COSTOC.
        /// </summary>
        public const string COSTOC = "COSTOC";
    }

    /// <inheritdoc />
    public override string TableName => "F4105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COITM", "COITM", JdeDataType.Numeric, null, true, true),
        new JdeField("COLITM", "COLITM", JdeDataType.String, 50),
        new JdeField("COAITM", "COAITM", JdeDataType.String, 50),
        new JdeField("COMCU", "COMCU", JdeDataType.String, 24, true, true),
        new JdeField("COLOCN", "COLOCN", JdeDataType.String, 40, true, true),
        new JdeField("COLOTN", "COLOTN", JdeDataType.String, 60, true, true),
        new JdeField("COLOTG", "COLOTG", JdeDataType.String, 6),
        new JdeField("COLEDG", "COLEDG", JdeDataType.String, 4, true, true),
        new JdeField("COUNCS", "COUNCS", JdeDataType.Numeric),
        new JdeField("COCSPO", "COCSPO", JdeDataType.String, 2),
        new JdeField("COCSIN", "COCSIN", JdeDataType.String, 2),
        new JdeField("COURCD", "COURCD", JdeDataType.String, 4),
        new JdeField("COURDT", "COURDT", JdeDataType.Numeric),
        new JdeField("COURAT", "COURAT", JdeDataType.Numeric),
        new JdeField("COURAB", "COURAB", JdeDataType.Numeric),
        new JdeField("COURRF", "COURRF", JdeDataType.String, 30),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COJOBN", "COJOBN", JdeDataType.String, 20),
        new JdeField("COUPMJ", "COUPMJ", JdeDataType.Numeric),
        new JdeField("COTDAY", "COTDAY", JdeDataType.Numeric),
        new JdeField("COCCFL", "COCCFL", JdeDataType.String, 2),
        new JdeField("COCRCS", "COCRCS", JdeDataType.Numeric),
        new JdeField("COOSTC", "COOSTC", JdeDataType.Numeric),
        new JdeField("COSTOC", "COSTOC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4105_0", "Primary Key on COITM, COMCU, COLOCN, COLOTN, COLEDG", new[] { "COITM", "COMCU", "COLOCN", "COLOTN", "COLEDG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4105_2", "Index on COITM, COMCU, COLEDG", new[] { "COITM", "COMCU", "COLEDG" }),
        new JdeIndex("F4105_3", "Index on COITM, COLEDG", new[] { "COITM", "COLEDG" }),
        new JdeIndex("F4105_4", "Index on COCSIN, COITM, COMCU, COLOCN, COLOTN", new[] { "COCSIN", "COITM", "COMCU", "COLOCN", "COLOTN" }),
        new JdeIndex("F4105_5", "Index on COCSPO, COITM, COMCU, COLOCN, COLOTN", new[] { "COCSPO", "COITM", "COMCU", "COLOCN", "COLOTN" }),
        new JdeIndex("F4105_6", "Index on COLEDG, COITM, COMCU, COLOCN, COLOTN", new[] { "COLEDG", "COITM", "COMCU", "COLOCN", "COLOTN" }),
        new JdeIndex("F4105_7", "Index on COCCFL", new[] { "COCCFL" })
    };
}
